using Client.Forms.Dialogs.Utakmica;
using Client.Forms.Exceptions;
using Client.Forms.ServerCommunication;
using Client.Forms.Session;
using Client.Forms.UserControls.Takmicenje;
using Client.Forms.Validators;
using Common.Communication;
using Common.Domain;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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
        private List<Utakmica> utakmice = new List<Utakmica>();

        public SacuvajTakmicenjeController(UCRegularniDeo uCRegularniDeo)
        {
            this.uCRegularniDeo = uCRegularniDeo;
            
        }
        internal void Init()
        {
            uCRegularniDeo.CbTimovi.DataSource = Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.VratiSveTimove);
            uCRegularniDeo.BtnDodajUtakmicu.Enabled = false;
            uCRegularniDeo.BtnSacuvajTakmicenje.Enabled = false;
        }

        internal void DodajTimULigu()
        {
            ComboBoxValidator cbValidator = new ComboBoxValidator();
            ValidationResult cbResult = cbValidator.Validate(uCRegularniDeo.CbTimovi);
            if (!cbResult.IsValid)
            {
                MessageBox.Show("Sistem ne može da doda tim u ligu! " + cbResult.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
                uCRegularniDeo.BtnDodajUtakmicu.Enabled = true;
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
            try
            {
                FrmRegularUtakmica frmRegularUtakmica = new FrmRegularUtakmica();
                frmRegularUtakmica.ShowDialog();
                utakmice.Add(Session.SessionData.Instance.Utakmica);
                uCRegularniDeo.BtnSacuvajTakmicenje.Enabled = true;
            }
            catch (ServerCommunicationException)
            {

                throw;
            }
            
        }

        internal void SacuvajTakmicenje()
        {
            try
            {
                Takmicenje takmicenje = new Takmicenje
                {
                    Naziv = uCRegularniDeo.TxtNazivTakmicenja.Text,
                    BrojKola = Convert.ToInt32(uCRegularniDeo.TxtBrojKola.Text),
                    Utakmice = utakmice
                };
                TakmicenjeValidator validator = new TakmicenjeValidator();
                var result = validator.Validate(takmicenje);
                if (!result.IsValid)
                {
                    MessageBox.Show("Sistem ne može da zapamti takmičenje " + result.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    uCRegularniDeo.TxtNazivTakmicenja.BackColor = Color.LightCoral;
                    return;
                }
                else uCRegularniDeo.TxtNazivTakmicenja.BackColor = Color.White;
                Communication.Instance.SendRequestNoResult(Operation.SacuvajTakmicenje, takmicenje);
                MessageBox.Show("Sistem je zapamtio takmičenje!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            
        }
    }
}
