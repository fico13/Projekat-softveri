using Client.Forms.Exceptions;
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
            if(UserControlsHelper.EmptyText(uCNadjiTim.TxtNaziv) && UserControlsHelper.EmptyText(uCNadjiTim.TxtDrzava))
            {
                MessageBox.Show("Sistem ne može da nađe timove po zadatoj vrednosti! Niste uneli nijedan kriterijum za pretragu! Pokušajte ponovo!");
                return;
            }
            uCNadjiTim.DgvTimovi.DataSource = null;
            if (!UserControlsHelper.EmptyText(uCNadjiTim.TxtNaziv) && !UserControlsHelper.EmptyText(uCNadjiTim.TxtDrzava))
            {
                try
                {
                    Tim tim = new Tim
                    {
                        FindCondition = $"lower(DrzavaTima) like '{uCNadjiTim.TxtDrzava.Text.ToLower()}%' and lower(ImeTima) like '{uCNadjiTim.TxtNaziv.Text.ToLower()}%'"
                    };
                    BindingList<Tim> timovi = new BindingList<Tim>(Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.NadjiTimove, tim));
                    if (timovi.Count == 0)
                    {
                        MessageBox.Show("Sistem ne može da nađe timove po zadatoj vrednosti");
                        uCNadjiTim.DgvTimovi.DataSource = null;
                        return;
                    }
                    uCNadjiTim.DgvTimovi.DataSource = timovi;
                    OcistiPodatke();
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Sistem ne može da nađe timove po zadatoj vrednosti");
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
                        FindCondition = $"lower(ImeTima) like '{uCNadjiTim.TxtNaziv.Text.ToLower()}%'"
                    };
                    BindingList<Tim> timovi = new BindingList<Tim>(Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.NadjiTimove, tim));
                    if (timovi.Count == 0)
                    {
                        MessageBox.Show("Sistem ne može da nađe timove po zadatoj vrednosti!");
                        uCNadjiTim.DgvTimovi.DataSource = null;
                        return;
                    }
                    uCNadjiTim.DgvTimovi.DataSource = timovi;
                   
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Sistem ne može da nađe timove po zadatoj vrednosti");
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
                        FindCondition = $"lower(DrzavaTima) like '{uCNadjiTim.TxtDrzava.Text.ToLower()}%'"
                    };
                    BindingList<Tim> timovi = new BindingList<Tim>(Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.NadjiTimove, tim));
                    if (timovi.Count == 0)
                    {
                        MessageBox.Show("Sistem ne može da nađe timove po zadatoj vrednosti");
                        uCNadjiTim.DgvTimovi.DataSource = null;
                        return;
                    }
                    uCNadjiTim.DgvTimovi.DataSource = timovi;
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Sistem ne može da nađe timove po zadatoj vrednosti");
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
                MessageBox.Show("Sistem ne može da učita tim! Niste odabrali nijedan tim! Pokušajte ponovo!");
                return;
            }
            Tim tim = (Tim)uCNadjiTim.DgvTimovi.SelectedRows[0].DataBoundItem;
            uCNadjiTim.TxtIme.Text = tim.Ime;
            uCNadjiTim.TxtDrzavaTima.Text = tim.Drzava;
            uCNadjiTim.TxtBrojPobeda.Text = tim.BrojPobeda.ToString();
            uCNadjiTim.TxtBrojPoraza.Text = tim.BrojPoraza.ToString();
            uCNadjiTim.TxtBodovi.Text = tim.Bodovi.ToString();
            uCNadjiTim.TxtDvorana.Text = tim.Dvorana.Ime;
        }
    }
}
