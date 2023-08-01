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

namespace Client.Forms.UserControls.Tim
{
    public partial class UCDodajTim : UserControl
    {
        private DodajTimController dodajTimController;
        public UCDodajTim()
        {
            InitializeComponent();
            dodajTimController = new DodajTimController(this);
            dodajTimController.Init();
        }

        private void btnDodajTim_Click(object sender, EventArgs e)
        {
            dodajTimController.SacuvajTim();
        }
    }
}
