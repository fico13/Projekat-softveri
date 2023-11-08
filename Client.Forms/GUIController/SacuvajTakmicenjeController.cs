using Client.Forms.ServerCommunication;
using Client.Forms.Session;
using Client.Forms.UserControls.Takmicenje;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Forms.GUIController
{
    public class SacuvajTakmicenjeController
    {
        private UCRegularniDeo uCRegularniDeo;
        private List<Tim> timovi = new List<Tim>();
        private List<Tim> domaci = new List<Tim>();
        private List<Tim> gostujuci = new List<Tim>();

        public SacuvajTakmicenjeController(UCRegularniDeo uCRegularniDeo)
        {
            this.uCRegularniDeo = uCRegularniDeo;
            this.uCRegularniDeo.CbTimovi.DataSource = Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.VratiSveTimove);
        }

        internal void DodajTimULigu()
        {
            try
            {
                Tim tim = (Tim)uCRegularniDeo.CbTimovi.SelectedItem;
                timovi.Add(tim);
               
                uCRegularniDeo.RtbTimovi.AppendText(tim + Environment.NewLine);
                uCRegularniDeo.CbTimovi.SelectedIndex = uCRegularniDeo.CbTimovi.SelectedIndex + 1;
            }
            catch (ArgumentOutOfRangeException)
            {
                uCRegularniDeo.BtnDodajTim.Enabled = false;
                uCRegularniDeo.TxtBrojKola.Text = (2 * timovi.Count()).ToString();
            }
           

        }

        internal void DodajUtakmice()
        {
            SessionData.Instance.Domaci = new List<Tim>();
            foreach (var t in timovi)
            {
                SessionData.Instance.Domaci.Add(t);
            }
            SessionData.Instance.Gost = new List<Tim>();
            foreach (var t in timovi)
            {
                SessionData.Instance.Gost.Add(t);
            }
            uCRegularniDeo.CbDomacin.DataSource = SessionData.Instance.Domaci;
            uCRegularniDeo.CbGost.DataSource = SessionData.Instance.Gost;

        }

        internal void SacuvajTakmicenje()
        {
           
            Takmicenje takmicenje = new Takmicenje
            {
                Naziv = uCRegularniDeo.TxtNazivTakmicenja.Text,
                BrojKola = Convert.ToInt32(uCRegularniDeo.TxtBrojKola.Text),
                Timovi = timovi
            };
            Communication.Instance.SendRequestNoResult(Operation.SacuvajTakmicenje, takmicenje);
        }
    }
}
