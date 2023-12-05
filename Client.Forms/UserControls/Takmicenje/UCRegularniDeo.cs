using Client.Forms.Exceptions;
using Client.Forms.GUIController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.UserControls.Takmicenje
{
    public partial class UCRegularniDeo : UserControl
    {
        private SacuvajTakmicenjeController sacuvajTakmicenjeController;
        public UCRegularniDeo()
        {
            try
            {
                InitializeComponent();
                sacuvajTakmicenjeController = new SacuvajTakmicenjeController(this);
                sacuvajTakmicenjeController.Init();
            }
            catch (ServerCommunicationException)
            {

                throw;
            }
            
        }

        private void btnDodajTim_Click(object sender, EventArgs e)
        {
            sacuvajTakmicenjeController.DodajTimULigu();
        }

        private void btnDodajUtakmicu_Click(object sender, EventArgs e)
        {
            sacuvajTakmicenjeController.DodajUtakmice();
        }

        private void btnSacuvajTakmicenje_Click(object sender, EventArgs e)
        {
            sacuvajTakmicenjeController.SacuvajTakmicenje();
        }
    }
}
