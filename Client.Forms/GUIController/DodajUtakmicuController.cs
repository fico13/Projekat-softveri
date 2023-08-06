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
        }

        internal void DodajStatistikuDomacina()
        {
            if (UserControlsHelper.EmptyText(uCDodajUtakmicu.TxtPoeniDomacinIgrac) || UserControlsHelper.EmptyText(uCDodajUtakmicu.TxtSkokoviDomacinIgrac) || UserControlsHelper.EmptyText(uCDodajUtakmicu.TxtAsistencijeDomacinIgrac))
            {
                MessageBox.Show("Sistem ne moze da zapamti utakmicu! Niste uneli sve podatke za statistiku domaceg igraca! Pokusajte ponovo!");
                return;
            }
            if(UserControlsHelper.IntegerValidation(uCDodajUtakmicu.TxtPoeniDomacinIgrac))
            {
                MessageBox.Show("Sistem ne moze da zapamti utakmicu! Poeni igraca moraju biti prirodan broj! Pokusajte ponovo");
                uCDodajUtakmicu.TxtPoeniDomacinIgrac.Text = "";
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCDodajUtakmicu.TxtSkokoviDomacinIgrac))
            {
                MessageBox.Show("Sistem ne moze da zapamti utakmicu! Skokovi igraca moraju biti prirodan broj! Pokusajte ponovo");
                uCDodajUtakmicu.TxtSkokoviDomacinIgrac.Text = "";
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCDodajUtakmicu.TxtAsistencijeDomacinIgrac))
            {
                MessageBox.Show("Sistem ne moze da zapamti utakmicu! Asistencije igraca moraju biti prirodan broj! Pokusajte ponovo");
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
            catch (Exception)
            {

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
                MessageBox.Show("Sistem ne moze da zapamti utakmicu! Niste uneli broj poena domacina! Pokusajte ponovo!");
                return;
            }
            if (UserControlsHelper.EmptyText(uCDodajUtakmicu.TxtBrojPoenaGost))
            {
                MessageBox.Show("Sistem ne moze da zapamti utakmicu! Niste uneli broj poena gosta! Pokusajte ponovo!");
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCDodajUtakmicu.TxtBrojPoenaDomacin))
            {
                MessageBox.Show("Sistem ne moze da zapamti utakmicu! Broj poena domacina mora da bude prirodan broj! Pokusajte ponovo!");
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCDodajUtakmicu.TxtBrojPoenaGost))
            {
                MessageBox.Show("Sistem ne moze da zapamti utakmicu! Broj poena domacina mora da bude prirodan broj! Pokusajte ponovo!");
                return;
            }
            if(uCDodajUtakmicu.DtpDatum.Value >= DateTime.Now)
            {
                MessageBox.Show("Sistem ne moze da zapamti utakmicu! Datum ne sme biti veci od danasnjeg dana! Pokusajte ponovo!");
                return;
            }
            try
            {
                Utakmica utakmica = new Utakmica
                {
                    BrojPoenaDomacin = Convert.ToInt32(uCDodajUtakmicu.TxtBrojPoenaDomacin.Text),
                    BrojPoenaGost = Convert.ToInt32(uCDodajUtakmicu.TxtBrojPoenaGost.Text),
                    DateString = uCDodajUtakmicu.DtpDatum.Value.ToString(),
                    Domacin = (Tim)uCDodajUtakmicu.CbDomacin.SelectedItem,
                    Gost = (Tim)uCDodajUtakmicu.CbGost.SelectedItem,
                    Statistka = statistike
                };
                if(utakmica.BrojPoenaDomacin == utakmica.BrojPoenaGost)
                {
                    MessageBox.Show("Sistem ne moze da zapamti utakmicu! Broj poena domacina i gosta ne moze biti isti! Pokusajte ponovo!");
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
                Communication.Instance.SendRequestNoResult(Operation.SacuvajUtakmicu, utakmica);
                MessageBox.Show("Sistem je zapamtio utakmicu!");
                OcistiPodatke();
                uCDodajUtakmicu.CbDomacin.DataSource = Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.VratiSveTimove);
                uCDodajUtakmicu.CbGost.DataSource = Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.VratiSveTimove);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void OcistiPodatke()
        {
            uCDodajUtakmicu.TxtBrojPoenaDomacin.Text = "";
            uCDodajUtakmicu.TxtBrojPoenaGost.Text = "";
            uCDodajUtakmicu.DtpDatum.Value = DateTime.Now;
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
                MessageBox.Show("Sistem ne moze da zapamti utakmicu! Niste uneli sve podatke za statistiku gostujuceg igraca! Pokusajte ponovo!");
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCDodajUtakmicu.TxtPoeniGostIgrac))
            {
                MessageBox.Show("Sistem ne moze da zapamti utakmicu! Poeni igraca moraju biti prirodan broj! Pokusajte ponovo");
                uCDodajUtakmicu.TxtPoeniGostIgrac.Text = "";
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCDodajUtakmicu.TxtSkokoviGostIgrac))
            {
                MessageBox.Show("Sistem ne moze da zapamti utakmicu! Skokovi igraca moraju biti prirodan broj! Pokusajte ponovo");
                uCDodajUtakmicu.TxtSkokoviGostIgrac.Text = "";
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCDodajUtakmicu.TxtAsistencijeGostIgrac))
            {
                MessageBox.Show("Sistem ne moze da zapamti utakmicu! Asistencije igraca moraju biti prirodan broj! Pokusajte ponovo");
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
            catch (Exception)
            {

                throw;
            }
        }

        internal void UcitajIgrace()
        {
            if(UserControlsHelper.ComboBoxValidation(uCDodajUtakmicu.CbDomacin) || UserControlsHelper.ComboBoxValidation(uCDodajUtakmicu.CbDomacin))
            {
                MessageBox.Show("Sistem ne moze da zapamti utakmicu! Niste lepo odabrali tim u combo box-u! Pokusajte ponovo!");
                return;
            }
            if(uCDodajUtakmicu.CbDomacin.SelectedIndex == uCDodajUtakmicu.CbGost.SelectedIndex)
            {
                MessageBox.Show("Sistem ne moze da zapamti utakmicu! Ne mogu isti timovi biti i domacin i gost! Pokusajte ponovo!");
                return;
            }
            Tim domacin = (Tim)uCDodajUtakmicu.CbDomacin.SelectedItem;
            Tim gost = (Tim)uCDodajUtakmicu.CbGost.SelectedItem;
            try
            {
                Igrac domaci = new Igrac
                {
                    FindCondition = $"t.TimId = {domacin.TimId}",
                    Tim = domacin
                };
                BindingList<Igrac> domaciIgraci = new BindingList<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, domaci));
                if (domaciIgraci.Count == 0)
                {
                    MessageBox.Show("Sistem ne moze da nadje igrace po zadatoj vrednosti!");
                    uCDodajUtakmicu.CbIgracDomacina.DataSource = null;
                    return;
                }
                uCDodajUtakmicu.CbIgracDomacina.DataSource = domaciIgraci;
                Igrac gosti = new Igrac
                {
                    FindCondition = $"t.TimId = {gost.TimId}"
                };
                BindingList<Igrac> gostujuciIgraci = new BindingList<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, gosti));
                if (gostujuciIgraci.Count == 0)
                {
                    MessageBox.Show("Sistem ne moze da nadje igrace po zadatoj vrednosti!");
                    uCDodajUtakmicu.CbIgracGosta.DataSource = null;
                    return;
                }
                uCDodajUtakmicu.CbIgracGosta.DataSource = gostujuciIgraci;
                uCDodajUtakmicu.BtnDodajStatistikuDomacin.Enabled = true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da nadje igrace po zadatoj vrednosti!" + ex.Message);
            }

        }
    }
}