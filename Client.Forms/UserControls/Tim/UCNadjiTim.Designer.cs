
using System.Windows.Forms;

namespace Client.Forms.UserControls.Tim
{
    partial class UCNadjiTim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNadjiTim));
            this.dgvTimovi = new System.Windows.Forms.DataGridView();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtDrzava = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDvorana = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBodovi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBrojPoraza = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBrojPobeda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDrzavaTima = new System.Windows.Forms.TextBox();
            this.btnPrikaziTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTimovi
            // 
            this.dgvTimovi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTimovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimovi.Location = new System.Drawing.Point(20, 207);
            this.dgvTimovi.Name = "dgvTimovi";
            this.dgvTimovi.RowHeadersWidth = 51;
            this.dgvTimovi.RowTemplate.Height = 24;
            this.dgvTimovi.Size = new System.Drawing.Size(884, 226);
            this.dgvTimovi.TabIndex = 12;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPretrazi.BackgroundImage")));
            this.btnPretrazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPretrazi.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPretrazi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPretrazi.Location = new System.Drawing.Point(482, 146);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(178, 38);
            this.btnPretrazi.TabIndex = 11;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtDrzava
            // 
            this.txtDrzava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDrzava.Location = new System.Drawing.Point(249, 162);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(178, 22);
            this.txtDrzava.TabIndex = 10;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Location = new System.Drawing.Point(20, 162);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(178, 22);
            this.txtNaziv.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pronadji tim po državi";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pronadji tim po nazivu";
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.Location = new System.Drawing.Point(175, 65);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(178, 22);
            this.txtIme.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ime";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDvorana);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBodovi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBrojPoraza);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBrojPobeda);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDrzavaTima);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Location = new System.Drawing.Point(1325, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 344);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije o timu";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Dvorana";
            // 
            // txtDvorana
            // 
            this.txtDvorana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDvorana.Location = new System.Drawing.Point(175, 270);
            this.txtDvorana.Name = "txtDvorana";
            this.txtDvorana.ReadOnly = true;
            this.txtDvorana.Size = new System.Drawing.Size(178, 22);
            this.txtDvorana.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Bodovi";
            // 
            // txtBodovi
            // 
            this.txtBodovi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBodovi.Location = new System.Drawing.Point(175, 229);
            this.txtBodovi.Name = "txtBodovi";
            this.txtBodovi.ReadOnly = true;
            this.txtBodovi.Size = new System.Drawing.Size(178, 22);
            this.txtBodovi.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Broj poraza";
            // 
            // txtBrojPoraza
            // 
            this.txtBrojPoraza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojPoraza.Location = new System.Drawing.Point(175, 188);
            this.txtBrojPoraza.Name = "txtBrojPoraza";
            this.txtBrojPoraza.ReadOnly = true;
            this.txtBrojPoraza.Size = new System.Drawing.Size(178, 22);
            this.txtBrojPoraza.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Broj pobeda";
            // 
            // txtBrojPobeda
            // 
            this.txtBrojPobeda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojPobeda.Location = new System.Drawing.Point(175, 147);
            this.txtBrojPobeda.Name = "txtBrojPobeda";
            this.txtBrojPobeda.ReadOnly = true;
            this.txtBrojPobeda.Size = new System.Drawing.Size(178, 22);
            this.txtBrojPobeda.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Drzava";
            // 
            // txtDrzavaTima
            // 
            this.txtDrzavaTima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDrzavaTima.Location = new System.Drawing.Point(175, 106);
            this.txtDrzavaTima.Name = "txtDrzavaTima";
            this.txtDrzavaTima.ReadOnly = true;
            this.txtDrzavaTima.Size = new System.Drawing.Size(178, 22);
            this.txtDrzavaTima.TabIndex = 16;
            // 
            // btnPrikaziTim
            // 
            this.btnPrikaziTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikaziTim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrikaziTim.BackgroundImage")));
            this.btnPrikaziTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrikaziTim.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPrikaziTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrikaziTim.Location = new System.Drawing.Point(20, 458);
            this.btnPrikaziTim.Name = "btnPrikaziTim";
            this.btnPrikaziTim.Size = new System.Drawing.Size(178, 38);
            this.btnPrikaziTim.TabIndex = 16;
            this.btnPrikaziTim.Text = "Prikazi tim";
            this.btnPrikaziTim.UseVisualStyleBackColor = true;
            this.btnPrikaziTim.Click += new System.EventHandler(this.btnPrikaziTim_Click);
            // 
            // UCNadjiTim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnPrikaziTim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTimovi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtDrzava);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "UCNadjiTim";
            this.Size = new System.Drawing.Size(1800, 558);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimovi;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtDrzava;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TextBox txtIme;
        private Label label3;
        private GroupBox groupBox1;
        private Label label8;
        private TextBox txtDvorana;
        private Label label7;
        private TextBox txtBodovi;
        private Label label6;
        private TextBox txtBrojPoraza;
        private Label label5;
        private TextBox txtBrojPobeda;
        private Label label4;
        private TextBox txtDrzavaTima;
        private Button btnPrikaziTim;

        public DataGridView DgvTimovi { get => dgvTimovi; set => dgvTimovi = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public TextBox TxtDrzava { get => txtDrzava; set => txtDrzava = value; }
        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtDvorana { get => txtDvorana; set => txtDvorana = value; }
        public TextBox TxtBodovi { get => txtBodovi; set => txtBodovi = value; }
        public TextBox TxtBrojPoraza { get => txtBrojPoraza; set => txtBrojPoraza = value; }
        public TextBox TxtBrojPobeda { get => txtBrojPobeda; set => txtBrojPobeda = value; }
        public TextBox TxtDrzavaTima { get => txtDrzavaTima; set => txtDrzavaTima = value; }
        public Button BtnPrikaziTim { get => btnPrikaziTim; set => btnPrikaziTim = value; }
    }
}
