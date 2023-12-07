using Client.Forms.Exceptions;
using Client.Forms.GUIHelper;
using Client.Forms.ServerCommunication;
using Client.Forms.UserControls.Igrac;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.GUIController
{
    public class DodajIgracaController
    {
        private UCDodajIgraca uCDodajIgraca;
        public Igrac Igrac { get; set; }

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
                MessageBox.Show("Sistem ne može da zapamti igrača! Niste uneli sve potrebne podatke! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(UserControlsHelper.ComboBoxValidation(uCDodajIgraca.CbTim))
            {
                MessageBox.Show("Sistem ne može da zapamti igrača! Niste lepo odabrali tim u combo box-u! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UserControlsHelper.ComboBoxValidation(uCDodajIgraca.CbPozicije))
            {
                MessageBox.Show("Sistem ne može da zapamti igrača! Niste lepo odabrali poziciju u combo box-u! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(uCDodajIgraca.DtpDatum.Value > DateTime.Now)
            {
                MessageBox.Show("Sistem ne može da zapamti igrača! Datum rođenja igrača ne može biti u budućnosti! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCDodajIgraca.TxtBrojNaDresu))
            {
                MessageBox.Show("Sistem ne može da zapamti igrača! Broj na dresu mora da bude pozitivan broj! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCDodajIgraca.TxtVisina))
            {
                MessageBox.Show("Sistem ne može da zapamti igrača! Visina mora da bude pozitivan broj! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(UserControlsHelper.DoubleValidation(uCDodajIgraca.TxtTezina))
            {
                MessageBox.Show("Sistem ne može da zapamti igrača! Težina mora da bude uneta kao decimalni broj! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserControlsHelper.WordValidation(uCDodajIgraca.TxtIme))
            {
                MessageBox.Show("Sistem ne može da zapamti igrača! Ime ne sme da sadrži broj u nazivu! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserControlsHelper.WordValidation(uCDodajIgraca.TxtPrezime))
            {
                MessageBox.Show("Sistem ne može da zapamti igrača! Prezime ne sme da sadrži broj u nazivu! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UserControlsHelper.WordValidation(uCDodajIgraca.TxtDrzava))
            {
                MessageBox.Show("Sistem ne može da zapamti igrača! Država ne sme da sadrži broj u nazivu! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(UserControlsHelper.ThreeDigitsNumberValidation(uCDodajIgraca.TxtBrojNaDresu))
            {
                MessageBox.Show("Sistem ne može da zapamti igrača! Broj na dresu ne sme da bude trocifren broj! Pokušajte ponovo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Igrac = new Igrac
                {
                    ImeIgraca = uCDodajIgraca.TxtIme.Text,
                    PrezimeIgraca = uCDodajIgraca.TxtPrezime.Text,
                    DrzavaIgraca = uCDodajIgraca.TxtDrzava.Text,
                    DateString = uCDodajIgraca.DtpDatum.Value.ToString(),
                    Pozicija = (Pozicija)(uCDodajIgraca.CbPozicije.SelectedItem),
                    BrojNaDresu = Convert.ToInt32(uCDodajIgraca.TxtBrojNaDresu.Text),
                    Visina = Convert.ToInt32(uCDodajIgraca.TxtVisina.Text),
                    Tim = (Tim)uCDodajIgraca.CbTim.SelectedItem
                };
                if(uCDodajIgraca.TxtTezina.Text.Contains(',') && CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator == ".")
                {
                    Igrac.Tezina = Convert.ToDouble(uCDodajIgraca.TxtTezina.Text.Replace(',', '.'));
                }
                else if (uCDodajIgraca.TxtTezina.Text.Contains('.') && CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator == ",")
                {
                    Igrac.Tezina = Convert.ToDouble(uCDodajIgraca.TxtTezina.Text.Replace('.', ','));
                }
                else
                {
                    Igrac.Tezina = Convert.ToDouble(uCDodajIgraca.TxtTezina.Text);
                }
                Communication.Instance.SendRequestNoResult(Operation.SacuvajIgraca, Igrac);
                MessageBox.Show("Sistem je zapamtio igrača!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcistiPodatke();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da zapamti igrača!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            uCDodajIgraca.DtpDatum.Value = DateTime.Today;
        }
    }
}
