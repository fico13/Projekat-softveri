using Client.Forms.Dialogs.Utakmica;
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
    public partial class UCPlejof : UserControl
    {
        private PlejofController plejofController; 
        public UCPlejof()
        {
            InitializeComponent();
            plejofController = new PlejofController(this);
        }

        private void btnDodajA_Click(object sender, EventArgs e)
        {
            plejofController.DodajUtakmicuA();
        }

        private void btnDodajB_Click(object sender, EventArgs e)
        {
            plejofController.DodajUtakmicuB();
        }

        private void btnDodajC_Click(object sender, EventArgs e)
        {
            plejofController.DodajUtakmicuC();

        }

        private void btnDodajD_Click(object sender, EventArgs e)
        {
            plejofController.DodajUtakmicuD();
        }

        private void btnDodajE_Click(object sender, EventArgs e)
        {
            plejofController.DodajUtakmicuE();
        }
    }
}
