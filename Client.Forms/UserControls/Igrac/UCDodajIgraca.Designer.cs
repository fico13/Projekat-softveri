
using System.Windows.Forms;

namespace Client.Forms.UserControls.Igrac
{
    partial class UCDodajIgraca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDodajIgraca));
            this.btnDodajTim = new System.Windows.Forms.Button();
            this.cbPozicije = new System.Windows.Forms.ComboBox();
            this.txtDrzava = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrojNaDresu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVisina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTezina = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbTim = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajTim
            // 
            this.btnDodajTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajTim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodajTim.BackgroundImage")));
            this.btnDodajTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDodajTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajTim.Location = new System.Drawing.Point(185, 469);
            this.btnDodajTim.Name = "btnDodajTim";
            this.btnDodajTim.Size = new System.Drawing.Size(179, 36);
            this.btnDodajTim.TabIndex = 13;
            this.btnDodajTim.Text = "Dodaj igrača";
            this.btnDodajTim.UseVisualStyleBackColor = true;
            this.btnDodajTim.Click += new System.EventHandler(this.btnDodajTim_Click);
            // 
            // cbPozicije
            // 
            this.cbPozicije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPozicije.FormattingEnabled = true;
            this.cbPozicije.Location = new System.Drawing.Point(185, 217);
            this.cbPozicije.Name = "cbPozicije";
            this.cbPozicije.Size = new System.Drawing.Size(179, 24);
            this.cbPozicije.TabIndex = 12;
            // 
            // txtDrzava
            // 
            this.txtDrzava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDrzava.Location = new System.Drawing.Point(185, 166);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(179, 22);
            this.txtDrzava.TabIndex = 11;
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.Location = new System.Drawing.Point(185, 64);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(179, 22);
            this.txtIme.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pozicija";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Država";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrezime.Location = new System.Drawing.Point(185, 115);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(179, 22);
            this.txtPrezime.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Prezime";
            // 
            // txtBrojNaDresu
            // 
            this.txtBrojNaDresu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojNaDresu.Location = new System.Drawing.Point(185, 270);
            this.txtBrojNaDresu.Name = "txtBrojNaDresu";
            this.txtBrojNaDresu.Size = new System.Drawing.Size(179, 22);
            this.txtBrojNaDresu.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Broj na dresu";
            // 
            // txtVisina
            // 
            this.txtVisina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVisina.Location = new System.Drawing.Point(185, 321);
            this.txtVisina.Name = "txtVisina";
            this.txtVisina.Size = new System.Drawing.Size(179, 22);
            this.txtVisina.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Visina";
            // 
            // txtTezina
            // 
            this.txtTezina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTezina.Location = new System.Drawing.Point(185, 372);
            this.txtTezina.Name = "txtTezina";
            this.txtTezina.Size = new System.Drawing.Size(179, 22);
            this.txtTezina.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Težina";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(462, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 408);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // cbTim
            // 
            this.cbTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTim.FormattingEnabled = true;
            this.cbTim.Location = new System.Drawing.Point(185, 423);
            this.cbTim.Name = "cbTim";
            this.cbTim.Size = new System.Drawing.Size(179, 24);
            this.cbTim.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tim";
            // 
            // UCDodajIgraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbTim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTezina);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVisina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBrojNaDresu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDodajTim);
            this.Controls.Add(this.cbPozicije);
            this.Controls.Add(this.txtDrzava);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCDodajIgraca";
            this.Size = new System.Drawing.Size(988, 557);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajTim;
        private System.Windows.Forms.ComboBox cbPozicije;
        private System.Windows.Forms.TextBox txtDrzava;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrojNaDresu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVisina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTezina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbTim;
        private System.Windows.Forms.Label label8;

        public ComboBox CbPozicije { get => cbPozicije; set => cbPozicije = value; }
        public TextBox TxtDrzava { get => txtDrzava; set => txtDrzava = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtBrojNaDresu { get => txtBrojNaDresu; set => txtBrojNaDresu = value; }
        public TextBox TxtVisina { get => txtVisina; set => txtVisina = value; }
        public TextBox TxtTezina { get => txtTezina; set => txtTezina = value; }
        public ComboBox CbTim { get => cbTim; set => cbTim = value; }
    }
}
