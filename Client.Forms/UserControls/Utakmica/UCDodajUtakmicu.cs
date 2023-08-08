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

namespace Client.Forms.UserControls.Utakmica
{
    public partial class UCDodajUtakmicu : UserControl
    {
        private DodajUtakmicuController dodajUtakmicuController;
        public UCDodajUtakmicu()
        {
            try
            {
                InitializeComponent();
                dodajUtakmicuController = new DodajUtakmicuController(this);
                dodajUtakmicuController.Init();
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
        }

        private void btnUcitajIgrace_Click(object sender, EventArgs e)
        {
            dodajUtakmicuController.UcitajIgrace();
        }

        private void btnDodajStatistikuDomacin_Click(object sender, EventArgs e)
        {
            dodajUtakmicuController.DodajStatistikuDomacina();
        }

        private void btnDodajStatistikuGost_Click(object sender, EventArgs e)
        {
            dodajUtakmicuController.DodajStatistikuGosta();
        }

        private void btnSacuvajUtakmicu_Click(object sender, EventArgs e)
        {
            dodajUtakmicuController.SacuvajUtakmicu();
        }
    }
}
