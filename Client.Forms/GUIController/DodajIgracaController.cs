using Client.Forms.GUIHelper;
using Client.Forms.ServerCommunication;
using Client.Forms.UserControls.Igrac;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.GUIController
{
    public class DodajIgracaController
    {
        private UCDodajIgraca uCDodajIgraca;

        public DodajIgracaController(UCDodajIgraca uCDodajIgraca)
        {
            this.uCDodajIgraca = uCDodajIgraca;
        }

        internal void Init()
        {
            uCDodajIgraca.CbPozicije.DataSource = Enum.GetValues(typeof(Pozicija));
            uCDodajIgraca.CbTim.DataSource = Communication.Instance.SendRequestGetResult<List<Tim>>(Operation.VratiSveTimove);
        }

        internal void SacuvajIgraca()
        {
            if(UserControlsHelper.EmptyText(uCDodajIgraca.TxtIme) || UserControlsHelper.EmptyText(uCDodajIgraca.TxtPrezime) || UserControlsHelper.EmptyText(uCDodajIgraca.TxtDrzava) || UserControlsHelper.EmptyText(uCDodajIgraca.TxtBrojNaDresu) ||  UserControlsHelper.EmptyText(uCDodajIgraca.TxtVisina) || UserControlsHelper.EmptyText(uCDodajIgraca.TxtTezina))
            {
                MessageBox.Show("Sistem ne moze da zapamti igraca! Niste uneli sve potrebne podatke! Pokusajte ponovo!");
                return;
            }
            if(UserControlsHelper.ComboBoxValidation(uCDodajIgraca.CbTim))
            {
                MessageBox.Show("Sistem ne moze da zapamti igraca! Niste lepo odabrali tim u combo box-u! Pokusajte ponovo!");
                return;
            }

            if (UserControlsHelper.ComboBoxValidation(uCDodajIgraca.CbPozicije))
            {
                MessageBox.Show("Sistem ne moze da zapamti igraca! Niste lepo odabrali poziciju u combo box-u! Pokusajte ponovo!");
                return;
            }

            if (UserControlsHelper.IntegerValidation(uCDodajIgraca.TxtBrojNaDresu))
            {
                MessageBox.Show("Sistem ne moze da zapamti igraca! Broj na dresu mora da bude pozitivan broj! Pokusajte ponovo!");
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCDodajIgraca.TxtVisina))
            {
                MessageBox.Show("Sistem ne moze da zapamti igraca! Visina mora da bude pozitivan broj! Pokusajte ponovo!");
                return;
            }
            if(UserControlsHelper.DoubleValidation(uCDodajIgraca.TxtTezina))
            {
                MessageBox.Show("Sistem ne moze da zapamti igraca! Tezina mora da bude unesena kao decimalni broj! Pokusajte ponovo!");
            }
            try
            {
                Igrac igrac = new Igrac
                {
                    ImeIgraca = uCDodajIgraca.TxtIme.Text,
                    PrezimeIgraca = uCDodajIgraca.TxtPrezime.Text,
                    DrzavaIgraca = uCDodajIgraca.TxtDrzava.Text,
                    Pozicija = (Pozicija)(uCDodajIgraca.CbPozicije.SelectedItem),
                    BrojNaDresu = Convert.ToInt32(uCDodajIgraca.TxtBrojNaDresu.Text),
                    Visina = Convert.ToInt32(uCDodajIgraca.TxtVisina.Text),
                    Tezina = Convert.ToDouble(uCDodajIgraca.TxtTezina.Text),
                    Tim = (Tim)uCDodajIgraca.CbTim.SelectedItem
                };
                Communication.Instance.SendRequestNoResult(Operation.SacuvajIgraca, igrac);
                MessageBox.Show("Sistem je zapamtio igraca");
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
            uCDodajIgraca.TxtIme.Clear();
            uCDodajIgraca.TxtPrezime.Clear();
            uCDodajIgraca.TxtDrzava.Clear();
            uCDodajIgraca.TxtBrojNaDresu.Clear();
            uCDodajIgraca.TxtVisina.Clear();
            uCDodajIgraca.TxtTezina.Clear();
            uCDodajIgraca.CbPozicije.SelectedIndex = 0;
            uCDodajIgraca.CbTim.SelectedIndex = 0;
        }
    }
}
