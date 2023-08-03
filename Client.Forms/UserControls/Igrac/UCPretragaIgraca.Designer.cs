
using System.Windows.Forms;

namespace Client.Forms.UserControls.Igrac
{
    partial class UCPretragaIgraca
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPretragaIgraca));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPozicija = new System.Windows.Forms.TextBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTezina = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVisina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBrojNaDresu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDrzava = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnIzaberiIgraca = new System.Windows.Forms.Button();
            this.dgvIgraci = new System.Windows.Forms.DataGridView();
            this.btnTraziIgraca = new System.Windows.Forms.Button();
            this.txtPrezimeIgraca = new System.Windows.Forms.TextBox();
            this.txtImeIgraca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtPozicija);
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTezina);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtVisina);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBrojNaDresu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDrzava);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(405, 493);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 462);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Igrač";
            // 
            // txtPozicija
            // 
            this.txtPozicija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPozicija.Location = new System.Drawing.Point(158, 198);
            this.txtPozicija.Name = "txtPozicija";
            this.txtPozicija.ReadOnly = true;
            this.txtPozicija.Size = new System.Drawing.Size(179, 22);
            this.txtPozicija.TabIndex = 42;
            // 
            // txtTim
            // 
            this.txtTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTim.Location = new System.Drawing.Point(158, 407);
            this.txtTim.Name = "txtTim";
            this.txtTim.ReadOnly = true;
            this.txtTim.Size = new System.Drawing.Size(179, 22);
            this.txtTim.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Tim";
            // 
            // txtTezina
            // 
            this.txtTezina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTezina.Location = new System.Drawing.Point(158, 357);
            this.txtTezina.Name = "txtTezina";
            this.txtTezina.ReadOnly = true;
            this.txtTezina.Size = new System.Drawing.Size(179, 22);
            this.txtTezina.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Težina";
            // 
            // txtVisina
            // 
            this.txtVisina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVisina.Location = new System.Drawing.Point(158, 304);
            this.txtVisina.Name = "txtVisina";
            this.txtVisina.ReadOnly = true;
            this.txtVisina.Size = new System.Drawing.Size(179, 22);
            this.txtVisina.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Visina";
            // 
            // txtBrojNaDresu
            // 
            this.txtBrojNaDresu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojNaDresu.Location = new System.Drawing.Point(158, 251);
            this.txtBrojNaDresu.Name = "txtBrojNaDresu";
            this.txtBrojNaDresu.ReadOnly = true;
            this.txtBrojNaDresu.Size = new System.Drawing.Size(179, 22);
            this.txtBrojNaDresu.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Broj na dresu";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrezime.Location = new System.Drawing.Point(158, 90);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(179, 22);
            this.txtPrezime.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Prezime";
            // 
            // txtDrzava
            // 
            this.txtDrzava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDrzava.Location = new System.Drawing.Point(158, 143);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.ReadOnly = true;
            this.txtDrzava.Size = new System.Drawing.Size(179, 22);
            this.txtDrzava.TabIndex = 30;
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.Location = new System.Drawing.Point(158, 37);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(179, 22);
            this.txtIme.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Pozicija";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Država";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Ime";
            // 
            // btnIzaberiIgraca
            // 
            this.btnIzaberiIgraca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzaberiIgraca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIzaberiIgraca.BackgroundImage")));
            this.btnIzaberiIgraca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIzaberiIgraca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzaberiIgraca.Location = new System.Drawing.Point(405, 428);
            this.btnIzaberiIgraca.Name = "btnIzaberiIgraca";
            this.btnIzaberiIgraca.Size = new System.Drawing.Size(199, 41);
            this.btnIzaberiIgraca.TabIndex = 31;
            this.btnIzaberiIgraca.Text = "Izaberi igrača";
            this.btnIzaberiIgraca.UseVisualStyleBackColor = true;
            this.btnIzaberiIgraca.Click += new System.EventHandler(this.btnIzaberiIgraca_Click);
            // 
            // dgvIgraci
            // 
            this.dgvIgraci.AllowUserToAddRows = false;
            this.dgvIgraci.AllowUserToDeleteRows = false;
            this.dgvIgraci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvIgraci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgraci.Location = new System.Drawing.Point(3, 175);
            this.dgvIgraci.Name = "dgvIgraci";
            this.dgvIgraci.ReadOnly = true;
            this.dgvIgraci.RowHeadersWidth = 51;
            this.dgvIgraci.RowTemplate.Height = 24;
            this.dgvIgraci.Size = new System.Drawing.Size(1164, 227);
            this.dgvIgraci.TabIndex = 30;
            // 
            // btnTraziIgraca
            // 
            this.btnTraziIgraca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTraziIgraca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTraziIgraca.BackgroundImage")));
            this.btnTraziIgraca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTraziIgraca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraziIgraca.Location = new System.Drawing.Point(407, 108);
            this.btnTraziIgraca.Name = "btnTraziIgraca";
            this.btnTraziIgraca.Size = new System.Drawing.Size(199, 41);
            this.btnTraziIgraca.TabIndex = 29;
            this.btnTraziIgraca.Text = "Nađi igrača";
            this.btnTraziIgraca.UseVisualStyleBackColor = true;
            this.btnTraziIgraca.Click += new System.EventHandler(this.btnTraziIgraca_Click);
            // 
            // txtPrezimeIgraca
            // 
            this.txtPrezimeIgraca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrezimeIgraca.Location = new System.Drawing.Point(645, 73);
            this.txtPrezimeIgraca.Name = "txtPrezimeIgraca";
            this.txtPrezimeIgraca.Size = new System.Drawing.Size(156, 22);
            this.txtPrezimeIgraca.TabIndex = 28;
            // 
            // txtImeIgraca
            // 
            this.txtImeIgraca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtImeIgraca.Location = new System.Drawing.Point(407, 73);
            this.txtImeIgraca.Name = "txtImeIgraca";
            this.txtImeIgraca.Size = new System.Drawing.Size(156, 22);
            this.txtImeIgraca.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Prezime igrača";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ime igrača";
            // 
            // UCPretragaIgraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIzaberiIgraca);
            this.Controls.Add(this.dgvIgraci);
            this.Controls.Add(this.btnTraziIgraca);
            this.Controls.Add(this.txtPrezimeIgraca);
            this.Controls.Add(this.txtImeIgraca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCPretragaIgraca";
            this.Size = new System.Drawing.Size(1200, 1024);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTezina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVisina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBrojNaDresu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDrzava;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnIzaberiIgraca;
        private System.Windows.Forms.DataGridView dgvIgraci;
        private System.Windows.Forms.Button btnTraziIgraca;
        private System.Windows.Forms.TextBox txtPrezimeIgraca;
        private System.Windows.Forms.TextBox txtImeIgraca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPozicija;

        public TextBox TxtTezina { get => txtTezina; set => txtTezina = value; }
        public TextBox TxtVisina { get => txtVisina; set => txtVisina = value; }
        public TextBox TxtBrojNaDresu { get => txtBrojNaDresu; set => txtBrojNaDresu = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtDrzava { get => txtDrzava; set => txtDrzava = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public DataGridView DgvIgraci { get => dgvIgraci; set => dgvIgraci = value; }
        public TextBox TxtPrezimeIgraca { get => txtPrezimeIgraca; set => txtPrezimeIgraca = value; }
        public TextBox TxtImeIgraca { get => txtImeIgraca; set => txtImeIgraca = value; }
        public TextBox TxtTim { get => txtTim; set => txtTim = value; }
        public TextBox TxtPozicija { get => txtPozicija; set => txtPozicija = value; }
    }
}
