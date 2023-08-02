using Client.Forms.GUIHelper;
using Client.Forms.ServerCommunication;
using Client.Forms.UserControls.Tim;
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
    public class NadjiTimController
    {
        private UCNadjiTim uCNadjiTim;

        public NadjiTimController(UCNadjiTim uCNadjiTim)
        {
            this.uCNadjiTim = uCNadjiTim;
        }

        internal void NadjiTim()
        {
            if(UserControlsHelper.EmptyText(uCNadjiTim.TxtNaziv) && UserControlsHelper.EmptyText(uCNadjiTim.TxtDrzava))
            {
                MessageBox.Show("Sistem ne moze da nadje timove po zadatoj vrednosti! Niste uneli nijedan kriterijum za pretragu! Pokusajte ponovo!");
                return;
            }
            if(!UserControlsHelper.EmptyText(uCNadjiTim.TxtNaziv) && UserControlsHelper.EmptyText(uCNadjiTim.TxtDrzava))
            {
                try
                {
                    Tim tim = new Tim
                    {
                        FindCondition = $"ImeTima like '{uCNadjiTim.TxtNaziv.Text}%'"
                    };
                    BindingList<Tim> timovi = new BindingList<Tim>(Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.NadjiTimove, tim));
                    if (timovi.Count == 0)
                    {
                        MessageBox.Show("Sistem ne moze da nadje timove po zadatoj vrednosti!");
                        uCNadjiTim.DgvTimovi.DataSource = null;
                        return;
                    }
                    uCNadjiTim.DgvTimovi.DataSource = timovi;
                    uCNadjiTim.DgvTimovi.Columns["TimId"].Visible = false;
                    uCNadjiTim.TxtNaziv.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem ne moze da nadje timove po zadatoj vrednosti! " + ex.Message);

                }
            }

            if (UserControlsHelper.EmptyText(uCNadjiTim.TxtNaziv) && !UserControlsHelper.EmptyText(uCNadjiTim.TxtDrzava))
            {
                try
                {
                    Tim tim = new Tim
                    {
                        FindCondition = $"DrzavaTima like '{uCNadjiTim.TxtDrzava.Text}%'"
                    };
                    BindingList<Tim> timovi = new BindingList<Tim>(Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.NadjiTimove, tim));
                    if (timovi.Count == 0)
                    {
                        MessageBox.Show("Sistem ne moze da nadje timove po zadatoj vrednosti");
                        uCNadjiTim.DgvTimovi.DataSource = null;
                        return;
                    }
                    uCNadjiTim.DgvTimovi.DataSource = timovi;
                    uCNadjiTim.DgvTimovi.Columns["TimId"].Visible = false;
                    uCNadjiTim.TxtDrzava.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem ne moze da nadje timove po zadatoj vrednosti! " + ex.Message);
                }
            }
        }

        internal void PrikaziTim()
        {
            if(uCNadjiTim.DgvTimovi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da ucita tim! Niste odabrali nijedan tim, pokusajte ponovo!");
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
