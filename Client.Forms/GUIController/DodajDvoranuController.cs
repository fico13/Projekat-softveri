using Client.Forms.GUIHelper;
using Client.Forms.ServerCommunication;
using Client.Forms.UserControls.Dvorana;
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
    public class DodajDvoranuController
    {
        private UCDodajDvoranu uCDodajDvoranu;

        public DodajDvoranuController(UCDodajDvoranu uCDodajDvoranu)
        {
            this.uCDodajDvoranu = uCDodajDvoranu;
        }

        internal void DodajDvoranu()
        {
            if(UserControlsHelper.EmptyText(uCDodajDvoranu.TxtImeDvorane) || UserControlsHelper.EmptyText(uCDodajDvoranu.TxtDrzava) || UserControlsHelper.EmptyText(uCDodajDvoranu.TxtKapacitet))
            {
                MessageBox.Show("Sistem ne moze da zapamti dvoranu! Niste uneli sve potrebne podatke, pokusajte ponovo!");
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCDodajDvoranu.TxtKapacitet))
            {
                MessageBox.Show("Sistem ne moze da zapamti dvoranu! Kapacitet dvorane mora biti pozitivan broj! Pokusajte ponovo!");
                return;
            }
            try
            {
                Dvorana dvorana = new Dvorana
                {
                    Ime = uCDodajDvoranu.TxtImeDvorane.Text,
                    Drzava = uCDodajDvoranu.TxtDrzava.Text,
                    Kapacitet = Convert.ToInt32(uCDodajDvoranu.TxtKapacitet.Text)
                };
                Communication.Instance.SendRequestNoResult(Operation.SacuvajDvoranu, dvorana);
                MessageBox.Show("Sistem je zapamtio dvoranu");
                OcistiPodatke(uCDodajDvoranu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne moze da zapamti dvoranu " + ex.Message);
            }
        }

        private void OcistiPodatke(UCDodajDvoranu uCDodajDvoranu)
        {
            uCDodajDvoranu.TxtImeDvorane.Clear();
            uCDodajDvoranu.TxtDrzava.Clear();
            uCDodajDvoranu.TxtKapacitet.Clear();
        }
    }
}
