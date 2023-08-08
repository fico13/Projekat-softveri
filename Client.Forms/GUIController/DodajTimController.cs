using Client.Forms.Exceptions;
using Client.Forms.GUIHelper;
using Client.Forms.ServerCommunication;
using Client.Forms.UserControls.Tim;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Client.Forms.GUIController
{
    public class DodajTimController
    {
        private UCDodajTim uCDodajTim;

        public DodajTimController(UCDodajTim uCDodajTim)
        {
            this.uCDodajTim = uCDodajTim;
        }

        internal void Init()
        {
            uCDodajTim.CbDvorane.DataSource = Communication.Instance.SendRequestGetResult<List<Dvorana>>(Operation.VratiSveDvorane);
        }

        internal void SacuvajTim()
        {
            if(UserControlsHelper.EmptyText(uCDodajTim.TxtIme) || UserControlsHelper.EmptyText(uCDodajTim.TxtDrzava))
            {
                MessageBox.Show("Sistem ne može da zapamti tim! Niste uneli sve potrebne podatke! Pokušajte ponovo");
                return;
            }

            if(UserControlsHelper.ComboBoxValidation(uCDodajTim.CbDvorane))
            {
                MessageBox.Show("Sistem ne može da zapamti tim! Niste lepo odabrali dvoranu u combo box-u! Pokušajte ponovo!");
                return;
            }
            if (UserControlsHelper.WordValidation(uCDodajTim.TxtIme))
            {
                MessageBox.Show("Sistem ne može da zapamti tim! Ime tima ne sme da sadrži broj u nazivu! Pokušajte ponovo!");
                return;
            }
            if (UserControlsHelper.WordValidation(uCDodajTim.TxtDrzava))
            {
                MessageBox.Show("Sistem ne može da zapamti tim! Država ne sme da sadrži broj u nazivu! Pokušajte ponovo!");
                return;
            }
            try
            {
                Tim tim = new Tim
                {
                    Ime = uCDodajTim.TxtIme.Text,
                    Drzava = uCDodajTim.TxtDrzava.Text,
                    Dvorana = (Dvorana)uCDodajTim.CbDvorane.SelectedItem
                };
                Communication.Instance.SendRequestNoResult(Operation.SacuvajTim, tim);
                MessageBox.Show("Sistem je zapamtio tim!");
                OcistiPodatke();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da zapamti tim!");
                throw;
            }
        }

        private void OcistiPodatke()
        {
            uCDodajTim.TxtIme.Clear();
            uCDodajTim.TxtDrzava.Clear();
        }
    }
}
