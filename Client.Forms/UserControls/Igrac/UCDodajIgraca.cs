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

namespace Client.Forms.UserControls.Igrac
{
    public partial class UCDodajIgraca : UserControl
    {
        private DodajIgracaController dodajIgracaController;
        public UCDodajIgraca()
        {
            InitializeComponent();
            dodajIgracaController = new DodajIgracaController(this);
            dodajIgracaController.Init();
        }

        private void btnDodajTim_Click(object sender, EventArgs e)
        {
            dodajIgracaController.SacuvajIgraca();
        }
    }
}
