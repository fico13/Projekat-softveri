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
    public class IzmeniIgracaController
    {
        private UCIzmeniIgraca uCIzmeniIgraca;
        public Igrac IzabraniIgrac { get; set; }
        public IzmeniIgracaController(UCIzmeniIgraca uCIzmeniIgraca)
        {
            this.uCIzmeniIgraca = uCIzmeniIgraca;
        }

        internal void Init()
        {
            uCIzmeniIgraca.CbPozicije.DataSource = Enum.GetValues(typeof(Pozicija));
            uCIzmeniIgraca.CbTim.DataSource = Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.VratiSveTimove);
        }

        internal void NadjiIgrace()
        {
            if (UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtImeIgraca) && UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtPrezimeIgraca))
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da nadje igrace po zadatoj vrednosti! Niste uneli nijedan podatak za pretragu! Pokusajte ponovo!");
                return;
            }

            if (!UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtImeIgraca) && UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtPrezimeIgraca))
            {
                try
                {
                    Igrac igrac = new Igrac
                    {
                        FindCondition = $"ImeIgraca like '{uCIzmeniIgraca.TxtImeIgraca.Text}%'"
                    };
                    BindingList<Igrac> igraci = new BindingList<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, igrac));
                    if (igraci.Count == 0)
                    {
                        MessageBox.Show("Sistem ne moze da nadje igrace po zadatoj vrednosti!");
                        uCIzmeniIgraca.DgvIgraci.DataSource = null;
                        return;
                    }
                    uCIzmeniIgraca.DgvIgraci.DataSource = igraci;
                    uCIzmeniIgraca.DgvIgraci.Columns["IgracId"].Visible = false;
                    uCIzmeniIgraca.TxtImeIgraca.Clear();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Sistem ne moze da nadje igrace po zadatoj vrednosti!" + ex.Message);
                }
            }

            if (UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtImeIgraca) && !UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtPrezimeIgraca))
            {
                try
                {
                    Igrac igrac = new Igrac
                    {
                        FindCondition = $"PrezimeIgraca like '{uCIzmeniIgraca.TxtPrezimeIgraca.Text}%'"
                    };
                    BindingList<Igrac> igraci = new BindingList<Igrac>(Communication.Instance.SendRequestGetResult<List<Igrac>>(Operation.NadjiIgrace, igrac));
                    if (igraci.Count == 0)
                    {
                        MessageBox.Show("Sistem ne moze da nadje igrace po zadatoj vrednosti!");
                        uCIzmeniIgraca.DgvIgraci.DataSource = null;
                        return;
                    }
                    uCIzmeniIgraca.DgvIgraci.DataSource = igraci;
                    uCIzmeniIgraca.DgvIgraci.Columns["IgracId"].Visible = false;
                    uCIzmeniIgraca.TxtPrezimeIgraca.Clear();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Sistem ne moze da nadje igrace po zadatoj vrednosti!" + ex.Message);
                }
            }
        }

        internal void IzmeniIgraca()
        {
            if(UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtIme) && UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtPrezime) && UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtDrzava) && UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtBrojNaDresu) && UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtVisina) && UserControlsHelper.EmptyText(uCIzmeniIgraca.TxtTezina))
            {
                MessageBox.Show("Sistem ne moze da izmeni igraca! Niste uneli sve potrebne vrednosti! Pokusajte ponovo!");
                return;
            }
            if(UserControlsHelper.IntegerValidation(uCIzmeniIgraca.TxtBrojNaDresu))
            {
                MessageBox.Show("Sistem ne moze da izmeni igraca! Broj na dresu mora da bude pozitivan broj! Pokusajte ponovo!");
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCIzmeniIgraca.TxtVisina))
            {
                MessageBox.Show("Sistem ne moze da izmeni igraca! Visina mora da bude pozitivan broj! Pokusajte ponovo!");
                return;
            }
            if (UserControlsHelper.ComboBoxValidation(uCIzmeniIgraca.CbTim))
            {
                MessageBox.Show("Sistem ne moze da zapamti igraca! Niste lepo odabrali tim u combo box-u! Pokusajte ponovo!");
                return;
            }

            if (UserControlsHelper.ComboBoxValidation(uCIzmeniIgraca.CbPozicije))
            {
                MessageBox.Show("Sistem ne moze da zapamti igraca! Niste lepo odabrali poziciju u combo box-u! Pokusajte ponovo!");
                return;
            }
            if (UserControlsHelper.DoubleValidation(uCIzmeniIgraca.TxtTezina))
            {
                MessageBox.Show("Sistem ne moze da zapamti igraca! Tezina mora da bude unesena kao decimalni broj! Pokusajte ponovo!");
            }
            try
            {
                Igrac igrac = new Igrac
                {
                    IgracId = IzabraniIgrac.IgracId,
                    ImeIgraca = uCIzmeniIgraca.TxtIme.Text,
                    PrezimeIgraca = uCIzmeniIgraca.TxtPrezime.Text,
                    DrzavaIgraca = uCIzmeniIgraca.TxtDrzava.Text,
                    Pozicija = (Pozicija)(uCIzmeniIgraca.CbPozicije.SelectedItem),
                    BrojNaDresu = Convert.ToInt32(uCIzmeniIgraca.TxtBrojNaDresu.Text),
                    Visina = Convert.ToInt32(uCIzmeniIgraca.TxtVisina.Text),
                    Tezina = Convert.ToDouble(uCIzmeniIgraca.TxtTezina.Text),
                    Tim = (Tim)uCIzmeniIgraca.CbTim.SelectedItem
                };
                Communication.Instance.SendRequestNoResult(Operation.IzmeniIgraca, igrac);
                MessageBox.Show("Sistem je izmenio igraca");
                OcistiPodatke();
            }
            catch (FormatException)
            {
                MessageBox.Show("Za tezinu morate uneti decimalni broj sa decimalnom tackom!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne moze da zapamti igraca! " + ex.Message);
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
        }

        internal void UcitajIgraca()
        {
            if (uCIzmeniIgraca.DgvIgraci.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da ucita igraca! Niste odabrali nijednog igraca, pokusajte ponovo!");
                return;
            }
            IzabraniIgrac = (Igrac)uCIzmeniIgraca.DgvIgraci.SelectedRows[0].DataBoundItem;
            uCIzmeniIgraca.TxtIme.Text = IzabraniIgrac.ImeIgraca;
            uCIzmeniIgraca.TxtPrezime.Text = IzabraniIgrac.PrezimeIgraca;
            uCIzmeniIgraca.TxtDrzava.Text = IzabraniIgrac.DrzavaIgraca;
            uCIzmeniIgraca.CbPozicije.Text = IzabraniIgrac.Pozicija.ToString();
            uCIzmeniIgraca.TxtBrojNaDresu.Text = IzabraniIgrac.BrojNaDresu.ToString();
            uCIzmeniIgraca.TxtVisina.Text = IzabraniIgrac.Visina.ToString();
            uCIzmeniIgraca.TxtTezina.Text = IzabraniIgrac.Tezina.ToString();
            uCIzmeniIgraca.CbTim.Text = IzabraniIgrac.Tim.ToString();
        }
    }
}
