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
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.GUIController
{
    public class IzmeniIgracaController
    {
        private UCIzmeniIgraca uCIzmeniIgraca;
        public Igrac IzabraniIgrac { get; set; }
        public Igrac IzmenjeniIgrac { get; set; }
        public IzmeniIgracaController(UCIzmeniIgraca uCIzmeniIgraca)
        {
            this.uCIzmeniIgraca = uCIzmeniIgraca;
        }

        internal void Init()
        {
            uCIzmeniIgraca.CbPozicije.DataSource = Enum.GetValues(typeof(Pozicija));
            uCIzmeniIgraca.CbTim.DataSource = Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.VratiSveTimove);
            uCIzmeniIgraca.BtnIzmeniIgraca.Enabled = false;
        }

        internal void NadjiIgrace()
        {
            if (UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtImeIgraca) && UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtPrezimeIgraca))
            {
                MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti! Niste uneli nijedan podatak za pretragu! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtImeIgraca) && UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtPrezimeIgraca))
            {
                uCIzmeniIgraca.TxtPrezimeIgraca.BackColor = Color.White;
                try
                {
                    Igrac igrac = new Igrac
                    {
                        FindCondition = $"where lower(ImeIgraca) like '{uCIzmeniIgraca.TxtImeIgraca.Text.ToLower()}%'"
                    };
                    BindingList<Igrac> igraci = new BindingList<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, igrac));
                    if (igraci.Count == 0)
                    {
                        MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        uCIzmeniIgraca.DgvIgraci.DataSource = null;
                        return;
                    }
                    uCIzmeniIgraca.DgvIgraci.DataSource = igraci;
                    MessageBox.Show("Sistem je našao igrače po zadatoj vrednosti", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    throw;
                }
            }

            else if (UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtImeIgraca) && !UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtPrezimeIgraca))
            {
                uCIzmeniIgraca.TxtImeIgraca.BackColor = Color.White;
                try
                {
                    Igrac igrac = new Igrac
                    {
                        FindCondition = $"where lower(PrezimeIgraca) like '{uCIzmeniIgraca.TxtPrezimeIgraca.Text.ToLower()}%'"
                    };
                    BindingList<Igrac> igraci = new BindingList<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, igrac));
                    if (igraci.Count == 0)
                    {
                        MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        uCIzmeniIgraca.DgvIgraci.DataSource = null;
                        return;
                    }
                    uCIzmeniIgraca.DgvIgraci.DataSource = igraci;
                    MessageBox.Show("Sistem je našao igrače po zadatoj vrednosti", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    throw;
                }
            }
            else if (!UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtImeIgraca) && !UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtPrezimeIgraca))
            {
                try
                {
                    Igrac igrac = new Igrac
                    {
                        FindCondition = $"where lower(ImeIgraca) like '{uCIzmeniIgraca.TxtImeIgraca.Text.ToLower()}%' and lower(PrezimeIgraca) like '{uCIzmeniIgraca.TxtPrezimeIgraca.Text.ToLower()}%'"
                    };
                    BindingList<Igrac> igraci = new BindingList<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, igrac));
                    if (igraci.Count == 0)
                    {
                        MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        uCIzmeniIgraca.DgvIgraci.DataSource = null;
                        return;
                    }
                    uCIzmeniIgraca.DgvIgraci.DataSource = igraci;
                    MessageBox.Show("Sistem je našao igrače po zadatoj vrednosti", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Sistem ne može da nađe igrače po zadatoj vrednosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    throw;
                }
            }
        }

        internal void IzmeniIgraca()
        {
            if(UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtIme) || UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtPrezime) || UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtDrzava) || UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtBrojNaDresu) || UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtVisina) && UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtTezina))
            {
                MessageBox.Show("Sistem ne može da izmeni igrača! Niste uneli sve potrebne vrednosti! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(UserControlsHelper.IntegerValidation(uCIzmeniIgraca.TxtBrojNaDresu))
            {
                MessageBox.Show("Sistem ne može da izmeni igrača! Broj na dresu mora da bude pozitivan broj! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCIzmeniIgraca.TxtVisina))
            {
                MessageBox.Show("Sistem ne može da izmeni igrača! Visina mora da bude pozitivan broj! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserControlsHelper.ComboBoxValidation(uCIzmeniIgraca.CbTim))
            {
                MessageBox.Show("Sistem ne može da izmeni igrača! Niste lepo odabrali tim u combo box-u! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UserControlsHelper.ComboBoxValidation(uCIzmeniIgraca.CbPozicije))
            {
                MessageBox.Show("Sistem ne može da izmeni igrača! Niste lepo odabrali poziciju u combo box-u! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserControlsHelper.DoubleValidation(uCIzmeniIgraca.TxtTezina))
            {
                MessageBox.Show("Sistem ne može da izmeni igrača! Težina mora da bude uenta kao decimalni broj! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserControlsHelper.WordValidation(uCIzmeniIgraca.TxtIme))
            {
                MessageBox.Show("Sistem ne može da izmeni igrača! Ime ne sme da sadrži broj u nazivu! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserControlsHelper.WordValidation(uCIzmeniIgraca.TxtPrezime))
            {
                MessageBox.Show("Sistem ne može da izmeni igrača! Prezime ne sme da sadrži broj u nazivu! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserControlsHelper.WordValidation(uCIzmeniIgraca.TxtDrzava))
            {
                MessageBox.Show("Sistem ne može da izmeni igrača! Država ne sme da sadrži broj u nazivu! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(UserControlsHelper.ThreeDigitsNumberValidation(uCIzmeniIgraca.TxtBrojNaDresu))
            {
                MessageBox.Show("Sistem ne može da izmeni igrača! Broj na dresu ne sme da bude trocifren broj! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                IzmenjeniIgrac = new Igrac
                {
                    IgracId = IzabraniIgrac.IgracId,
                    ImeIgraca = uCIzmeniIgraca.TxtIme.Text,
                    PrezimeIgraca = uCIzmeniIgraca.TxtPrezime.Text,
                    DrzavaIgraca = uCIzmeniIgraca.TxtDrzava.Text,
                    DateString = uCIzmeniIgraca.TxtDatumRodjenja.Text,
                    Pozicija = (Pozicija)(uCIzmeniIgraca.CbPozicije.SelectedItem),
                    BrojNaDresu = Convert.ToInt32(uCIzmeniIgraca.TxtBrojNaDresu.Text),
                    Visina = Convert.ToInt32(uCIzmeniIgraca.TxtVisina.Text),
                    Tim = (Tim)uCIzmeniIgraca.CbTim.SelectedItem
                };
                if (uCIzmeniIgraca.TxtTezina.Text.Contains(',') && CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator == ".")
                {
                    IzmenjeniIgrac.Tezina = Convert.ToDouble(uCIzmeniIgraca.TxtTezina.Text.Replace(',', '.'));
                }
                else if (uCIzmeniIgraca.TxtTezina.Text.Contains('.') && CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator == ",")
                {
                    IzmenjeniIgrac.Tezina = Convert.ToDouble(uCIzmeniIgraca.TxtTezina.Text.Replace('.', ','));
                }
                else
                {
                    IzmenjeniIgrac.Tezina = Convert.ToDouble(uCIzmeniIgraca.TxtTezina.Text);
                }
                Communication.Instance.SendRequestNoResult(Operation.IzmeniIgraca, IzmenjeniIgrac);
                MessageBox.Show("Sistem je izmenio igrača!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcistiPodatke();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da izmeni igrača", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        private void OcistiPodatke()
        {
            uCIzmeniIgraca.TxtIme.Clear();
            uCIzmeniIgraca.TxtPrezime.Clear();
            uCIzmeniIgraca.TxtDrzava.Clear();
            uCIzmeniIgraca.TxtBrojNaDresu.Clear();
            uCIzmeniIgraca.TxtVisina.Clear();
            uCIzmeniIgraca.TxtTezina.Clear();
            uCIzmeniIgraca.CbPozicije.SelectedIndex = 0;
            uCIzmeniIgraca.CbTim.SelectedIndex = 0;
            uCIzmeniIgraca.DgvIgraci.DataSource = null;
            uCIzmeniIgraca.TxtImeIgraca.Clear();
            uCIzmeniIgraca.TxtPrezimeIgraca.Clear();
        }

        internal void UcitajIgraca()
        {
            if (uCIzmeniIgraca.DgvIgraci.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sistem ne može da učita igrača! Niste odabrali nijednog igrača! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Igrac igrac = (Igrac)uCIzmeniIgraca.DgvIgraci.SelectedRows[0].DataBoundItem;
                igrac.FindCondition = $"where IgracId = {igrac.IgracId}";
                IzabraniIgrac = Communication.Instance.SendRequestGetResult<Igrac>(Operation.UcitajIgraca, igrac);
                uCIzmeniIgraca.TxtIme.Text = IzabraniIgrac.ImeIgraca;
                uCIzmeniIgraca.TxtPrezime.Text = IzabraniIgrac.PrezimeIgraca;
                uCIzmeniIgraca.TxtDrzava.Text = IzabraniIgrac.DrzavaIgraca;
                uCIzmeniIgraca.TxtDatumRodjenja.Text = IzabraniIgrac.DatumRodjenja.ToShortDateString();
                uCIzmeniIgraca.CbPozicije.Text = IzabraniIgrac.Pozicija.ToString();
                uCIzmeniIgraca.TxtBrojNaDresu.Text = IzabraniIgrac.BrojNaDresu.ToString();
                uCIzmeniIgraca.TxtVisina.Text = IzabraniIgrac.Visina.ToString();
                uCIzmeniIgraca.TxtTezina.Text = IzabraniIgrac.Tezina.ToString();
                uCIzmeniIgraca.CbTim.Text = IzabraniIgrac.Tim.ToString();
                MessageBox.Show("Sistem je učitao igrača", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                uCIzmeniIgraca.BtnIzmeniIgraca.Enabled = true;
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da učita igrača", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }
    }
}
