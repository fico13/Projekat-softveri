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
    public partial class UCNajboljiAsistenti : UserControl
    {
        private NajboljiAsistentiController najboljiAsistentiController;
        public UCNajboljiAsistenti()
        {
            try
            {
                InitializeComponent();
                najboljiAsistentiController = new NajboljiAsistentiController(this);
                najboljiAsistentiController.Init();
            }
            catch (ServerCommunicationException)
            {

                throw;
            }
            
        }
    }
}
