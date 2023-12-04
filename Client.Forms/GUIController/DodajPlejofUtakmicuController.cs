using Client.Forms.Dialogs.Utakmica;
using Client.Forms.Exceptions;
using Client.Forms.ServerCommunication;
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
    public class DodajPlejofUtakmicuController
    {
        private FrmPlejofUtakmica frmUtakmica;
        private Tim tim1;
        private Tim tim2;
        private List<Statistika> statistike = new List<Statistika>();
        private string faza;

        

        public DodajPlejofUtakmicuController(FrmPlejofUtakmica frmUtakmica, Tim tim1, Tim tim2, string faza)
        {
            this.frmUtakmica = frmUtakmica;
            this.tim1 = tim1;
            this.tim2 = tim2;
            this.faza = faza;
            this.frmUtakmica.TxtTim1.Text = tim1.Ime;
            this.frmUtakmica.TxtTim2.Text = tim2.Ime;
        }

        internal void Init()
        {
            frmUtakmica.BtnDodajStatistikuDomacin.Enabled = false;
            frmUtakmica.BtnDodajStatistikuGost.Enabled = false;
            frmUtakmica.BtnSacuvajUtakmicu.Enabled = false;
        }


        internal void UcitajIgrace()
        {
            try
            {
                Igrac domaci = new Igrac
                {
                    FindCondition = $"where t.TimId = {tim1.TimId}"
                };
                BindingList<Igrac> domaciIgraci = new BindingList<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, domaci));
                if (domaciIgraci.Count == 0)
                {
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    frmUtakmica.CbIgracDomacina.DataSource = null;
                    return;
                }
                Igrac gosti = new Igrac
                {
                    FindCondition = $"where t.TimId = {tim2.TimId}"
                };
                BindingList<Igrac> gostujuciIgraci = new BindingList<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, gosti));
                if (gostujuciIgraci.Count == 0)
                {
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    frmUtakmica.CbIgracGosta.DataSource = null;
                    return;
                }
                frmUtakmica.CbIgracDomacina.DataSource = domaciIgraci;
                frmUtakmica.CbIgracGosta.DataSource = gostujuciIgraci;
                frmUtakmica.BtnDodajStatistikuDomacin.Enabled = true;
                MessageBox.Show("Sistem je našao igrače po zadatoj vrednosti!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        internal void SacuvajUtakmicu()
        {
            BrojValidator bv = new BrojValidator();
            ValidationResult result = bv.Validate(frmUtakmica.TxtBrojPoenaDomacin);
            if (!result.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + result.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmUtakmica.TxtBrojPoenaDomacin.BackColor = Color.LightCoral;
                return;
            }
            else frmUtakmica.TxtBrojPoenaDomacin.BackColor = Color.White;
            result = bv.Validate(frmUtakmica.TxtBrojPoenaGost);
            if (!result.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + result.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmUtakmica.TxtBrojPoenaGost.BackColor = Color.LightCoral;
                return;
            }
            else frmUtakmica.TxtBrojPoenaGost.BackColor = Color.White;
            result = bv.Validate(frmUtakmica.TxtBrojGledalaca);
            if (!result.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + result.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmUtakmica.TxtBrojGledalaca.BackColor = Color.LightCoral;
                return;
            }
            else frmUtakmica.TxtBrojGledalaca.BackColor = Color.White;
            DatumValidator dv = new DatumValidator();
            ValidationResult res = dv.Validate(frmUtakmica.DtpDatum);
            if (!res.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + res.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmUtakmica.DtpDatum.BackColor = Color.LightCoral;
                return;
            }
            BrojacValidator brojac = new BrojacValidator();
            ValidationResult brojacResult = brojac.Validate(frmUtakmica.NudRunda);
            if (!brojacResult.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + brojacResult.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmUtakmica.NudRunda.BackColor = Color.LightCoral;
                return;
            }
            try
            {
                Utakmica utakmica = new Utakmica
                {
                    BrojPoenaDomacin = Convert.ToInt32(frmUtakmica.TxtBrojPoenaDomacin.Text),
                    BrojPoenaGost = Convert.ToInt32(frmUtakmica.TxtBrojPoenaGost.Text),
                    DateString = frmUtakmica.DtpDatum.Value.ToString(),
                    BrojGledalaca = Convert.ToInt32(frmUtakmica.TxtBrojGledalaca.Text),
                    Runda = (int)frmUtakmica.NudRunda.Value,
                    FazaTakmicenja = faza,
                    Domacin = tim1,
                    Gost = tim2,
                    Statistka = statistike
                };
                UtakmicaValidator uv = new UtakmicaValidator(utakmica.BrojPoenaGost, utakmica.Domacin.Dvorana.Kapacitet);
                ValidationResult utakmicaResult = uv.Validate(utakmica);
                if (!utakmicaResult.IsValid)
                {
                    MessageBox.Show("Sistem ne može da zapamti utakmicu! " + utakmicaResult.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Communication.Instance.SendRequestNoResult(Operation.SacuvajUtakmicu, utakmica);
                MessageBox.Show("Sistem je zapamtio utakmicu!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmUtakmica.Dispose();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        internal void DodajStatistikuGosta()
        {
            BrojValidator bv = new BrojValidator();
            ValidationResult result = bv.Validate(frmUtakmica.TxtPoeniGostIgrac);
            if (!result.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + result.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmUtakmica.TxtPoeniGostIgrac.BackColor = Color.LightCoral;
                return;
            }
            else frmUtakmica.TxtPoeniGostIgrac.BackColor = Color.White;
            bv = new BrojValidator();
            result = bv.Validate(frmUtakmica.TxtSkokoviGostIgrac);
            if (!result.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + result.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmUtakmica.TxtSkokoviGostIgrac.BackColor = Color.LightCoral;
                return;
            }
            else frmUtakmica.TxtSkokoviGostIgrac.BackColor = Color.White;
            bv = new BrojValidator();
            result = bv.Validate(frmUtakmica.TxtAsistencijeGostIgrac);
            if (!result.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + result.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmUtakmica.TxtAsistencijeGostIgrac.BackColor = Color.LightCoral;
                return;
            }
            else frmUtakmica.TxtAsistencijeGostIgrac.BackColor = Color.White;
            try
            {
                Statistika statistika = new Statistika
                {
                    Igrac = (Igrac)frmUtakmica.CbIgracGosta.SelectedItem,
                    Poeni = Convert.ToInt32(frmUtakmica.TxtPoeniGostIgrac.Text),
                    Skokovi = Convert.ToInt32(frmUtakmica.TxtSkokoviGostIgrac.Text),
                    Asistencije = Convert.ToInt32(frmUtakmica.TxtAsistencijeGostIgrac.Text),
                };
                statistike.Add(statistika);
                frmUtakmica.CbIgracGosta.SelectedIndex = frmUtakmica.CbIgracGosta.SelectedIndex + 1;
                OcistiPodatkeIgrac();
            }
            catch (ArgumentOutOfRangeException)
            {
                frmUtakmica.BtnDodajStatistikuGost.Enabled = false;
                frmUtakmica.BtnSacuvajUtakmicu.Enabled = true;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        private void OcistiPodatkeIgrac()
        {
            frmUtakmica.TxtPoeniDomacinIgrac.Text = "";
            frmUtakmica.TxtSkokoviDomacinIgrac.Text = "";
            frmUtakmica.TxtAsistencijeDomacinIgrac.Text = "";
            frmUtakmica.TxtPoeniGostIgrac.Text = "";
            frmUtakmica.TxtSkokoviGostIgrac.Text = "";
            frmUtakmica.TxtAsistencijeGostIgrac.Text = "";
        }

        internal void DodajStatistikuDomacina()
        {
            BrojValidator bv = new BrojValidator();
            ValidationResult result = bv.Validate(frmUtakmica.TxtPoeniDomacinIgrac);
            if (!result.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + result.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmUtakmica.TxtPoeniDomacinIgrac.BackColor = Color.LightCoral;
                return;
            }
            else frmUtakmica.TxtPoeniDomacinIgrac.BackColor = Color.White;
            bv = new BrojValidator();
            result = bv.Validate(frmUtakmica.TxtSkokoviDomacinIgrac);
            if (!result.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + result.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmUtakmica.TxtSkokoviDomacinIgrac.BackColor = Color.LightCoral;
                return;
            }
            else frmUtakmica.TxtSkokoviDomacinIgrac.BackColor = Color.White;
            bv = new BrojValidator();
            result = bv.Validate(frmUtakmica.TxtAsistencijeDomacinIgrac);
            if (!result.IsValid)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! " + result.Errors[0].ErrorMessage, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmUtakmica.TxtAsistencijeDomacinIgrac.BackColor = Color.LightCoral;
                return;
            }
            else frmUtakmica.TxtAsistencijeDomacinIgrac.BackColor = Color.White;
            try
            {
                Statistika statistika = new Statistika
                {
                    Igrac = (Igrac)frmUtakmica.CbIgracDomacina.SelectedItem,
                    Poeni = Convert.ToInt32(frmUtakmica.TxtPoeniDomacinIgrac.Text),
                    Skokovi = Convert.ToInt32(frmUtakmica.TxtSkokoviDomacinIgrac.Text),
                    Asistencije = Convert.ToInt32(frmUtakmica.TxtAsistencijeDomacinIgrac.Text),
                };
                statistike.Add(statistika);
                frmUtakmica.CbIgracDomacina.SelectedIndex = frmUtakmica.CbIgracDomacina.SelectedIndex + 1;
                OcistiPodatkeIgrac();
            }
            catch (ArgumentOutOfRangeException)
            {
                frmUtakmica.BtnDodajStatistikuDomacin.Enabled = false;
                frmUtakmica.BtnDodajStatistikuGost.Enabled = true;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }
    }
}
