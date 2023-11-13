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
            InitializeComponent();
            sacuvajTakmicenjeController = new SacuvajTakmicenjeController(this);
        }

        private void btnDodajTim_Click(object sender, EventArgs e)
        {
            sacuvajTakmicenjeController.DodajTimULigu();
        }

        private void btnSacuvajTakmicenje_Click(object sender, EventArgs e)
        {
            sacuvajTakmicenjeController.SacuvajTakmicenje();
        }

        private void btnNapraviTakmicenje_Click(object sender, EventArgs e)
        {
            sacuvajTakmicenjeController.DodajUtakmice();
        }

        private void btnUcitajIgrace_Click(object sender, EventArgs e)
        {
            sacuvajTakmicenjeController.UcitajIgrace();
        }

        private void btnDodajStatistikuDomacin_Click(object sender, EventArgs e)
        {
            sacuvajTakmicenjeController.DodajStatistikuDomacina();
        }

        private void btnDodajStatistikuGost_Click(object sender, EventArgs e)
        {
            sacuvajTakmicenjeController.DodajStatistikuGosta();
        }

        private void btnSacuvajUtakmicu_Click(object sender, EventArgs e)
        {
            sacuvajTakmicenjeController.DodajUtakmicu();
        }
    }
}
