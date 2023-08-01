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
        internal void DodajDvoranu(UCDodajDvoranu uCDodajDvoranu)
        {
            if(UserControlsHelper.EmptyText(uCDodajDvoranu.TxtImeDvorane) || UserControlsHelper.EmptyText(uCDodajDvoranu.TxtDrzava) || UserControlsHelper.EmptyText(uCDodajDvoranu.TxtKapacitet))
            {
                MessageBox.Show("Niste uneli sve potrebne podatke, pokusajte ponovo");
                return;
            }
            if (UserControlsHelper.IntegerValidation(uCDodajDvoranu.TxtKapacitet))
            {
                MessageBox.Show("Kapacitet dvorane mora biti ceo broj! Pokusajte ponovo!");
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
                if(dvorana.Kapacitet <= 0)
                {
                    MessageBox.Show("Kapacitet dvorane mora biti veci od 0! Pokusajte ponovo");
                    return;
                }
                Communication.Instance.SendRequestNoResult(Operation.SacuvajDvoranu, dvorana);
                MessageBox.Show("Sistem je zapamtio dvoranu");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne moze da sacuva dvoranu " + ex.Message);
            }
        }
    }
}
