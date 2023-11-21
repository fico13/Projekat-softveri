using Client.Forms.Dialogs.Utakmica;
using Client.Forms.Exceptions;
using Client.Forms.GUIHelper;
using Client.Forms.ServerCommunication;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
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
            if (UserControlsHelper.ComboBoxValidation(frmRegularUtakmica.CbDomacin) || UserControlsHelper.ComboBoxValidation(frmRegularUtakmica.CbGost))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Niste lepo odabrali tim u combo box-u! Pokušajte ponovo!");
                return;
            }
            if (frmRegularUtakmica.CbDomacin.SelectedIndex == frmRegularUtakmica.CbGost.SelectedIndex)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Ne mogu isti timovi biti i domaćin i gost! Pokušajte ponovo!");
                return;
            }
            Tim domacin = (Tim)frmRegularUtakmica.CbDomacin.SelectedItem;
            Tim gost = (Tim)frmRegularUtakmica.CbGost.SelectedItem;
            try
            {
                Igrac domaci = new Igrac
                {
                    FindCondition = $"where t.TimId = {domacin.TimId}"
                };
                List<Igrac> domaciIgraci = new List<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, domaci));
                if (domaciIgraci.Count == 0)
                {
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti");
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
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti");
                    frmRegularUtakmica.CbIgracGosta.DataSource = null;
                    return;
                }
                frmRegularUtakmica.CbIgracDomacina.DataSource = domaciIgraci;
                frmRegularUtakmica.CbIgracGosta.DataSource = gostujuciIgraci;
                frmRegularUtakmica.BtnDodajStatistikuDomacin.Enabled = true;
                MessageBox.Show("Sistem je našao igrače po zadatoj vrednosti");
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti");
                throw;
            }
        }

        internal void DodajUtakmicu()
        {
            if (UserControlsHelper.EmptyText(frmRegularUtakmica.TxtBrojPoenaDomacin))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Niste uneli broj poena domaćina! Pokušajte ponovo!");
                return;
            }
            if (UserControlsHelper.EmptyText(frmRegularUtakmica.TxtBrojPoenaGost))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Niste uneli broj poena gosta! Pokušajte ponovo!");
                return;
            }
            if (UserControlsHelper.IntegerValidation(frmRegularUtakmica.TxtBrojPoenaDomacin))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Broj poena domaćina mora da bude prirodan broj! Pokušajte ponovo!");
                return;
            }
            if (UserControlsHelper.IntegerValidation(frmRegularUtakmica.TxtBrojPoenaGost))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Broj poena gosta mora da bude prirodan broj! Pokušajte ponovo!");
                return;
            }
            if (frmRegularUtakmica.DtpDatum.Value >= DateTime.Now)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Datum ne sme biti veći od današnjeg dana! Pokušajte ponovo!");
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
                if (utakmica.BrojPoenaDomacin == utakmica.BrojPoenaGost)
                {
                    MessageBox.Show("Sistem ne može da zapamti utakmicu! Broj poena domaćina i gosta ne može biti isti! Pokušajte ponovo!");
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
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu");
                throw;
            }
        }

       

        internal void DodajStatsitkuGosta()
        {
            if (UserControlsHelper.EmptyText(frmRegularUtakmica.TxtPoeniGostIgrac) || UserControlsHelper.EmptyText(frmRegularUtakmica.TxtSkokoviGostIgrac) || UserControlsHelper.EmptyText(frmRegularUtakmica.TxtAsistencijeGostIgrac))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Niste uneli sve podatke za statistiku gostujućeg igrača! Pokušajte ponovo!");
                return;
            }
            if (UserControlsHelper.ComboBoxValidation(frmRegularUtakmica.CbIgracGosta))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Niste lepo odabrali igrača u combo box-u! Pokušajte ponovo!");
                return;
            }
            if (UserControlsHelper.IntegerValidation(frmRegularUtakmica.TxtPoeniGostIgrac))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Poeni igrača moraju biti prirodan broj! Pokušajte ponovo");
                frmRegularUtakmica.TxtPoeniGostIgrac.Text = "";
                return;
            }
            if (UserControlsHelper.IntegerValidation(frmRegularUtakmica.TxtSkokoviGostIgrac))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Skokovi igrača moraju biti prirodan broj! Pokušajte ponovo");
                frmRegularUtakmica.TxtSkokoviGostIgrac.Text = "";
                return;
            }
            if (UserControlsHelper.IntegerValidation(frmRegularUtakmica.TxtAsistencijeGostIgrac))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Asistencije igrača moraju biti prirodan broj! Pokušajte ponovo");
                frmRegularUtakmica.TxtAsistencijeGostIgrac.Text = "";
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
                MessageBox.Show("Sistem ne može da zapamti utakmicu");
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
            if (UserControlsHelper.EmptyText(frmRegularUtakmica.TxtPoeniDomacinIgrac) || UserControlsHelper.EmptyText(frmRegularUtakmica.TxtSkokoviDomacinIgrac) || UserControlsHelper.EmptyText(frmRegularUtakmica.TxtAsistencijeDomacinIgrac))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Niste uneli sve podatke za statistiku domaćeg igrača! Pokušajte ponovo!");
                return;
            }
            if (UserControlsHelper.ComboBoxValidation(frmRegularUtakmica.CbIgracDomacina))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Niste lepo odabrali igrača u combo box-u! Pokušajte ponovo!");
                return;
            }
            if (UserControlsHelper.IntegerValidation(frmRegularUtakmica.TxtPoeniDomacinIgrac))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Poeni igrača moraju biti prirodan broj! Pokušajte ponovo");
                frmRegularUtakmica.TxtPoeniDomacinIgrac.Text = "";
                return;
            }
            if (UserControlsHelper.IntegerValidation(frmRegularUtakmica.TxtSkokoviDomacinIgrac))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Skokovi igrača moraju biti prirodan broj! Pokušajte ponovo");
                frmRegularUtakmica.TxtSkokoviDomacinIgrac.Text = "";
                return;
            }
            if (UserControlsHelper.IntegerValidation(frmRegularUtakmica.TxtAsistencijeDomacinIgrac))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Asistencije igrača moraju biti prirodan broj! Pokušajte ponovo");
                frmRegularUtakmica.TxtAsistencijeDomacinIgrac.Text = "";
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
                MessageBox.Show("Sistem ne može da zapamti utakmicu");
                throw;
            }
        }
    }
}
