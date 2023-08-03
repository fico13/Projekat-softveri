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
    public partial class UCIzmeniIgraca : UserControl
    {
        private IzmeniIgracaController izmeniIgracaController;
        public UCIzmeniIgraca()
        {
            InitializeComponent();
            izmeniIgracaController = new IzmeniIgracaController(this);
            izmeniIgracaController.Init();
        }

        private void btnTraziIgraca_Click(object sender, EventArgs e)
        {
            izmeniIgracaController.NadjiIgrace();
        }

        private void btnIzaberiIgraca_Click(object sender, EventArgs e)
        {
            izmeniIgracaController.UcitajIgraca();
        }

        private void btnIzmeniIgraca_Click(object sender, EventArgs e)
        {
            izmeniIgracaController.IzmeniIgraca();
        }
    }
}
