
using System.Windows.Forms;

namespace Client.Forms.UserControls.Tim
{
    partial class UCDodajTim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDodajTim));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtDrzava = new System.Windows.Forms.TextBox();
            this.cbDvorane = new System.Windows.Forms.ComboBox();
            this.btnDodajTim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Država";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dvorana";
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.Location = new System.Drawing.Point(131, 74);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(179, 22);
            this.txtIme.TabIndex = 3;
            // 
            // txtDrzava
            // 
            this.txtDrzava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDrzava.Location = new System.Drawing.Point(131, 124);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(179, 22);
            this.txtDrzava.TabIndex = 4;
            // 
            // cbDvorane
            // 
            this.cbDvorane.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDvorane.FormattingEnabled = true;
            this.cbDvorane.Location = new System.Drawing.Point(131, 174);
            this.cbDvorane.Name = "cbDvorane";
            this.cbDvorane.Size = new System.Drawing.Size(179, 24);
            this.cbDvorane.TabIndex = 5;
            // 
            // btnDodajTim
            // 
            this.btnDodajTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajTim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodajTim.BackgroundImage")));
            this.btnDodajTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDodajTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajTim.Location = new System.Drawing.Point(131, 242);
            this.btnDodajTim.Name = "btnDodajTim";
            this.btnDodajTim.Size = new System.Drawing.Size(179, 36);
            this.btnDodajTim.TabIndex = 6;
            this.btnDodajTim.Text = "Dodaj tim";
            this.btnDodajTim.UseVisualStyleBackColor = true;
            this.btnDodajTim.Click += new System.EventHandler(this.btnDodajTim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(446, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 517);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // UCDodajTim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDodajTim);
            this.Controls.Add(this.cbDvorane);
            this.Controls.Add(this.txtDrzava);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCDodajTim";
            this.Size = new System.Drawing.Size(964, 576);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtDrzava;
        private System.Windows.Forms.ComboBox cbDvorane;
        private System.Windows.Forms.Button btnDodajTim;
        private System.Windows.Forms.PictureBox pictureBox1;

        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtDrzava { get => txtDrzava; set => txtDrzava = value; }
        public ComboBox CbDvorane { get => cbDvorane; set => cbDvorane = value; }
        public Button BtnDodajTim { get => btnDodajTim; set => btnDodajTim = value; }
    }
}
