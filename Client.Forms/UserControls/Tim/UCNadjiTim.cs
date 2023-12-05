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

namespace Client.Forms.UserControls.Tim
{
    public partial class UCNadjiTim : UserControl
    {
        private NadjiTimController nadjiTimController;
        public UCNadjiTim()
        {
            try
            {
                InitializeComponent();
                nadjiTimController = new NadjiTimController(this);
            }
            catch (ServerCommunicationException)
            {

                throw;
            }
            
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            nadjiTimController.NadjiTim();
        }

        private void btnPrikaziTim_Click(object sender, EventArgs e)
        {
            nadjiTimController.PrikaziTim();
        }
    }
}
