﻿using Client.Forms.UserControls.Dvorana;
using Client.Forms.UserControls.Igrac;
using Client.Forms.UserControls.Tim;
using Client.Forms.UserControls.Utakmica;
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
            ChangePanel(new UCDodajDvoranu());
        }

        private void dodajTimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCDodajTim());
        }

        private void nadjiTimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCNadjiTim());
        }

        private void dodajIgračaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCDodajIgraca());
        }

        private void izmeniIgračaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCIzmeniIgraca());
        }

        private void pretragaIgračaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCPretragaIgraca());
        }

        private void dodajUtakmicuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCDodajUtakmicu());
        }
        private void ChangePanel(UserControl userControl)
        {
            pnlMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(userControl);
        }

        private void izmeniUtakmicuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCPretragaUtakmica());
        }

        private void izmeniUtakmicuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCIzmenaUtakmice());
        }
    }
}
