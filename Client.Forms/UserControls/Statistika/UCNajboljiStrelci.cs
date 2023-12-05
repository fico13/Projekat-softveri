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

namespace Client.Forms.UserControls.Statistika
{
    public partial class UCNajboljiStrelci : UserControl
    {
        private NajboljiStrelciController najboljiStrelciController;
        public UCNajboljiStrelci()
        {
            try
            {
                InitializeComponent();
                najboljiStrelciController = new NajboljiStrelciController(this);
                najboljiStrelciController.Init();
            }
            catch (ServerCommunicationException)
            {

                throw;
            }
            
        }
    }
}
