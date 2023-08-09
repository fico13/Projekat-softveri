
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
            this.cbTim = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodajTim
            // 
            this.btnDodajTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajTim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodajTim.BackgroundImage")));
            this.btnDodajTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDodajTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajTim.Location = new System.Drawing.Point(214, 423);
            this.btnDodajTim.Name = "btnDodajTim";
            this.btnDodajTim.Size = new System.Drawing.Size(214, 36);
            this.btnDodajTim.TabIndex = 13;
            this.btnDodajTim.Text = "Dodaj igrača";
            this.btnDodajTim.UseVisualStyleBackColor = true;
            this.btnDodajTim.Click += new System.EventHandler(this.btnDodajTim_Click);
            // 
            // cbPozicije
            // 
            this.cbPozicije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPozicije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPozicije.FormattingEnabled = true;
            this.cbPozicije.Location = new System.Drawing.Point(214, 171);
            this.cbPozicije.Name = "cbPozicije";
            this.cbPozicije.Size = new System.Drawing.Size(214, 28);
            this.cbPozicije.TabIndex = 12;
            // 
            // txtDrzava
            // 
            this.txtDrzava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDrzava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrzava.Location = new System.Drawing.Point(214, 121);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(214, 27);
            this.txtDrzava.TabIndex = 11;
            this.txtDrzava.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.Location = new System.Drawing.Point(214, 21);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(214, 27);
            this.txtIme.TabIndex = 10;
            this.txtIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Chocolate;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pozicija";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Chocolate;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Država";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.Location = new System.Drawing.Point(214, 71);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(214, 27);
            this.txtPrezime.TabIndex = 15;
            this.txtPrezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Chocolate;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Prezime";
            // 
            // txtBrojNaDresu
            // 
            this.txtBrojNaDresu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojNaDresu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojNaDresu.Location = new System.Drawing.Point(214, 222);
            this.txtBrojNaDresu.Name = "txtBrojNaDresu";
            this.txtBrojNaDresu.Size = new System.Drawing.Size(214, 27);
            this.txtBrojNaDresu.TabIndex = 17;
            this.txtBrojNaDresu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Chocolate;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Broj na dresu";
            // 
            // txtVisina
            // 
            this.txtVisina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVisina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisina.Location = new System.Drawing.Point(214, 272);
            this.txtVisina.Name = "txtVisina";
            this.txtVisina.Size = new System.Drawing.Size(214, 27);
            this.txtVisina.TabIndex = 19;
            this.txtVisina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Chocolate;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Visina (cm)";
            // 
            // txtTezina
            // 
            this.txtTezina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTezina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTezina.Location = new System.Drawing.Point(214, 322);
            this.txtTezina.Name = "txtTezina";
            this.txtTezina.Size = new System.Drawing.Size(214, 27);
            this.txtTezina.TabIndex = 21;
            this.txtTezina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Chocolate;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Težina (kg)";
            // 
            // cbTim
            // 
            this.cbTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTim.FormattingEnabled = true;
            this.cbTim.Location = new System.Drawing.Point(214, 372);
            this.cbTim.Name = "cbTim";
            this.cbTim.Size = new System.Drawing.Size(214, 28);
            this.cbTim.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Chocolate;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tim";
            // 
            // UCDodajIgraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.cbTim);
            this.Controls.Add(this.label8);
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
            this.DoubleBuffered = true;
            this.Name = "UCDodajIgraca";
            this.Size = new System.Drawing.Size(519, 480);
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
