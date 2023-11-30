using Client.Forms.Exceptions;
using Client.Forms.GUIHelper;
using Client.Forms.ServerCommunication;
using Client.Forms.UserControls.Utakmica;
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
    public class DodajUtakmicuController
    {
        private UCDodajUtakmicu uCDodajUtakmicu;
        private List<Statistika> statistike = new List<Statistika>();

        public DodajUtakmicuController(UCDodajUtakmicu uCDodajUtakmicu)
        {
            this.uCDodajUtakmicu = uCDodajUtakmicu;
        }

        internal void Init()
        {
            uCDodajUtakmicu.CbDomacin.DataSource = Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.VratiSveTimove);
            uCDodajUtakmicu.CbGost.DataSource = Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.VratiSveTimove);
            uCDodajUtakmicu.BtnSacuvajUtakmicu.Enabled = false;
            uCDodajUtakmicu.BtnDodajStatistikuDomacin.Enabled = false;
            uCDodajUtakmicu.BtnDodajStatistikuGost.Enabled = false;
            List<Utakmica> utakmice = Communication.Instance.SendRequestGetResult<List<Utakmica>>(Operation.NadjiUtakmice, new Utakmica());
            if(utakmice.Count == 34*9)
            {
                MessageBox.Show("Regularni deo je završen", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                uCDodajUtakmicu.Enabled = false;
            }
        }

        internal void DodajStatistikuDomacina()
        {
            if (UserControlsHelper.EmptyText(uCDodajUtakmicu.TxtPoeniDomacinIgrac) || UserControlsHelper.EmptyText(uCDodajUtakmicu.TxtSkokoviDomacinIgrac) || UserControlsHelper.EmptyText(uCDodajUtakmicu.TxtAsistencijeDomacinIgrac))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Niste uneli sve podatke za statistiku domaćeg igrača! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserControlsHelper.ComboBoxValidation(uCDodajUtakmicu.CbIgracDomacina))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Niste lepo odabrali igrača u combo box-u! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCDodajUtakmicu.TxtPoeniDomacinIgrac))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Poeni igrača moraju biti prirodan broj! Pokušajte ponovo", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                uCDodajUtakmicu.TxtPoeniDomacinIgrac.Text = "";
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCDodajUtakmicu.TxtSkokoviDomacinIgrac))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Skokovi igrača moraju biti prirodan broj! Pokušajte ponovo", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                uCDodajUtakmicu.TxtSkokoviDomacinIgrac.Text = "";
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCDodajUtakmicu.TxtAsistencijeDomacinIgrac))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Asistencije igrača moraju biti prirodan broj! Pokušajte ponovo", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                uCDodajUtakmicu.TxtAsistencijeDomacinIgrac.Text = "";
                return;
            }
            try
            {
                Statistika statistika = new Statistika
                {
                    Igrac = (Igrac)uCDodajUtakmicu.CbIgracDomacina.SelectedItem,
                    Poeni = Convert.ToInt32(uCDodajUtakmicu.TxtPoeniDomacinIgrac.Text),
                    Skokovi = Convert.ToInt32(uCDodajUtakmicu.TxtSkokoviDomacinIgrac.Text),
                    Asistencije = Convert.ToInt32(uCDodajUtakmicu.TxtAsistencijeDomacinIgrac.Text),
                };
                statistike.Add(statistika);
                OcistiPodatkeIgrac();
                uCDodajUtakmicu.CbIgracDomacina.SelectedIndex = uCDodajUtakmicu.CbIgracDomacina.SelectedIndex + 1;
            }
            catch(ArgumentOutOfRangeException)
            {
                uCDodajUtakmicu.BtnDodajStatistikuDomacin.Enabled = false;
                uCDodajUtakmicu.BtnDodajStatistikuGost.Enabled = true;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
           
        }

        private void OcistiPodatkeIgrac()
        {
            uCDodajUtakmicu.TxtPoeniDomacinIgrac.Text = "";
            uCDodajUtakmicu.TxtSkokoviDomacinIgrac.Text = "";
            uCDodajUtakmicu.TxtAsistencijeDomacinIgrac.Text = "";
            uCDodajUtakmicu.TxtPoeniGostIgrac.Text = "";
            uCDodajUtakmicu.TxtSkokoviGostIgrac.Text = "";
            uCDodajUtakmicu.TxtAsistencijeGostIgrac.Text = "";
        }

        internal void SacuvajUtakmicu()
        {
            if (UserControlsHelper.EmptyText(uCDodajUtakmicu.TxtBrojPoenaDomacin))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Niste uneli broj poena domaćina! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserControlsHelper.EmptyText(uCDodajUtakmicu.TxtBrojPoenaGost))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Niste uneli broj poena gosta! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCDodajUtakmicu.TxtBrojPoenaDomacin))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Broj poena domaćina mora da bude prirodan broj! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCDodajUtakmicu.TxtBrojPoenaGost))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Broj poena gosta mora da bude prirodan broj! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(uCDodajUtakmicu.DtpDatum.Value >= DateTime.Now)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Datum ne sme biti veći od današnjeg dana! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Utakmica utakmica = new Utakmica
                {
                    BrojPoenaDomacin = Convert.ToInt32(uCDodajUtakmicu.TxtBrojPoenaDomacin.Text),
                    BrojPoenaGost = Convert.ToInt32(uCDodajUtakmicu.TxtBrojPoenaGost.Text),
                    DateString = uCDodajUtakmicu.DtpDatum.Value.ToString(),
                    BrojGledalaca = Convert.ToInt32(uCDodajUtakmicu.TxtBrojGledalaca.Text),
                    Runda = Convert.ToInt32(uCDodajUtakmicu.NudRunda.Value),
                    FazaTakmicenja = "regularni deo",
                    Domacin = (Tim)uCDodajUtakmicu.CbDomacin.SelectedItem,
                    Gost = (Tim)uCDodajUtakmicu.CbGost.SelectedItem,
                    Statistka = statistike
                };
                if(utakmica.BrojPoenaDomacin == utakmica.BrojPoenaGost)
                {
                    MessageBox.Show("Sistem ne može da zapamti utakmicu! Broj poena domaćina i gosta ne može biti isti! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(utakmica.BrojPoenaDomacin > utakmica.BrojPoenaGost)
                {
                    utakmica.Domacin.BrojPobeda += 1;
                    utakmica.Domacin.Bodovi += 2;
                    utakmica.Gost.BrojPoraza += 1;
                    utakmica.Gost.Bodovi += 1;
                }
                if(utakmica.BrojPoenaDomacin < utakmica.BrojPoenaGost)
                {
                    utakmica.Domacin.BrojPoraza += 1;
                    utakmica.Domacin.Bodovi += 1;
                    utakmica.Gost.BrojPobeda += 1;
                    utakmica.Gost.Bodovi += 2;
                }
                Utakmica utakmica2 = new Utakmica
                {
                    FindCondition = $"where u.Runda = {utakmica.Runda}"
                };
                List<Utakmica> utakmice = Communication.Instance.SendRequestGetResult<List<Utakmica>>(Operation.NadjiUtakmice, utakmica2);
                if(utakmice.Count == 9)
                {
                    MessageBox.Show("Sistem ne može da zapamti utakmicu! Sve utakmice u ovoj rundi su već dodate!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Utakmica utakmica3 = new Utakmica
                {
                    FindCondition = $"where u.DomacinId = {utakmica.Domacin.TimId} and u.GostId = {utakmica.Gost.TimId}"
                };
                List<Utakmica> utakmice2 = Communication.Instance.SendRequestGetResult<List<Utakmica>>(Operation.NadjiUtakmice, utakmica3);
                if (utakmice2.Count != 0)
                {
                    MessageBox.Show("Sistem ne može da zapamti utakmicu! Utakmica za ove timove je već dodata!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Communication.Instance.SendRequestNoResult(Operation.SacuvajUtakmicu, utakmica);
                MessageBox.Show("Sistem je zapamtio utakmicu!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcistiPodatke();
                uCDodajUtakmicu.CbDomacin.DataSource = Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.VratiSveTimove);
                uCDodajUtakmicu.CbGost.DataSource = Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.VratiSveTimove);
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        private void OcistiPodatke()
        {
            uCDodajUtakmicu.TxtBrojPoenaDomacin.Text = "";
            uCDodajUtakmicu.TxtBrojPoenaGost.Text = "";
            uCDodajUtakmicu.DtpDatum.Value = DateTime.Now;
            uCDodajUtakmicu.NudRunda.Value = 1;
            uCDodajUtakmicu.TxtBrojGledalaca.Text = "";
            uCDodajUtakmicu.TxtPoeniDomacinIgrac.Text = "";
            uCDodajUtakmicu.TxtSkokoviDomacinIgrac.Text = "";
            uCDodajUtakmicu.TxtAsistencijeDomacinIgrac.Text = "";
            uCDodajUtakmicu.TxtPoeniGostIgrac.Text = "";
            uCDodajUtakmicu.TxtSkokoviGostIgrac.Text = "";
            uCDodajUtakmicu.TxtAsistencijeDomacinIgrac.Text = "";
            uCDodajUtakmicu.CbDomacin.DataSource = null;
            uCDodajUtakmicu.CbGost.DataSource = null;
            uCDodajUtakmicu.BtnSacuvajUtakmicu.Enabled = false;
            statistike = new List<Statistika>();
        }

        internal void DodajStatistikuGosta()
        {
            if (UserControlsHelper.EmptyText(uCDodajUtakmicu.TxtPoeniGostIgrac) || UserControlsHelper.EmptyText(uCDodajUtakmicu.TxtSkokoviGostIgrac) || UserControlsHelper.EmptyText(uCDodajUtakmicu.TxtAsistencijeGostIgrac))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Niste uneli sve podatke za statistiku gostujućeg igrača! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserControlsHelper.ComboBoxValidation(uCDodajUtakmicu.CbIgracGosta))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Niste lepo odabrali igrača u combo box-u! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCDodajUtakmicu.TxtPoeniGostIgrac))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Poeni igrača moraju biti prirodan broj! Pokušajte ponovo", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                uCDodajUtakmicu.TxtPoeniGostIgrac.Text = "";
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCDodajUtakmicu.TxtSkokoviGostIgrac))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Skokovi igrača moraju biti prirodan broj! Pokušajte ponovo", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                uCDodajUtakmicu.TxtSkokoviGostIgrac.Text = "";
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCDodajUtakmicu.TxtAsistencijeGostIgrac))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Asistencije igrača moraju biti prirodan broj! Pokušajte ponovo", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                uCDodajUtakmicu.TxtAsistencijeGostIgrac.Text = "";
                return;
            }
            try
            {
                Statistika statistika = new Statistika
                {
                    Igrac = (Igrac)uCDodajUtakmicu.CbIgracGosta.SelectedItem,
                    Poeni = Convert.ToInt32(uCDodajUtakmicu.TxtPoeniGostIgrac.Text),
                    Skokovi = Convert.ToInt32(uCDodajUtakmicu.TxtSkokoviGostIgrac.Text),
                    Asistencije = Convert.ToInt32(uCDodajUtakmicu.TxtAsistencijeGostIgrac.Text),
                };
                statistike.Add(statistika);
                OcistiPodatkeIgrac();
                uCDodajUtakmicu.CbIgracGosta.SelectedIndex = uCDodajUtakmicu.CbIgracGosta.SelectedIndex + 1;
            }
            catch(ArgumentOutOfRangeException)
            {
                uCDodajUtakmicu.BtnDodajStatistikuGost.Enabled = false;
                uCDodajUtakmicu.BtnSacuvajUtakmicu.Enabled = true;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        internal void UcitajIgrace()
        {
            if(UserControlsHelper.ComboBoxValidation(uCDodajUtakmicu.CbDomacin) || UserControlsHelper.ComboBoxValidation(uCDodajUtakmicu.CbGost))
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Niste lepo odabrali tim u combo box-u! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(uCDodajUtakmicu.CbDomacin.SelectedIndex == uCDodajUtakmicu.CbGost.SelectedIndex)
            {
                MessageBox.Show("Sistem ne može da zapamti utakmicu! Ne mogu isti timovi biti i domaćin i gost! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Tim domacin = (Tim)uCDodajUtakmicu.CbDomacin.SelectedItem;
            Tim gost = (Tim)uCDodajUtakmicu.CbGost.SelectedItem;
            try
            {
                Igrac domaci = new Igrac
                {
                    FindCondition = $"where t.TimId = {domacin.TimId}"
                };
                BindingList<Igrac> domaciIgraci = new BindingList<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, domaci));
                if (domaciIgraci.Count == 0)
                {
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    uCDodajUtakmicu.CbIgracDomacina.DataSource = null;
                    return;
                }
                Igrac gosti = new Igrac
                {
                    FindCondition = $"where t.TimId = {gost.TimId}"
                };
                BindingList<Igrac> gostujuciIgraci = new BindingList<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, gosti));
                if (gostujuciIgraci.Count == 0)
                {
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!");
                    uCDodajUtakmicu.CbIgracGosta.DataSource = null;
                    return;
                }
                uCDodajUtakmicu.CbIgracDomacina.DataSource = domaciIgraci;
                uCDodajUtakmicu.CbIgracGosta.DataSource = gostujuciIgraci;
                uCDodajUtakmicu.BtnDodajStatistikuDomacin.Enabled = true;
                MessageBox.Show("Sistem je našao igrače po zadatoj vrednosti!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }

        }
    }
}
