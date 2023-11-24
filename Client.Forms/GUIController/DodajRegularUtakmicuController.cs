using Client.Forms.Dialogs.Utakmica;
using Client.Forms.Exceptions;
using Client.Forms.GUIHelper;
using Client.Forms.ServerCommunication;
using Client.Forms.Validators;
using Common.Communication;
using Common.Domain;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.GUIController
{
    public class DodajRegularUtakmicuController
    {
        private FrmRegularUtakmica frmRegularUtakmica;
        private List<Statistika> statistike = new List<Statistika>();

        public DodajRegularUtakmicuController(FrmRegularUtakmica frmRegularUtakmica)
        {
            this.frmRegularUtakmica = frmRegularUtakmica;
        }

        internal void Init()
        {
            frmRegularUtakmica.CbDomacin.DataSource = Session.SessionData.Instance.Domaci;
            frmRegularUtakmica.CbGost.DataSource = Session.SessionData.Instance.Gost;
            frmRegularUtakmica.BtnSacuvajUtakmicu.Enabled = false;
            frmRegularUtakmica.BtnDodajStatistikuDomacin.Enabled = false;
            frmRegularUtakmica.BtnDodajStatistikuGost.Enabled = false;
        }

        internal void UcitajIgrace()
        {
            ComboBoxValidator cbValidator = new ComboBoxValidator(frmRegularUtakmica.CbGost.SelectedIndex);
            ValidationResult  cbResult = cbValidator.Validate(frmRegularUtakmica.CbDomacin);
            if(!cbResult.IsValid)
            {
                MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti! " + cbResult.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cbValidator = new ComboBoxValidator(frmRegularUtakmica.CbDomacin.SelectedIndex);
            cbResult = cbValidator.Validate(frmRegularUtakmica.CbGost);
            if (!cbResult.IsValid)
            {
                MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti! " + cbResult.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Tim domacin = (Tim)frmRegularUtakmica.CbDomacin.SelectedItem;
            frmRegularUtakmica.CbDomacin.Enabled = false;
            Tim gost = (Tim)frmRegularUtakmica.CbGost.SelectedItem;
            frmRegularUtakmica.CbGost.Enabled = false;
            try
            {
                Igrac domaci = new Igrac
                {
                    FindCondition = $"where t.TimId = {domacin.TimId}"
                };
                List<Igrac> domaciIgraci = new List<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, domaci));
                if (domaciIgraci.Count == 0)
                {
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    frmRegularUtakmica.CbIgracDomacina.DataSource = null;
                    return;
                }
                Igrac gosti = new Igrac
                {
                    FindCondition = $"where t.TimId = {gost.TimId}"
                };
                List<Igrac> gostujuciIgraci = new List<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, gosti));
                if (gostujuciIgraci.Count == 0)
                {
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    frmRegularUtakmica.CbIgracGosta.DataSource = null;
                    return;
                }
                frmRegularUtakmica.CbIgracDomacina.DataSource = domaciIgraci;
                frmRegularUtakmica.CbIgracGosta.DataSource = gostujuciIgraci;
                frmRegularUtakmica.BtnDodajStatistikuDomacin.Enabled = true;
                MessageBox.Show("Sistem je našao igrače po zadatoj vrednosti!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        internal void DodajUtakmicu()
        {
            BrojValidator bv = new BrojValidator();
            ValidationResult result = bv.Validate(frmRegularUtakmica.TxtBrojPoenaDomacin);
            if(!result.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + result.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmRegularUtakmica.TxtBrojPoenaDomacin.BackColor = Color.LightCoral;
                return;
            }
            else frmRegularUtakmica.TxtBrojPoenaDomacin.BackColor = Color.White;
            result = bv.Validate(frmRegularUtakmica.TxtBrojPoenaGost);
            if (!result.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + result.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmRegularUtakmica.TxtBrojPoenaGost.BackColor = Color.LightCoral;
                return;
            }
            else frmRegularUtakmica.TxtBrojPoenaGost.BackColor = Color.White;
            result = bv.Validate(frmRegularUtakmica.TxtBrojGledalaca);
            if (!result.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + result.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmRegularUtakmica.TxtBrojGledalaca.BackColor = Color.LightCoral;
                return;
            }
            else frmRegularUtakmica.TxtBrojGledalaca.BackColor = Color.White;
            DatumValidator dv = new DatumValidator();
            ValidationResult res = dv.Validate(frmRegularUtakmica.DtpDatum);
            if (!res.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + res.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmRegularUtakmica.DtpDatum.BackColor = Color.LightCoral;
                return;
            }
            BrojacValidator brojac = new BrojacValidator();
            ValidationResult brojacResult = brojac.Validate(frmRegularUtakmica.NudRunda);
            if (!brojacResult.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + brojacResult.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmRegularUtakmica.NudRunda.BackColor = Color.LightCoral;
                return;
            }
            try
            {
                Utakmica utakmica = new Utakmica
                {
                    BrojPoenaDomacin = Convert.ToInt32(frmRegularUtakmica.TxtBrojPoenaDomacin.Text),
                    BrojPoenaGost = Convert.ToInt32(frmRegularUtakmica.TxtBrojPoenaGost.Text),
                    DateString = frmRegularUtakmica.DtpDatum.Value.ToString(),
                    BrojGledalaca = Convert.ToInt32(frmRegularUtakmica.TxtBrojGledalaca.Text),
                    Runda = Convert.ToInt32(frmRegularUtakmica.NudRunda.Value),
                    FazaTakmicenja = "regularni deo",
                    Domacin = (Tim)frmRegularUtakmica.CbDomacin.SelectedItem,
                    Gost = (Tim)frmRegularUtakmica.CbGost.SelectedItem,
                    Statistka = statistike
                };

                UtakmicaValidator uv = new UtakmicaValidator(utakmica.BrojPoenaGost, utakmica.Domacin.Dvorana.Kapacitet);
                ValidationResult utakmicaResult = uv.Validate(utakmica);
                if (!utakmicaResult.IsValid)
                {
                    MessageBox.Show("Sistem ne može da zapamti utakmicu! " + utakmicaResult.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (utakmica.BrojPoenaDomacin > utakmica.BrojPoenaGost)
                {
                    utakmica.Domacin.BrojPobeda += 1;
                    utakmica.Domacin.Bodovi += 2;
                    utakmica.Gost.BrojPoraza += 1;
                    utakmica.Gost.Bodovi += 1;
                }
                if (utakmica.BrojPoenaDomacin < utakmica.BrojPoenaGost)
                {
                    utakmica.Domacin.BrojPoraza += 1;
                    utakmica.Domacin.Bodovi += 1;
                    utakmica.Gost.BrojPobeda += 1;
                    utakmica.Gost.Bodovi += 2;
                }
                Session.SessionData.Instance.Utakmica = utakmica;
                frmRegularUtakmica.Dispose();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

       

        internal void DodajStatsitkuGosta()
        {
            BrojValidator bv = new BrojValidator();
            ValidationResult result = bv.Validate(frmRegularUtakmica.TxtPoeniGostIgrac);
            if (!result.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + result.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmRegularUtakmica.TxtPoeniGostIgrac.BackColor = Color.LightCoral;
                return;
            }
            else frmRegularUtakmica.TxtPoeniGostIgrac.BackColor = Color.White;
            bv = new BrojValidator();
            result = bv.Validate(frmRegularUtakmica.TxtSkokoviGostIgrac);
            if (!result.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + result.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmRegularUtakmica.TxtSkokoviGostIgrac.BackColor = Color.LightCoral;
                return;
            }
            else frmRegularUtakmica.TxtSkokoviGostIgrac.BackColor = Color.White;
            bv = new BrojValidator();
            result = bv.Validate(frmRegularUtakmica.TxtAsistencijeGostIgrac);
            if (!result.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + result.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmRegularUtakmica.TxtAsistencijeGostIgrac.BackColor = Color.LightCoral;
                return;
            }
            else frmRegularUtakmica.TxtAsistencijeGostIgrac.BackColor = Color.White;
            ComboBoxValidator cbValidator = new ComboBoxValidator();
            ValidationResult cbResult = cbValidator.Validate(frmRegularUtakmica.CbIgracGosta);
            if (!cbResult.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + cbResult.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Statistika statistika = new Statistika
                {
                    Igrac = (Igrac)frmRegularUtakmica.CbIgracGosta.SelectedItem,
                    Poeni = Convert.ToInt32(frmRegularUtakmica.TxtPoeniGostIgrac.Text),
                    Skokovi = Convert.ToInt32(frmRegularUtakmica.TxtSkokoviGostIgrac.Text),
                    Asistencije = Convert.ToInt32(frmRegularUtakmica.TxtAsistencijeGostIgrac.Text),
                };
                statistike.Add(statistika);
                OcistiPodatkeIgrac();
                frmRegularUtakmica.CbIgracGosta.SelectedIndex = frmRegularUtakmica.CbIgracGosta.SelectedIndex + 1;
            }
            catch (ArgumentOutOfRangeException)
            {
                frmRegularUtakmica.BtnDodajStatistikuGost.Enabled = false;
                frmRegularUtakmica.BtnSacuvajUtakmicu.Enabled = true;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        private void OcistiPodatkeIgrac()
        {
            frmRegularUtakmica.TxtPoeniDomacinIgrac.Text = "";
            frmRegularUtakmica.TxtSkokoviDomacinIgrac.Text = "";
            frmRegularUtakmica.TxtAsistencijeDomacinIgrac.Text = "";
            frmRegularUtakmica.TxtPoeniGostIgrac.Text = "";
            frmRegularUtakmica.TxtSkokoviGostIgrac.Text = "";
            frmRegularUtakmica.TxtAsistencijeGostIgrac.Text = "";
        }

        internal void DodajStatsitkuDomacina()
        {
            BrojValidator bv = new BrojValidator();
            ValidationResult result = bv.Validate(frmRegularUtakmica.TxtPoeniDomacinIgrac);
            if (!result.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + result.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmRegularUtakmica.TxtPoeniDomacinIgrac.BackColor = Color.LightCoral;
                return;
            }
            else frmRegularUtakmica.TxtPoeniDomacinIgrac.BackColor = Color.White;
            bv = new BrojValidator();
            result = bv.Validate(frmRegularUtakmica.TxtSkokoviDomacinIgrac);
            if (!result.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + result.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmRegularUtakmica.TxtSkokoviDomacinIgrac.BackColor = Color.LightCoral;
                return;
            }
            else frmRegularUtakmica.TxtSkokoviDomacinIgrac.BackColor = Color.White;
            bv = new BrojValidator();
            result = bv.Validate(frmRegularUtakmica.TxtAsistencijeDomacinIgrac);
            if (!result.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + result.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmRegularUtakmica.TxtAsistencijeDomacinIgrac.BackColor = Color.LightCoral;
                return;
            }
            else frmRegularUtakmica.TxtAsistencijeDomacinIgrac.BackColor = Color.White;
            ComboBoxValidator cbValidator = new ComboBoxValidator();
            ValidationResult cbResult = cbValidator.Validate(frmRegularUtakmica.CbIgracDomacina);
            if (!cbResult.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + cbResult.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Statistika statistika = new Statistika
                {
                    Igrac = (Igrac)frmRegularUtakmica.CbIgracDomacina.SelectedItem,
                    Poeni = Convert.ToInt32(frmRegularUtakmica.TxtPoeniDomacinIgrac.Text),
                    Skokovi = Convert.ToInt32(frmRegularUtakmica.TxtSkokoviDomacinIgrac.Text),
                    Asistencije = Convert.ToInt32(frmRegularUtakmica.TxtAsistencijeDomacinIgrac.Text),
                };
                statistike.Add(statistika);
                OcistiPodatkeIgrac();
                frmRegularUtakmica.CbIgracDomacina.SelectedIndex = frmRegularUtakmica.CbIgracDomacina.SelectedIndex + 1;
            }
            catch (ArgumentOutOfRangeException)
            {
                frmRegularUtakmica.BtnDodajStatistikuDomacin.Enabled = false;
                frmRegularUtakmica.BtnDodajStatistikuGost.Enabled = true;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }
    }
}
