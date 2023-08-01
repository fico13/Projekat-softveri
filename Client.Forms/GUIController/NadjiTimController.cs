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
                MessageBox.Show("Niste uneli nijedan kriterijum za pretragu! Pokusajte ponovo");
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
                    uCNadjiTim.DgvTimovi.DataSource = timovi;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem ne moze da nadje timove po zadatim vrednostima! " + ex.Message);
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
                    uCNadjiTim.DgvTimovi.DataSource = timovi;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem ne moze da nadje timove po zadatim vrednostima! " + ex.Message);
                }
            }
        }
    }
}
