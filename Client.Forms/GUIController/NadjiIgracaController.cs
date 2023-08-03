using Client.Forms.GUIHelper;
using Client.Forms.ServerCommunication;
using Client.Forms.UserControls.Igrac;
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
    public class NadjiIgracaController
    {
        private UCPretragaIgraca uCPretragaIgraca;

        public NadjiIgracaController(UCPretragaIgraca uCPretragaIgraca)
        {
            this.uCPretragaIgraca = uCPretragaIgraca;
        }

        internal void NadjiIgrace()
        {
            if(UserControlsHelper.EmptyText(uCPretragaIgraca.TxtImeIgraca) && UserControlsHelper.EmptyText(uCPretragaIgraca.TxtPrezimeIgraca))
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da nadje igrace po zadatoj vrednosti! Niste uneli nijedan podatak za pretragu! Pokusajte ponovo!");
                return;
            }

            if (!UserControlsHelper.EmptyText(uCPretragaIgraca.TxtImeIgraca) && UserControlsHelper.EmptyText(uCPretragaIgraca.TxtPrezimeIgraca))
            {
                try
                {
                    Igrac igrac = new Igrac
                    {
                        FindCondition = $"ImeIgraca like '{uCPretragaIgraca.TxtImeIgraca.Text}%'"
                    };
                    BindingList<Igrac> igraci = new BindingList<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, igrac));
                    if (igraci.Count == 0)
                    {
                        MessageBox.Show("Sistem ne moze da nadje igrace po zadatoj vrednosti!");
                        uCPretragaIgraca.DgvIgraci.DataSource = null;
                        return;
                    }
                    uCPretragaIgraca.DgvIgraci.DataSource = igraci;
                    uCPretragaIgraca.DgvIgraci.Columns["IgracId"].Visible = false;
                    uCPretragaIgraca.TxtImeIgraca.Clear();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Sistem ne moze da nadje igrace po zadatoj vrednosti!" + ex.Message);
                }
            }

            if (UserControlsHelper.EmptyText(uCPretragaIgraca.TxtImeIgraca) && !UserControlsHelper.EmptyText(uCPretragaIgraca.TxtPrezimeIgraca))
            {
                try
                {
                    Igrac igrac = new Igrac
                    {
                        FindCondition = $"PrezimeIgraca like '{uCPretragaIgraca.TxtPrezimeIgraca.Text}%'"
                    };
                    BindingList<Igrac> igraci = new BindingList<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, igrac));
                    if (igraci.Count == 0)
                    {
                        MessageBox.Show("Sistem ne moze da nadje igrace po zadatoj vrednosti!");
                        uCPretragaIgraca.DgvIgraci.DataSource = null;
                        return;
                    }
                    uCPretragaIgraca.DgvIgraci.DataSource = igraci;
                    uCPretragaIgraca.DgvIgraci.Columns["IgracId"].Visible = false;
                    uCPretragaIgraca.TxtPrezimeIgraca.Clear();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Sistem ne moze da nadje igrace po zadatoj vrednosti!" + ex.Message);
                }
            }
        }

        internal void PrikaziIgraca()
        {
            if (uCPretragaIgraca.DgvIgraci.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da ucita igraca! Niste odabrali nijednog igraca, pokusajte ponovo!");
                return;
            }
            Igrac igrac = (Igrac)uCPretragaIgraca.DgvIgraci.SelectedRows[0].DataBoundItem;
            uCPretragaIgraca.TxtIme.Text = igrac.ImeIgraca;
            uCPretragaIgraca.TxtPrezime.Text = igrac.PrezimeIgraca;
            uCPretragaIgraca.TxtDrzava.Text = igrac.DrzavaIgraca;
            uCPretragaIgraca.TxtPozicija.Text = igrac.Pozicija.ToString();
            uCPretragaIgraca.TxtBrojNaDresu.Text = igrac.BrojNaDresu.ToString();
            uCPretragaIgraca.TxtVisina.Text = igrac.Visina.ToString();  
            uCPretragaIgraca.TxtTezina.Text = igrac.Tezina.ToString();
            uCPretragaIgraca.TxtTim.Text = igrac.Tim.ToString();  
        }
    }
}
