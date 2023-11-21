
using System.Windows.Forms;

namespace Client.Forms.UserControls.Takmicenje
{
    partial class UCRegularniDeo
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
            this.cbTimovi = new System.Windows.Forms.ComboBox();
            this.rtbTimovi = new System.Windows.Forms.RichTextBox();
            this.btnDodajTim = new System.Windows.Forms.Button();
            this.txtNazivTakmicenja = new System.Windows.Forms.TextBox();
            this.txtBrojKola = new System.Windows.Forms.TextBox();
            this.btnSacuvajTakmicenje = new System.Windows.Forms.Button();
            this.btnDodajUtakmicu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTimovi
            // 
            this.cbTimovi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTimovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimovi.FormattingEnabled = true;
            this.cbTimovi.Location = new System.Drawing.Point(356, 76);
            this.cbTimovi.Name = "cbTimovi";
            this.cbTimovi.Size = new System.Drawing.Size(223, 28);
            this.cbTimovi.TabIndex = 0;
            // 
            // rtbTimovi
            // 
            this.rtbTimovi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbTimovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTimovi.Location = new System.Drawing.Point(356, 132);
            this.rtbTimovi.Name = "rtbTimovi";
            this.rtbTimovi.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbTimovi.Size = new System.Drawing.Size(223, 379);
            this.rtbTimovi.TabIndex = 1;
            this.rtbTimovi.Text = "";
            // 
            // btnDodajTim
            // 
            this.btnDodajTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajTim.Location = new System.Drawing.Point(602, 67);
            this.btnDodajTim.Name = "btnDodajTim";
            this.btnDodajTim.Size = new System.Drawing.Size(173, 37);
            this.btnDodajTim.TabIndex = 2;
            this.btnDodajTim.Text = "Dodaj tim u ligu";
            this.btnDodajTim.UseVisualStyleBackColor = true;
            this.btnDodajTim.Click += new System.EventHandler(this.btnDodajTim_Click);
            // 
            // txtNazivTakmicenja
            // 
            this.txtNazivTakmicenja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNazivTakmicenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivTakmicenja.Location = new System.Drawing.Point(356, 27);
            this.txtNazivTakmicenja.Name = "txtNazivTakmicenja";
            this.txtNazivTakmicenja.Size = new System.Drawing.Size(223, 27);
            this.txtNazivTakmicenja.TabIndex = 3;
            this.txtNazivTakmicenja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBrojKola
            // 
            this.txtBrojKola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojKola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojKola.Location = new System.Drawing.Point(356, 573);
            this.txtBrojKola.Name = "txtBrojKola";
            this.txtBrojKola.ReadOnly = true;
            this.txtBrojKola.Size = new System.Drawing.Size(223, 27);
            this.txtBrojKola.TabIndex = 4;
            this.txtBrojKola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSacuvajTakmicenje
            // 
            this.btnSacuvajTakmicenje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvajTakmicenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajTakmicenje.Location = new System.Drawing.Point(356, 718);
            this.btnSacuvajTakmicenje.Name = "btnSacuvajTakmicenje";
            this.btnSacuvajTakmicenje.Size = new System.Drawing.Size(223, 65);
            this.btnSacuvajTakmicenje.TabIndex = 5;
            this.btnSacuvajTakmicenje.Text = "Sacuvaj takmičenje i utakmice";
            this.btnSacuvajTakmicenje.UseVisualStyleBackColor = true;
            this.btnSacuvajTakmicenje.Click += new System.EventHandler(this.btnSacuvajTakmicenje_Click);
            // 
            // btnDodajUtakmicu
            // 
            this.btnDodajUtakmicu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajUtakmicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajUtakmicu.Location = new System.Drawing.Point(356, 635);
            this.btnDodajUtakmicu.Name = "btnDodajUtakmicu";
            this.btnDodajUtakmicu.Size = new System.Drawing.Size(223, 37);
            this.btnDodajUtakmicu.TabIndex = 32;
            this.btnDodajUtakmicu.Text = "Dodaj utakmicu";
            this.btnDodajUtakmicu.UseVisualStyleBackColor = true;
            this.btnDodajUtakmicu.Click += new System.EventHandler(this.btnDodajUtakmicu_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Naziv takmičenja";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Timovi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Izabrani timovi u ligi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 573);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Broj kola u regularnom delu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCRegularniDeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajUtakmicu);
            this.Controls.Add(this.btnSacuvajTakmicenje);
            this.Controls.Add(this.txtBrojKola);
            this.Controls.Add(this.txtNazivTakmicenja);
            this.Controls.Add(this.btnDodajTim);
            this.Controls.Add(this.rtbTimovi);
            this.Controls.Add(this.cbTimovi);
            this.Name = "UCRegularniDeo";
            this.Size = new System.Drawing.Size(914, 909);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTimovi;
        private System.Windows.Forms.RichTextBox rtbTimovi;
        private System.Windows.Forms.Button btnDodajTim;
        private System.Windows.Forms.TextBox txtNazivTakmicenja;
        private System.Windows.Forms.TextBox txtBrojKola;
        private System.Windows.Forms.Button btnSacuvajTakmicenje;
        private Button btnDodajUtakmicu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;

        public ComboBox CbTimovi { get => cbTimovi; set => cbTimovi = value; }
        public RichTextBox RtbTimovi { get => rtbTimovi; set => rtbTimovi = value; }
        public Button BtnDodajTim { get => btnDodajTim; set => btnDodajTim = value; }
        public TextBox TxtNazivTakmicenja { get => txtNazivTakmicenja; set => txtNazivTakmicenja = value; }
        public TextBox TxtBrojKola { get => txtBrojKola; set => txtBrojKola = value; }
        public Button BtnSacuvajTakmicenje { get => btnSacuvajTakmicenje; set => btnSacuvajTakmicenje = value; }
        public Button BtnDodajUtakmicu { get => btnDodajUtakmicu; set => btnDodajUtakmicu = value; }
    }
}
