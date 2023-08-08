using Client.Forms.Exceptions;
using Client.Forms.GUIHelper;
using Client.Forms.ServerCommunication;
using Client.Forms.UserControls.Igrac;
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
                MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti! Niste uneli nijedan podatak za pretragu! Pokušajte ponovo!");
                return;
            }

            else if (!UserControlsHelper.EmptyText(uCPretragaIgraca.TxtImeIgraca) && UserControlsHelper.EmptyText(uCPretragaIgraca.TxtPrezimeIgraca))
            {
                uCPretragaIgraca.TxtPrezimeIgraca.BackColor = Color.White;
                try
                {
                    Igrac igrac = new Igrac
                    {
                        FindCondition = $"lower(ImeIgraca) like '{uCPretragaIgraca.TxtImeIgraca.Text.ToLower()}%'"
                    };
                    BindingList<Igrac> igraci = new BindingList<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, igrac));
                    if (igraci.Count == 0)
                    {
                        MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!");
                        uCPretragaIgraca.DgvIgraci.DataSource = null;
                        return;
                    }
                    uCPretragaIgraca.DgvIgraci.DataSource = igraci;
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!");
                    throw;
                }
            }

            else if (UserControlsHelper.EmptyText(uCPretragaIgraca.TxtImeIgraca) && !UserControlsHelper.EmptyText(uCPretragaIgraca.TxtPrezimeIgraca))
            {
                uCPretragaIgraca.TxtImeIgraca.BackColor = Color.White;
                try
                {
                    Igrac igrac = new Igrac
                    {
                        FindCondition = $"lower(PrezimeIgraca) like '{uCPretragaIgraca.TxtPrezimeIgraca.Text.ToLower()}%'"
                    };
                    BindingList<Igrac> igraci = new BindingList<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, igrac));
                    if (igraci.Count == 0)
                    {
                        MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!");
                        uCPretragaIgraca.DgvIgraci.DataSource = null;
                        return;
                    }
                    uCPretragaIgraca.DgvIgraci.DataSource = igraci;
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!");
                    throw;
                }
            }
            else if (!UserControlsHelper.EmptyText(uCPretragaIgraca.TxtImeIgraca) && !UserControlsHelper.EmptyText(uCPretragaIgraca.TxtPrezimeIgraca))
            {
                try
                { 
                    Igrac igrac = new Igrac
                    {
                        FindCondition = $"lower(ImeIgraca) like '{uCPretragaIgraca.TxtImeIgraca.Text.ToLower()}%' and lower(PrezimeIgraca) like '{uCPretragaIgraca.TxtPrezimeIgraca.Text.ToLower()}%'"
                    };
                    BindingList<Igrac> igraci = new BindingList<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, igrac));
                    if (igraci.Count == 0)
                    {
                        MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!");
                        uCPretragaIgraca.DgvIgraci.DataSource = null;
                        uCPretragaIgraca.TxtImeIgraca.BackColor = Color.White;
                        uCPretragaIgraca.TxtPrezimeIgraca.BackColor = Color.White;
                        return;
                    }
                    uCPretragaIgraca.DgvIgraci.DataSource = igraci;
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!");
                    throw;
                }
            }
        }

        internal void PrikaziIgraca()
        {
            if (uCPretragaIgraca.DgvIgraci.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sistem ne može da učita igrača! Niste odabrali nijednog igrača! Pokušajte ponovo!");
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
