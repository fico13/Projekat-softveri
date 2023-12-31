﻿using Client.Forms.Dialogs.Igrac;
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

namespace Client.Forms.UserControls.Igrac
{
    public partial class UCPretragaIgraca : UserControl
    {
        private NadjiIgracaController nadjiIgracaController;
        public UCPretragaIgraca()
        {
            try
            {
                InitializeComponent();
                nadjiIgracaController = new NadjiIgracaController(this);
            }
            catch (ServerCommunicationException)
            {

                throw;
            }
           
        }

        private void btnTraziIgraca_Click(object sender, EventArgs e)
        {
            nadjiIgracaController.NadjiIgrace();
        }

        private void btnIzaberiIgraca_Click(object sender, EventArgs e)
        {
            nadjiIgracaController.PrikaziIgraca();
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            nadjiIgracaController.PrikaziStatistiku();
            
        }
    }
}
