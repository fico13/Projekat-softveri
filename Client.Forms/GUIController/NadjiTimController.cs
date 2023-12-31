﻿using Client.Forms.Exceptions;
using Client.Forms.GUIHelper;
using Client.Forms.ServerCommunication;
using Client.Forms.UserControls.Tim;
using Common.Communication;
using Common.Domain;
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
    public class NadjiTimController
    {
        private UCNadjiTim uCNadjiTim;

        public NadjiTimController(UCNadjiTim uCNadjiTim)
        {
            this.uCNadjiTim = uCNadjiTim;
        }

        internal void NadjiTim()
        {
            OcistiPodatke();
            uCNadjiTim.DgvTimovi.DataSource = null;
            if(UserControlsHelper.EmptyText(uCNadjiTim.TxtNaziv) && UserControlsHelper.EmptyText(uCNadjiTim.TxtDrzava))
            {
                MessageBox.Show("Sistem ne može da nađe timove po zadatoj vrednosti! Niste uneli nijedan kriterijum za pretragu! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            uCNadjiTim.DgvTimovi.DataSource = null;
            if (!UserControlsHelper.EmptyText(uCNadjiTim.TxtNaziv) && !UserControlsHelper.EmptyText(uCNadjiTim.TxtDrzava))
            {
                try
                {
                    Tim tim = new Tim
                    {
                        FindCondition = $"where lower(DrzavaTima) like '{uCNadjiTim.TxtDrzava.Text.ToLower()}%' and lower(ImeTima) like '{uCNadjiTim.TxtNaziv.Text.ToLower()}%'"
                    };
                    BindingList<Tim> timovi = new BindingList<Tim>(Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.NadjiTimove, tim));
                    if (timovi.Count == 0)
                    {
                        MessageBox.Show("Sistem ne može da nađe timove po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        uCNadjiTim.DgvTimovi.DataSource = null;
                        return;
                    }
                    uCNadjiTim.DgvTimovi.DataSource = timovi;
                    MessageBox.Show("Sistem je našao timove po zadatoj vrednosti", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Sistem ne može da nađe timove po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    throw;
                }
            }
            else if (!UserControlsHelper.EmptyText(uCNadjiTim.TxtNaziv) && UserControlsHelper.EmptyText(uCNadjiTim.TxtDrzava))
            {
                uCNadjiTim.TxtDrzava.BackColor = Color.White;
                try
                {
                    Tim tim = new Tim
                    {
                        FindCondition = $"where lower(ImeTima) like '{uCNadjiTim.TxtNaziv.Text.ToLower()}%'"
                    };
                    BindingList<Tim> timovi = new BindingList<Tim>(Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.NadjiTimove, tim));
                    if (timovi.Count == 0)
                    {
                        MessageBox.Show("Sistem ne može da nađe timove po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        uCNadjiTim.DgvTimovi.DataSource = null;
                        return;
                    }
                    uCNadjiTim.DgvTimovi.DataSource = timovi;
                    MessageBox.Show("Sistem je našao timove po zadatoj vrednosti!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Sistem ne može da nađe timove po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    throw;
                }
            }

            else if (UserControlsHelper.EmptyText(uCNadjiTim.TxtNaziv) && !UserControlsHelper.EmptyText(uCNadjiTim.TxtDrzava))
            {
                uCNadjiTim.TxtNaziv.BackColor = Color.White;
                try
                { 
                    Tim tim = new Tim
                    {
                        FindCondition = $"where lower(DrzavaTima) like '{uCNadjiTim.TxtDrzava.Text.ToLower()}%'"
                    };
                    BindingList<Tim> timovi = new BindingList<Tim>(Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.NadjiTimove, tim));
                    if (timovi.Count == 0)
                    {
                        MessageBox.Show("Sistem ne može da nađe timove po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        uCNadjiTim.DgvTimovi.DataSource = null;
                        return;
                    }
                    uCNadjiTim.DgvTimovi.DataSource = timovi;
                    MessageBox.Show("Sistem je našao timove po zadatoj vrednosti!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Sistem ne može da nađe timove po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    throw new ServerCommunicationException();
                }
            }
            
        }

        private void OcistiPodatke()
        {
            uCNadjiTim.TxtIme.Text = "";
            uCNadjiTim.TxtDrzavaTima.Text = "";
            uCNadjiTim.TxtBrojPobeda.Text = "";
            uCNadjiTim.TxtBrojPoraza.Text = "";
            uCNadjiTim.TxtBodovi.Text = "";
            uCNadjiTim.TxtDvorana.Text = "";
        }

        internal void PrikaziTim()
        {
            if(uCNadjiTim.DgvTimovi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sistem ne može da učita tim! Niste odabrali nijedan tim! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Tim tim = (Tim)uCNadjiTim.DgvTimovi.SelectedRows[0].DataBoundItem;
                tim.FindCondition = $"where TimId = {tim.TimId}";
                tim = Communication.Instance.SendRequestGetResult<Tim>(Operation.UcitajTim, tim);
                uCNadjiTim.TxtIme.Text = tim.Ime;
                uCNadjiTim.TxtDrzavaTima.Text = tim.Drzava;
                uCNadjiTim.TxtBrojPobeda.Text = tim.BrojPobeda.ToString();
                uCNadjiTim.TxtBrojPoraza.Text = tim.BrojPoraza.ToString();
                uCNadjiTim.TxtBodovi.Text = tim.Bodovi.ToString();
                uCNadjiTim.TxtDvorana.Text = tim.Dvorana.Ime;
                MessageBox.Show("Sistem je učitao tim!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da učita tim!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }
    }
}
