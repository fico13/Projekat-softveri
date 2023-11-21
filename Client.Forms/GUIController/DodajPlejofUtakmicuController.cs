using Client.Forms.Dialogs.Utakmica;
using Client.Forms.Exceptions;
using Client.Forms.ServerCommunication;
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
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti");
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
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti");
                    frmUtakmica.CbIgracGosta.DataSource = null;
                    return;
                }
                frmUtakmica.CbIgracDomacina.DataSource = domaciIgraci;
                frmUtakmica.CbIgracGosta.DataSource = gostujuciIgraci;
                frmUtakmica.BtnDodajStatistikuDomacin.Enabled = true;
                MessageBox.Show("Sistem je našao igrače po zadatoj vrednosti");
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti");
                throw;
            }
        }

        internal void SacuvajUtakmicu()
        {
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
                if (utakmica.BrojPoenaDomacin == utakmica.BrojPoenaGost)
                {
                    MessageBox.Show("Sistem ne može da zapamti utakmicu! Broj poena domaćina i gosta ne može biti isti! Pokušajte ponovo!");
                    return;
                }
                
                Communication.Instance.SendRequestNoResult(Operation.SacuvajUtakmicu, utakmica);
                MessageBox.Show("Sistem je zapamtio utakmicu");
                frmUtakmica.Dispose();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu");
                throw;
            }
        }

        internal void DodajStatistikuGosta()
        {
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
            }
            catch (ArgumentOutOfRangeException)
            {
                frmUtakmica.BtnDodajStatistikuGost.Enabled = false;
                frmUtakmica.BtnSacuvajUtakmicu.Enabled = true;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu");
                throw;
            }
        }

        internal void DodajStatistikuDomacina()
        {
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
            }
            catch (ArgumentOutOfRangeException)
            {
                frmUtakmica.BtnDodajStatistikuDomacin.Enabled = false;
                frmUtakmica.BtnDodajStatistikuGost.Enabled = true;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu");
                throw;
            }
        }
    }
}
