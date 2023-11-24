using Client.Forms.Dialogs.Igrac;
using Client.Forms.Exceptions;
using Client.Forms.GUIHelper;
using Client.Forms.ServerCommunication;
using Client.Forms.Session;
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
        public Igrac IzabraniIgrac { get; set; }

        public NadjiIgracaController(UCPretragaIgraca uCPretragaIgraca)
        {
            this.uCPretragaIgraca = uCPretragaIgraca;
        }

        

        internal void NadjiIgrace()
        {
            OcistiPodatke();
            uCPretragaIgraca.DgvIgraci.DataSource = null;
            if(UserControlsHelper.EmptyText(uCPretragaIgraca.TxtImeIgraca) && UserControlsHelper.EmptyText(uCPretragaIgraca.TxtPrezimeIgraca))
            {
                MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti! Niste uneli nijedan podatak za pretragu! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (!UserControlsHelper.EmptyText(uCPretragaIgraca.TxtImeIgraca) && UserControlsHelper.EmptyText(uCPretragaIgraca.TxtPrezimeIgraca))
            {
                uCPretragaIgraca.TxtPrezimeIgraca.BackColor = Color.White;
                try
                {
                    Igrac igrac = new Igrac
                    {
                        FindCondition = $"where lower(ImeIgraca) like '{uCPretragaIgraca.TxtImeIgraca.Text.ToLower()}%'"
                    };
                    BindingList<Igrac> igraci = new BindingList<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, igrac));
                    if (igraci.Count == 0)
                    {
                        MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        uCPretragaIgraca.DgvIgraci.DataSource = null;
                        return;
                    }
                    uCPretragaIgraca.DgvIgraci.DataSource = igraci;
                    MessageBox.Show("Sistem je našao igrače po zadatoj vrednosti!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        FindCondition = $"where lower(PrezimeIgraca) like '{uCPretragaIgraca.TxtPrezimeIgraca.Text.ToLower()}%'"
                    };
                    BindingList<Igrac> igraci = new BindingList<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, igrac));
                    if (igraci.Count == 0)
                    {
                        MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        uCPretragaIgraca.DgvIgraci.DataSource = null;
                        return;
                    }
                    uCPretragaIgraca.DgvIgraci.DataSource = igraci;
                    MessageBox.Show("Sistem je našao igrače po zadatoj vrednosti", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    throw;
                }
            }
            else if (!UserControlsHelper.EmptyText(uCPretragaIgraca.TxtImeIgraca) && !UserControlsHelper.EmptyText(uCPretragaIgraca.TxtPrezimeIgraca))
            {
                try
                { 
                    Igrac igrac = new Igrac
                    {
                        FindCondition = $"where lower(ImeIgraca) like '{uCPretragaIgraca.TxtImeIgraca.Text.ToLower()}%' and lower(PrezimeIgraca) like '{uCPretragaIgraca.TxtPrezimeIgraca.Text.ToLower()}%'"
                    };
                    BindingList<Igrac> igraci = new BindingList<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, igrac));
                    if (igraci.Count == 0)
                    {
                        MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        uCPretragaIgraca.DgvIgraci.DataSource = null;
                        uCPretragaIgraca.TxtImeIgraca.BackColor = Color.White;
                        uCPretragaIgraca.TxtPrezimeIgraca.BackColor = Color.White;
                        return;
                    }
                    uCPretragaIgraca.DgvIgraci.DataSource = igraci;
                    MessageBox.Show("Sistem je našao igrače po zadatoj vrednosti", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    throw;
                }
            }
        }

        internal void PrikaziStatistiku()
        {
            FrmStatistikaIgraca frmStatistikaIgraca = new FrmStatistikaIgraca(IzabraniIgrac);
            frmStatistikaIgraca.ShowDialog();
        }

        private void OcistiPodatke()
        {
            uCPretragaIgraca.TxtIme.Clear();
            uCPretragaIgraca.TxtPrezime.Clear();
            uCPretragaIgraca.TxtDrzava.Clear();
            uCPretragaIgraca.TxtPozicija.Clear();
            uCPretragaIgraca.TxtBrojNaDresu.Clear();
            uCPretragaIgraca.TxtVisina.Clear();
            uCPretragaIgraca.TxtTezina.Clear();
            uCPretragaIgraca.TxtTim.Clear();
        }

        internal void PrikaziIgraca()
        {
            if (uCPretragaIgraca.DgvIgraci.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sistem ne može da učita igrača! Niste odabrali nijednog igrača! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Igrac igrac = (Igrac)uCPretragaIgraca.DgvIgraci.SelectedRows[0].DataBoundItem;
                igrac.FindCondition = $"where IgracId = {igrac.IgracId}";
                igrac = Communication.Instance.SendRequestGetResult<Igrac>(Operation.UcitajIgraca, igrac);
                uCPretragaIgraca.TxtIme.Text = igrac.ImeIgraca;
                uCPretragaIgraca.TxtPrezime.Text = igrac.PrezimeIgraca;
                uCPretragaIgraca.TxtDrzava.Text = igrac.DrzavaIgraca;
                uCPretragaIgraca.TxtDatumRodjenja.Text = igrac.DatumRodjenja.ToShortDateString();
                uCPretragaIgraca.TxtPozicija.Text = igrac.Pozicija.ToString();
                uCPretragaIgraca.TxtBrojNaDresu.Text = igrac.BrojNaDresu.ToString();
                uCPretragaIgraca.TxtVisina.Text = igrac.Visina.ToString();  
                uCPretragaIgraca.TxtTezina.Text = igrac.Tezina.ToString();
                uCPretragaIgraca.TxtTim.Text = igrac.Tim.ToString();
                MessageBox.Show("Sistem je učitao igrača!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IzabraniIgrac = igrac;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da učita igrača", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }
    }
}
