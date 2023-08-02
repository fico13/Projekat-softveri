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
        private List<ClientHandler> clients;
        private CommunicationHelper helper;
        private List<Administrator> administrators;

        public ClientHandler(Socket klijentSoket, List<ClientHandler> clients, List<Administrator> administrators)
        {
            this.klijentSoket = klijentSoket;
            this.clients = clients;
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
            catch (IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
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
                        response.Poruka = "Administrator ne postoji!";
                    }
                    else
                    {
                        foreach (var admin in administrators)
                        {
                            if (admin.Username == administrator.Username && admin.Password == administrator.Password)
                            {
                                response.Uspesno = false;
                                response.Poruka = "Administrator je vec ulogovan!";
                            }
                        }
                        administrators.Add(administrator);
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
                default:
                    break;
            }
            return response;
        }
        private void CloseSocket()
        {
            Debug.WriteLine(">>>>");
        }
    }
}