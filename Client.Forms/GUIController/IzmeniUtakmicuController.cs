﻿using Client.Forms.GUIHelper;
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
                MessageBox.Show("Sistem ne moze da izmeni statistku! Niste uneli sve podatke! Pokusajte ponovo!");
                return;
            }
            if(UserControlsHelper.IntegerValidation(uCIzmenaUtakmice.TxtPoeni))
            {
                MessageBox.Show("Sistem ne moze da izmeni statistku! Poeni moraju da budu prirodan broj! Pokusajte ponovo!");
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCIzmenaUtakmice.TxtSkokovi))
            {
                MessageBox.Show("Sistem ne moze da izmeni statistku! Skokovi moraju da budu prirodan broj! Pokusajte ponovo!");
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCIzmenaUtakmice.TxtAsistencije))
            {
                MessageBox.Show("Sistem ne moze da izmeni statistku! Asistencije moraju da budu prirodan broj! Pokusajte ponovo!");
                return;
            }
            Statistika.Poeni = Convert.ToInt32(uCIzmenaUtakmice.TxtPoeni.Text);
            Statistika.Skokovi = Convert.ToInt32(uCIzmenaUtakmice.TxtSkokovi.Text);
            Statistika.Asistencije = Convert.ToInt32(uCIzmenaUtakmice.TxtAsistencije.Text);
            uCIzmenaUtakmice.BtnIzmeniUtakmicu.Visible = true;
        }

        internal void IzmeniUtakmicu()
        {
            Utakmica.BrojPoenaDomacin = Convert.ToInt32(uCIzmenaUtakmice.TxtPoeniDomacin.Text);
            Utakmica.BrojPoenaGost = Convert.ToInt32(uCIzmenaUtakmice.TxtPoeniGost.Text);
            Utakmica.DateString = uCIzmenaUtakmice.DtpDatum.Value.ToString();
            Communication.Instance.SendRequestNoResult(Operation.IzmeniUtakmicu, Utakmica);
            MessageBox.Show("Sistem je izmenio utakmicu!");
            OcistiPodatke();
            uCIzmenaUtakmice.DgvUtakmice.DataSource = null;
            Init();
        }

        internal void UcitajStatistiku()
        {
            if (uCIzmenaUtakmice.DgvDomaci.SelectedRows.Count == 0 && uCIzmenaUtakmice.DgvGosti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da ucita statistiku igraca! Niste odabrali nijednu statistiku igraca! Pokusajte ponovo!");
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
                MessageBox.Show("Sistem ne moze da ucita utakmicu! Niste odabrali nijednu utakmicu! Pokusajte ponovo!");
                return;
            }
            Utakmica = (Utakmica)uCIzmenaUtakmice.DgvUtakmice.SelectedRows[0].DataBoundItem;
            uCIzmenaUtakmice.GbUtakmica.Visible = true;
            uCIzmenaUtakmice.BtnPrikaziStatistiku.Enabled = true;
            uCIzmenaUtakmice.TxtDomacin.Text = Utakmica.Domacin.ToString();
            uCIzmenaUtakmice.TxtPoeniDomacin.Text = Utakmica.BrojPoenaDomacin.ToString();
            uCIzmenaUtakmice.TxtGost.Text = Utakmica.Gost.ToString();
            uCIzmenaUtakmice.TxtPoeniGost.Text = Utakmica.BrojPoenaGost.ToString();
            uCIzmenaUtakmice.DtpDatum.Text = Utakmica.DatumOdigravanja.ToString();
            uCIzmenaUtakmice.GbPretraga.Visible = false;
        }

        internal void NadjiUtakmice()
        {
            if (UserControlsHelper.ComboBoxValidation(uCIzmenaUtakmice.CbTimovi))
            {
                MessageBox.Show("Sistem ne moze da nadje utakmice po zadatoj vrednosti! Niste lepo odabrali tim iz combobox-a! Pokusajte ponovo!");
            }
            //Tim tim = (Tim)uCPretragaUtakmica.CbTimovi.SelectedItem;
            Utakmica utakmica = new Utakmica
            {
                FindCondition = $"lower(d.ImeTima) like '{uCIzmenaUtakmice.CbTimovi.Text.ToLower()}' or lower(g.ImeTima) like '{uCIzmenaUtakmice.CbTimovi.Text.ToLower()}'"
            };
            BindingList<Utakmica> utakmice = new BindingList<Utakmica>(Communication.Instance.SendRequestGetResult<List<Utakmica>>(Operation.NadjiUtakmice, utakmica));
            if (utakmice.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da nadje utakmice po zadatoj vrednosti!");
                uCIzmenaUtakmice.DgvUtakmice.DataSource = null;
                return;
            }
            uCIzmenaUtakmice.DgvUtakmice.DataSource = utakmice;
            uCIzmenaUtakmice.BtnUcitajUtakmicu.Enabled = true;
            OcistiPodatke();
        }

        private void OcistiPodatke()
        {
            uCIzmenaUtakmice.TxtDomacin.Text = "";
            uCIzmenaUtakmice.TxtPoeniDomacin.Text = "";
            uCIzmenaUtakmice.TxtGost.Text = "";
            uCIzmenaUtakmice.TxtPoeniGost.Text = "";
            uCIzmenaUtakmice.DtpDatum.Text = "";
            uCIzmenaUtakmice.TxtIgrac.Text = "";
            uCIzmenaUtakmice.TxtPoeni.Text = "";
            uCIzmenaUtakmice.TxtSkokovi.Text = "";
            uCIzmenaUtakmice.TxtAsistencije.Text = "";
            uCIzmenaUtakmice.LblDomacin.Text = "";
            uCIzmenaUtakmice.LblGost.Text = "";
        }
    }
}