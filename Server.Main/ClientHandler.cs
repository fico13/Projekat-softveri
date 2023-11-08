using Common.Communication;
using Common.Domain;
using Server.ApplicationLogic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server.Main
{
    public class ClientHandler
    {
        private Socket klijentSoket;
        private CommunicationHelper helper;
        private List<Administrator> administrators;
        public EventHandler OdjavljeniKlijent;
        public Administrator Administrator { get; set; }
        private object lockObject = new object();
        


        public ClientHandler(Socket klijentSoket, List<Administrator> administrators)
        {
            this.klijentSoket = klijentSoket;
            this.administrators = administrators;
            helper = new CommunicationHelper(klijentSoket);
        }

        private bool kraj = false;
        internal void ObradiZahteve()
        {
            try
            {
                while (!kraj)
                {
                    Request request = helper.Receive<Request>();
                    Response response = CreateResponse(request);
                    helper.Send(response);
                }
            }
            catch (IOException)
            {
                administrators.Remove(Administrator);
            }
            finally
            {
                CloseSocket();
            }
        }

        private Response CreateResponse(Request request)
        {
            Response response = new Response();
            switch (request.Operation)
            {
                case Operation.UlogujAdministratora:
                    response.ResponseObject = Controller.Instance.UlogujAdministratora((Administrator)request.RequestObject);
                    Administrator administrator = (Administrator)response.ResponseObject;
                    if (response.ResponseObject == null)
                    {
                        response.Uspesno = false;
                        response.Poruka = "Sistem ne može da pronađe administratora na osnovu unetih vrednosti!";
                    }
                    else
                    {
                        if (!administrators.Contains(administrator))
                        {
                            administrators.Add(administrator);
                            Administrator = administrator;
                        }
                        else
                        {
                            response.Uspesno = false;
                            response.Poruka = "Administrator je već ulogovan";
                        }
                    }
                    break;
                case Operation.SacuvajDvoranu:
                    Controller.Instance.SacuvajDvoranu((Dvorana)request.RequestObject);
                    break;
                case Operation.VratiSveDvorane:
                    response.ResponseObject = Controller.Instance.VratiSveDvorane();
                    break;
                case Operation.SacuvajTim:
                    Controller.Instance.SacuvajTim((Tim)request.RequestObject);
                    break;
                case Operation.NadjiTimove:
                    response.ResponseObject = Controller.Instance.NadjiTimove((Tim)request.RequestObject);
                    break;
                case Operation.VratiSveTimove:
                    response.ResponseObject = Controller.Instance.VratiSveTimove();
                    break;
                case Operation.SacuvajIgraca:
                    Controller.Instance.SacuvajIgraca((Igrac)request.RequestObject);
                    break;
                case Operation.NadjiIgrace:
                    response.ResponseObject = Controller.Instance.NadjiIgrace((Igrac)request.RequestObject);
                    break;
                case Operation.IzmeniIgraca:
                    Controller.Instance.IzmeniIgraca((Igrac)request.RequestObject);
                    break;
                case Operation.SacuvajUtakmicu:
                    Controller.Instance.SacuvajUtakmicu((Utakmica)request.RequestObject);
                    break;
                case Operation.NadjiUtakmice:
                    response.ResponseObject = Controller.Instance.NadjiUtakmice((Utakmica)request.RequestObject);
                    break;
                case Operation.IzmeniUtakmicu:
                    Controller.Instance.IzmeniUtakmicu((Utakmica)request.RequestObject);
                    break;
                case Operation.End:
                    kraj = true;
                    break;
                case Operation.UcitajUtakmicu:
                    response.ResponseObject = Controller.Instance.UcitajUtakmicu((Utakmica)request.RequestObject);
                    break;
                case Operation.UcitajTim:
                    response.ResponseObject = Controller.Instance.UcitajTim((Tim)request.RequestObject);
                    break;
                case Operation.UcitajIgraca:
                    response.ResponseObject = Controller.Instance.UcitajIgraca((Igrac)request.RequestObject);
                    break;
                case Operation.NadjiStatistiku:
                    response.ResponseObject = Controller.Instance.NadjiStatistike((Statistika)request.RequestObject);
                    break;
                case Operation.SacuvajTakmicenje:
                    Controller.Instance.SacuvajTakmicenje((Takmicenje)request.RequestObject);
                    break;
                default:
                    break;
            }
            return response;
        }
        internal void CloseSocket()
        {
            lock(lockObject)
            {
                if(klijentSoket != null)
                {
                    kraj = true;
                    klijentSoket.Shutdown(SocketShutdown.Both);
                    klijentSoket.Close();
                    klijentSoket = null;
                    OdjavljeniKlijent?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}