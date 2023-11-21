using Client.Forms.Dialogs.Utakmica;
using Client.Forms.Exceptions;
using Client.Forms.ServerCommunication;
using Client.Forms.Session;
using Client.Forms.UserControls.Takmicenje;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.GUIController
{
    public class SacuvajTakmicenjeController
    {
        private UCRegularniDeo uCRegularniDeo;
        private List<Tim> timovi = new List<Tim>();
        private List<Tim> domaci = new List<Tim>();
        private List<Tim> gostujuci = new List<Tim>();
        private List<Utakmica> utakmice = new List<Utakmica>();

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
                uCRegularniDeo.TxtBrojKola.Text = (2 * timovi.Count() - 2).ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                uCRegularniDeo.BtnDodajTim.Enabled = false;
                uCRegularniDeo.TxtBrojKola.Text = (2 * timovi.Count() - 2).ToString();
            }
        }

        

        internal void DodajUtakmice()
        {
            SessionData.Instance.Domaci = new List<Tim>();
            SessionData.Instance.Gost = new List<Tim>();
            foreach (var tim in timovi)
            {
                SessionData.Instance.Domaci.Add(tim);
            }
            foreach (var tim in timovi)
            {
                SessionData.Instance.Gost.Add(tim);
            }
            FrmRegularUtakmica frmRegularUtakmica = new FrmRegularUtakmica();
            frmRegularUtakmica.ShowDialog();
            utakmice.Add(Session.SessionData.Instance.Utakmica);
        }

        internal void SacuvajTakmicenje()
        {
            Takmicenje takmicenje = new Takmicenje
            {
                Naziv = uCRegularniDeo.TxtNazivTakmicenja.Text,
                BrojKola = Convert.ToInt32(uCRegularniDeo.TxtBrojKola.Text),
                Utakmice = utakmice
            };
            Communication.Instance.SendRequestNoResult(Operation.SacuvajTakmicenje, takmicenje);
        }
    }
}
