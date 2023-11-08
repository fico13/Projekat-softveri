using Client.Forms.GUIController;
using Client.Forms.UserControls.Igrac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.Dialogs.Igrac
{
    public partial class FrmStatistikaIgraca : Form
    {
        private PrikaziStatistikuController prikaziStatistikuController;
        public FrmStatistikaIgraca(Common.Domain.Igrac izabraniIgrac)
        {
            InitializeComponent();
            prikaziStatistikuController = new PrikaziStatistikuController(this, izabraniIgrac);
        }


        private void FrmStatistikaIgraca_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
