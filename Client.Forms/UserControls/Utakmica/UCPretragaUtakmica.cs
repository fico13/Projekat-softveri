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
    public partial class UCPretragaUtakmica : UserControl
    {
        private NadjiUtakmicuController nadjiUtakmicuController;
        public UCPretragaUtakmica()
        {
            try
            {
                InitializeComponent();
                nadjiUtakmicuController = new NadjiUtakmicuController(this);
                nadjiUtakmicuController.Init();
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
        }

        private void btnPronadjiUtakmice_Click(object sender, EventArgs e)
        {
            nadjiUtakmicuController.NadjiUtakmice();
        }

        private void btnUcitajUtakmicu_Click(object sender, EventArgs e)
        {
            nadjiUtakmicuController.UcitajUtakmicu();
        }

        private void btnPrikaziStatistiku_Click(object sender, EventArgs e)
        {
            nadjiUtakmicuController.PrikaziStatistiku();
        }

        
    }
}
