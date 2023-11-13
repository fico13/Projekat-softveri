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
        private List<Statistika> statistike = new List<Statistika>();
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
            }
            catch (ArgumentOutOfRangeException)
            {
                uCRegularniDeo.BtnDodajTim.Enabled = false;
                uCRegularniDeo.TxtBrojKola.Text = (2 * timovi.Count()).ToString();
            }
           

        }

        internal void DodajStatistikuGosta()
        {
            try
            {
                Statistika statistika = new Statistika
                {
                    Igrac = (Igrac)uCRegularniDeo.CbIgracGosta.SelectedItem,
                    Poeni = Convert.ToInt32(uCRegularniDeo.TxtPoeniGostIgrac.Text),
                    Skokovi = Convert.ToInt32(uCRegularniDeo.TxtSkokoviGostIgrac.Text),
                    Asistencije = Convert.ToInt32(uCRegularniDeo.TxtAsistencijeGostIgrac.Text),
                };
                statistike.Add(statistika);
                uCRegularniDeo.CbIgracGosta.SelectedIndex = uCRegularniDeo.CbIgracGosta.SelectedIndex + 1;
            }
            catch (ArgumentOutOfRangeException)
            {
                uCRegularniDeo.BtnDodajStatistikuGost.Enabled = false;
                uCRegularniDeo.BtnSacuvajUtakmicu.Enabled = true;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu");
                throw;
            }
        }

        internal void DodajUtakmicu()
        {
            try
            {
                Utakmica utakmica = new Utakmica
                {
                    BrojPoenaDomacin = Convert.ToInt32(uCRegularniDeo.TxtBrojPoenaDomacin.Text),
                    BrojPoenaGost = Convert.ToInt32(uCRegularniDeo.TxtBrojPoenaGost.Text),
                    DateString = uCRegularniDeo.DtpDatum.Value.ToString(),
                    BrojGledalaca = Convert.ToInt32(uCRegularniDeo.TxtBrojGledalaca.Text),
                    Runda = (int)uCRegularniDeo.NudRunda.Value,
                    FazaTakmicenja = "regular",
                    Domacin = (Tim)uCRegularniDeo.CbDomacin.SelectedItem,
                    Gost = (Tim)uCRegularniDeo.CbGost.SelectedItem,
                    Statistka = statistike
                };
                if (utakmica.BrojPoenaDomacin == utakmica.BrojPoenaGost)
                {
                    MessageBox.Show("Sistem ne može da zapamti utakmicu! Broj poena domaćina i gosta ne može biti isti! Pokušajte ponovo!");
                    return;
                }
                if (utakmica.BrojPoenaDomacin > utakmica.BrojPoenaGost)
                {
                    utakmica.Domacin.BrojPobeda += 1;
                    utakmica.Domacin.Bodovi += 2;
                    utakmica.Domacin.KosRazlika += utakmica.BrojPoenaDomacin - utakmica.BrojPoenaGost;
                    utakmica.Gost.BrojPoraza += 1;
                    utakmica.Gost.Bodovi += 1;
                    utakmica.Gost.KosRazlika -= utakmica.BrojPoenaDomacin - utakmica.BrojPoenaGost;
                }
                if (utakmica.BrojPoenaDomacin < utakmica.BrojPoenaGost)
                {
                    utakmica.Domacin.BrojPoraza += 1;
                    utakmica.Domacin.Bodovi += 1;
                    utakmica.Domacin.KosRazlika -= utakmica.BrojPoenaGost - utakmica.BrojPoenaDomacin;
                    utakmica.Gost.BrojPobeda += 1;
                    utakmica.Gost.Bodovi += 2;
                    utakmica.Gost.KosRazlika += utakmica.BrojPoenaGost - utakmica.BrojPoenaDomacin;
                }
                utakmice.Add(utakmica);
                statistike = new List<Statistika>();
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
                    Igrac = (Igrac)uCRegularniDeo.CbIgracDomacina.SelectedItem,
                    Poeni = Convert.ToInt32(uCRegularniDeo.TxtPoeniDomacinIgrac.Text),
                    Skokovi = Convert.ToInt32(uCRegularniDeo.TxtSkokoviDomacinIgrac.Text),
                    Asistencije = Convert.ToInt32(uCRegularniDeo.TxtAsistencijeDomacinIgrac.Text),
                };
                statistike.Add(statistika);
                uCRegularniDeo.CbIgracDomacina.SelectedIndex = uCRegularniDeo.CbIgracDomacina.SelectedIndex + 1;
            }
            catch (ArgumentOutOfRangeException)
            {
                uCRegularniDeo.BtnDodajStatistikuDomacin.Enabled = false;
                uCRegularniDeo.BtnDodajStatistikuGost.Enabled = true;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu");
                throw;
            }
        }

        internal void UcitajIgrace()
        {
            Tim domacin = (Tim)uCRegularniDeo.CbDomacin.SelectedItem;
            Tim gost = (Tim)uCRegularniDeo.CbGost.SelectedItem;
            try
            {
                Igrac domaci = new Igrac
                {
                    FindCondition = $"where t.TimId = {domacin.TimId}"
                };
                BindingList<Igrac> domaciIgraci = new BindingList<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, domaci));
                if (domaciIgraci.Count == 0)
                {
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti");
                    uCRegularniDeo.CbIgracDomacina.DataSource = null;
                    return;
                }
                Igrac gosti = new Igrac
                {
                    FindCondition = $"where t.TimId = {gost.TimId}"
                };
                BindingList<Igrac> gostujuciIgraci = new BindingList<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, gosti));
                if (gostujuciIgraci.Count == 0)
                {
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti");
                    uCRegularniDeo.CbIgracGosta.DataSource = null;
                    return;
                }
                uCRegularniDeo.CbIgracDomacina.DataSource = domaciIgraci;
                uCRegularniDeo.CbIgracGosta.DataSource = gostujuciIgraci;
                uCRegularniDeo.BtnDodajStatistikuDomacin.Enabled = true;
                MessageBox.Show("Sistem je našao igrače po zadatoj vrednosti");
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti");
                throw;
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
            uCRegularniDeo.TxtBrojKola.Text = (2 * timovi.Count() - 1).ToString();
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
