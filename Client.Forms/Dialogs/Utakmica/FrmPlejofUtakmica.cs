using Client.Forms.GUIController;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.Dialogs.Utakmica
{
    public partial class FrmPlejofUtakmica : Form
    {
        private DodajPlejofUtakmicuController dodajPlejofUtakmicu;

        public FrmPlejofUtakmica(Tim tim1, Tim tim2, string faza)
        {
            InitializeComponent();
            dodajPlejofUtakmicu = new DodajPlejofUtakmicuController(this, tim1, tim2, faza);
            dodajPlejofUtakmicu.Init();
        }

        private void FrmUtakmica_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void btnUcitajIgrace_Click(object sender, EventArgs e)
        {
            dodajPlejofUtakmicu.UcitajIgrace();
        }

        private void btnDodajStatistikuDomacin_Click(object sender, EventArgs e)
        {
            dodajPlejofUtakmicu.DodajStatistikuDomacina();
        }

        private void btnDodajStatistikuGost_Click(object sender, EventArgs e)
        {
            dodajPlejofUtakmicu.DodajStatistikuGosta();
        }

        private void btnSacuvajUtakmicu_Click(object sender, EventArgs e)
        {
            dodajPlejofUtakmicu.SacuvajUtakmicu();
        }
    }
}
