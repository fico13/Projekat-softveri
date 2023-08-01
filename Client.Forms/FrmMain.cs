using Client.Forms.UserControls.Dvorana;
using Client.Forms.UserControls.Igrac;
using Client.Forms.UserControls.Tim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void dodajDvoranuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCDodajDvoranu uCDodajDvoranu = new UCDodajDvoranu();
            uCDodajDvoranu.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uCDodajDvoranu);
        }

        private void dodajTimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCDodajTim uCDodajTim = new UCDodajTim();
            uCDodajTim.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uCDodajTim);
        }

        private void nadjiTimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCNadjiTim uCNadjiTim = new UCNadjiTim();
            uCNadjiTim.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uCNadjiTim);
        }

        private void dodajIgračaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCDodajIgraca uCDodajIgraca = new UCDodajIgraca();
            uCDodajIgraca.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uCDodajIgraca);
        }

        private void nađiIgračaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCIzmeniIgraca uCIzmeniIgraca = new UCIzmeniIgraca();
            uCIzmeniIgraca.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uCIzmeniIgraca);
        }
    }
}
