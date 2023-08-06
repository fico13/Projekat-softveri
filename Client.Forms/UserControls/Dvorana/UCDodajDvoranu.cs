﻿using Client.Forms.GUIController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.UserControls.Dvorana
{
    public partial class UCDodajDvoranu : UserControl
    {
        private DodajDvoranuController dodajDvoranuController;
        public UCDodajDvoranu()
        {
            InitializeComponent();
            dodajDvoranuController = new DodajDvoranuController(this);
        }

        private void btnDodajDvoranu_Click(object sender, EventArgs e)
        {
            dodajDvoranuController.DodajDvoranu();
        }
    }
}
