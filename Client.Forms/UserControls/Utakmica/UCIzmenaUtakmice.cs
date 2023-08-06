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
    public partial class UCIzmenaUtakmice : UserControl
    {
        private IzmeniUtakmicuController izmeniUtakmicuController;
        public UCIzmenaUtakmice()
        {
            InitializeComponent();
            izmeniUtakmicuController = new IzmeniUtakmicuController(this);
            izmeniUtakmicuController.Init();
        }

        private void btnPronadjiUtakmice_Click(object sender, EventArgs e)
        {
            izmeniUtakmicuController.NadjiUtakmice();
        }

        private void btnUcitajUtakmicu_Click(object sender, EventArgs e)
        {
            izmeniUtakmicuController.UcitajUtakmicu();
        }

        private void btnPrikaziStatistiku_Click(object sender, EventArgs e)
        {
            izmeniUtakmicuController.PrikaziStatistiku();
        }

        private void btnUcitajStatistiku_Click(object sender, EventArgs e)
        {
            izmeniUtakmicuController.UcitajStatistiku();
        }

        private void btnIzmeniStatistiku_Click(object sender, EventArgs e)
        {
            izmeniUtakmicuController.IzmeniStatistiku();
        }

        private void btnIzmeniUtakmicu_Click(object sender, EventArgs e)
        {
            izmeniUtakmicuController.IzmeniUtakmicu();
        }
    }
}
