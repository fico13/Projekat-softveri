﻿using Client.Forms.Exceptions;
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
    public class IzmeniUtakmicuController
    {
        private UCIzmenaUtakmice uCIzmenaUtakmice;
        public Utakmica Utakmica { get; set; }
        public Statistika Statistika{ get; set; }

        public IzmeniUtakmicuController(UCIzmenaUtakmice uCIzmenaUtakmice)
        {
            this.uCIzmenaUtakmice = uCIzmenaUtakmice;
        }

        internal void Init()
        {
            uCIzmenaUtakmice.CbTimovi.DataSource = Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.VratiSveTimove);
            uCIzmenaUtakmice.GbPretraga.Visible = true;
            uCIzmenaUtakmice.BtnUcitajUtakmicu.Enabled = false;
            uCIzmenaUtakmice.BtnPrikaziStatistiku.Enabled = false;
            uCIzmenaUtakmice.BtnUcitajStatistiku.Visible = false;
            uCIzmenaUtakmice.BtnIzmeniStatistiku.Enabled = false;
            uCIzmenaUtakmice.DgvDomaci.Visible = false;
            uCIzmenaUtakmice.DgvGosti.Visible = false;
            uCIzmenaUtakmice.GbStatistikaIgraca.Visible = false;
            uCIzmenaUtakmice.BtnIzmeniUtakmicu.Visible = false;
            uCIzmenaUtakmice.GbUtakmica.Visible = false;
        }

        internal void IzmeniStatistiku()
        {
            if(UserControlsHelper.EmptyText(uCIzmenaUtakmice.TxtPoeni) || UserControlsHelper.EmptyText(uCIzmenaUtakmice.TxtSkokovi) || UserControlsHelper.EmptyText(uCIzmenaUtakmice.TxtAsistencije))
            {
                MessageBox.Show("Sistem ne može da izmeni statistku! Niste uneli sve podatke! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(UserControlsHelper.IntegerValidation(uCIzmenaUtakmice.TxtPoeni))
            {
                MessageBox.Show("Sistem ne može da izmeni statistku! Poeni moraju da budu prirodan broj! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCIzmenaUtakmice.TxtSkokovi))
            {
                MessageBox.Show("Sistem ne može da izmeni statistku! Skokovi moraju da budu prirodan broj! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCIzmenaUtakmice.TxtAsistencije))
            {
                MessageBox.Show("Sistem ne može da izmeni statistku! Asistencije moraju da budu prirodan broj! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Statistika.Poeni = Convert.ToInt32(uCIzmenaUtakmice.TxtPoeni.Text);
            Statistika.Skokovi = Convert.ToInt32(uCIzmenaUtakmice.TxtSkokovi.Text);
            Statistika.Asistencije = Convert.ToInt32(uCIzmenaUtakmice.TxtAsistencije.Text);
            uCIzmenaUtakmice.BtnIzmeniUtakmicu.Visible = true;
        }

        internal void IzmeniUtakmicu()
        {
            try
            {
                Utakmica.BrojPoenaDomacin = Convert.ToInt32(uCIzmenaUtakmice.TxtPoeniDomacin.Text);
                Utakmica.BrojPoenaGost = Convert.ToInt32(uCIzmenaUtakmice.TxtPoeniGost.Text);
                Utakmica.DateString = uCIzmenaUtakmice.DtpDatum.Value.ToString();
                Utakmica.Runda = Convert.ToInt32(uCIzmenaUtakmice.TxtRunda.Text);
                Utakmica.BrojGledalaca = Convert.ToInt32(uCIzmenaUtakmice.TxtBrojGledalaca.Text);
                if (Utakmica.BrojPoenaDomacin  == Utakmica.BrojPoenaGost)
                {
                    MessageBox.Show("Sistem ne može da izmeni utakmicu! Broj poena domaćina i gosta ne može biti isti! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if(Utakmica.BrojPoenaDomacin > Utakmica.BrojPoenaGost)
                {
                    Utakmica.Domacin.BrojPobeda += 1;
                    Utakmica.Domacin.Bodovi += 2;
                    Utakmica.Domacin.KosRazlika += Utakmica.BrojPoenaDomacin - Utakmica.BrojPoenaGost;
                    Utakmica.Gost.BrojPoraza += 1;
                    Utakmica.Gost.Bodovi += 1;
                    Utakmica.Gost.KosRazlika -= Utakmica.BrojPoenaDomacin - Utakmica.BrojPoenaGost;
                }
                else
                {
                    Utakmica.Domacin.BrojPoraza += 1;
                    Utakmica.Domacin.Bodovi += 1;
                    Utakmica.Domacin.KosRazlika -= Utakmica.BrojPoenaGost - Utakmica.BrojPoenaDomacin;
                    Utakmica.Gost.BrojPobeda += 1;
                    Utakmica.Gost.Bodovi += 2;
                    Utakmica.Gost.KosRazlika += Utakmica.BrojPoenaGost - Utakmica.BrojPoenaDomacin;
                }
                Communication.Instance.SendRequestNoResult(Operation.IzmeniUtakmicu, Utakmica);
                MessageBox.Show("Sistem je izmenio utakmicu", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcistiPodatke();
                uCIzmenaUtakmice.DgvUtakmice.DataSource = null;
                Init();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da izmeni utakmicu", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        internal void UcitajStatistiku()
        {
            if (uCIzmenaUtakmice.DgvDomaci.SelectedRows.Count == 0 && uCIzmenaUtakmice.DgvGosti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sistem ne može da učita statistiku igrača! Niste odabrali nijednu statistiku igrača! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(uCIzmenaUtakmice.DgvDomaci.SelectedRows.Count > 0)
            {
                Statistika = (Statistika)uCIzmenaUtakmice.DgvDomaci.SelectedRows[0].DataBoundItem;
                uCIzmenaUtakmice.TxtIgrac.Text = Statistika.Igrac.ToString();
                uCIzmenaUtakmice.TxtPoeni.Text = Statistika.Poeni.ToString();
                uCIzmenaUtakmice.TxtSkokovi.Text = Statistika.Skokovi.ToString();
                uCIzmenaUtakmice.TxtAsistencije.Text = Statistika.Asistencije.ToString();
                uCIzmenaUtakmice.BtnIzmeniStatistiku.Enabled = true;
            }
            if (uCIzmenaUtakmice.DgvGosti.SelectedRows.Count > 0)
            {
                Statistika = (Statistika)uCIzmenaUtakmice.DgvGosti.SelectedRows[0].DataBoundItem;
                uCIzmenaUtakmice.TxtIgrac.Text = Statistika.Igrac.ToString();
                uCIzmenaUtakmice.TxtPoeni.Text = Statistika.Poeni.ToString();
                uCIzmenaUtakmice.TxtSkokovi.Text = Statistika.Skokovi.ToString();
                uCIzmenaUtakmice.TxtAsistencije.Text = Statistika.Asistencije.ToString();
                uCIzmenaUtakmice.BtnIzmeniStatistiku.Enabled = true;
            }

        }

        internal void PrikaziStatistiku()
        {
            List<Statistika> statistikaDomacin = new List<Statistika>();
            List<Statistika> statistikaGost = new List<Statistika>();
            foreach (var statistika in Utakmica.Statistka)
            {
                statistika.Utakmica = Utakmica;
                if (statistika.Igrac.Tim.TimId == Utakmica.Domacin.TimId)
                {
                    statistikaDomacin.Add(statistika);
                }

                if (statistika.Igrac.Tim.TimId == Utakmica.Gost.TimId)
                {
                    statistikaGost.Add(statistika);
                }
            }
            uCIzmenaUtakmice.DgvDomaci.Visible = true;
            uCIzmenaUtakmice.DgvGosti.Visible = true;
            uCIzmenaUtakmice.LblDomacin.Text = Utakmica.Domacin.ToString();
            uCIzmenaUtakmice.LblGost.Text = Utakmica.Gost.ToString();
            uCIzmenaUtakmice.DgvDomaci.DataSource = statistikaDomacin;
            uCIzmenaUtakmice.DgvGosti.DataSource = statistikaGost;
            uCIzmenaUtakmice.GbStatistikaIgraca.Visible = true;
            uCIzmenaUtakmice.BtnUcitajStatistiku.Visible = true;
            statistikaDomacin = new List<Statistika>();
            statistikaGost = new List<Statistika>();
        }

        internal void UcitajUtakmicu()
        {
            if (uCIzmenaUtakmice.DgvUtakmice.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sistem ne može da učita utakmicu! Niste odabrali nijednu utakmicu! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Utakmica utakmica = (Utakmica)uCIzmenaUtakmice.DgvUtakmice.SelectedRows[0].DataBoundItem;
                utakmica.FindCondition = $"where UtakmicaId = {utakmica.UtakmicaId}";
                Utakmica = Communication.Instance.SendRequestGetResult<Utakmica>(Operation.UcitajUtakmicu, utakmica);
                uCIzmenaUtakmice.GbUtakmica.Visible = true;
                uCIzmenaUtakmice.BtnPrikaziStatistiku.Enabled = true;
                uCIzmenaUtakmice.TxtDomacin.Text = Utakmica.Domacin.ToString();
                uCIzmenaUtakmice.TxtPoeniDomacin.Text = Utakmica.BrojPoenaDomacin.ToString();
                uCIzmenaUtakmice.TxtGost.Text = Utakmica.Gost.ToString();
                uCIzmenaUtakmice.TxtPoeniGost.Text = Utakmica.BrojPoenaGost.ToString();
                uCIzmenaUtakmice.DtpDatum.Text = Utakmica.DatumOdigravanja.ToString();
                uCIzmenaUtakmice.TxtBrojGledalaca.Text = Utakmica.BrojGledalaca.ToString();
                uCIzmenaUtakmice.TxtRunda.Text = Utakmica.Runda.ToString();
                uCIzmenaUtakmice.GbPretraga.Visible = false;
                if(Utakmica.BrojPoenaDomacin > Utakmica.BrojPoenaGost)
                {
                    Utakmica.Domacin.BrojPobeda -= 1;
                    Utakmica.Domacin.Bodovi -= 2;
                    Utakmica.Domacin.KosRazlika -= Utakmica.BrojPoenaDomacin - Utakmica.BrojPoenaGost;
                    Utakmica.Gost.BrojPoraza -= 1;
                    Utakmica.Gost.Bodovi -= 1;
                    Utakmica.Gost.KosRazlika += Utakmica.BrojPoenaDomacin - Utakmica.BrojPoenaGost;
                }
                else
                {
                    Utakmica.Domacin.BrojPoraza -= 1;
                    Utakmica.Domacin.Bodovi -= 1;
                    Utakmica.Domacin.KosRazlika += Utakmica.BrojPoenaGost - Utakmica.BrojPoenaDomacin;
                    Utakmica.Gost.BrojPobeda -= 1;
                    Utakmica.Gost.Bodovi -= 2;
                    Utakmica.Gost.KosRazlika -= Utakmica.BrojPoenaGost - Utakmica.BrojPoenaDomacin;
                }
                MessageBox.Show("Sistem je učitao utakmicu", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da učita utakmicu", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        internal void NadjiUtakmice()
        {
            if (UserControlsHelper.ComboBoxValidation(uCIzmenaUtakmice.CbTimovi))
            {
                MessageBox.Show("Sistem ne može da nađe utakmice po zadatoj vrednosti! Niste lepo odabrali tim iz combobox-a! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Utakmica utakmica = new Utakmica
            {
                FindCondition = $"where lower(d.ImeTima) like '{uCIzmenaUtakmice.CbTimovi.Text.ToLower()}' or lower(g.ImeTima) like '{uCIzmenaUtakmice.CbTimovi.Text.ToLower()}' order by DatumOdigravanja asc"
            };
            try
            {
                BindingList<Utakmica> utakmice = new BindingList<Utakmica>(Communication.Instance.SendRequestGetResult<List<Utakmica>>(Operation.NadjiUtakmice, utakmica));
                if (utakmice.Count == 0)
                {
                    MessageBox.Show("Sistem ne može da nađe utakmice po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    uCIzmenaUtakmice.DgvUtakmice.DataSource = null;
                    return;
                }
                uCIzmenaUtakmice.DgvUtakmice.DataSource = utakmice;
                MessageBox.Show("Sistem je našao utakmice po zadatoj vrednosti!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                uCIzmenaUtakmice.BtnUcitajUtakmicu.Enabled = true;
                OcistiPodatke();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da nađe utakmice po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        private void OcistiPodatke()
        {
            uCIzmenaUtakmice.TxtDomacin.Text = "";
            uCIzmenaUtakmice.TxtPoeniDomacin.Text = "";
            uCIzmenaUtakmice.TxtGost.Text = "";
            uCIzmenaUtakmice.TxtPoeniGost.Text = "";
            uCIzmenaUtakmice.DtpDatum.Text = "";
            uCIzmenaUtakmice.TxtBrojGledalaca.Text = "";
            uCIzmenaUtakmice.TxtIgrac.Text = "";
            uCIzmenaUtakmice.TxtPoeni.Text = "";
            uCIzmenaUtakmice.TxtSkokovi.Text = "";
            uCIzmenaUtakmice.TxtAsistencije.Text = "";
            uCIzmenaUtakmice.LblDomacin.Text = "";
            uCIzmenaUtakmice.LblGost.Text = "";
        }
    }
}
