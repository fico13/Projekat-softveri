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

namespace Client.Forms.Dialogs.Utakmica
{
    public partial class FrmRegularUtakmica : Form
    {
        private DodajRegularUtakmicuController dodajRegularUtakmicuController;
        public FrmRegularUtakmica()
        {
            try
            {
                InitializeComponent();
                dodajRegularUtakmicuController = new DodajRegularUtakmicuController(this);
                dodajRegularUtakmicuController.Init();
            }
            catch (ServerCommunicationException)
            {

                throw;
            }
            
        }

        private void FrmRegularUtakmica_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void btnUcitajIgrace_Click(object sender, EventArgs e)
        {
            dodajRegularUtakmicuController.UcitajIgrace();
        }

        private void btnDodajStatistikuDomacin_Click(object sender, EventArgs e)
        {
            dodajRegularUtakmicuController.DodajStatsitkuDomacina();
        }

        private void btnDodajStatistikuGost_Click(object sender, EventArgs e)
        {
            dodajRegularUtakmicuController.DodajStatsitkuGosta();
        }

        private void btnSacuvajUtakmicu_Click(object sender, EventArgs e)
        {
            dodajRegularUtakmicuController.DodajUtakmicu();
        }
    }
}
