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
    public partial class UCNajboljiSkakaci : UserControl
    {
        private NajboljiSkakaciController najboljiSkakaciController;
        public UCNajboljiSkakaci()
        {
            try
            {
                InitializeComponent();
                najboljiSkakaciController = new NajboljiSkakaciController(this);
                najboljiSkakaciController.Init();
            }
            catch (ServerCommunicationException)
            {

                throw;
            }
            
        }
    }
}
