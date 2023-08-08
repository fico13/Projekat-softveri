
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Država";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OrangeRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dvorana";
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.Location = new System.Drawing.Point(351, 188);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(290, 27);
            this.txtIme.TabIndex = 3;
            this.txtIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDrzava
            // 
            this.txtDrzava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDrzava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrzava.Location = new System.Drawing.Point(351, 238);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(290, 27);
            this.txtDrzava.TabIndex = 4;
            this.txtDrzava.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbDvorane
            // 
            this.cbDvorane.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDvorane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDvorane.FormattingEnabled = true;
            this.cbDvorane.Location = new System.Drawing.Point(351, 290);
            this.cbDvorane.Name = "cbDvorane";
            this.cbDvorane.Size = new System.Drawing.Size(290, 28);
            this.cbDvorane.TabIndex = 5;
            // 
            // btnDodajTim
            // 
            this.btnDodajTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajTim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodajTim.BackgroundImage")));
            this.btnDodajTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDodajTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajTim.Location = new System.Drawing.Point(351, 361);
            this.btnDodajTim.Name = "btnDodajTim";
            this.btnDodajTim.Size = new System.Drawing.Size(290, 36);
            this.btnDodajTim.TabIndex = 6;
            this.btnDodajTim.Text = "Dodaj tim";
            this.btnDodajTim.UseVisualStyleBackColor = true;
            this.btnDodajTim.Click += new System.EventHandler(this.btnDodajTim_Click);
            // 
            // UCDodajTim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnDodajTim);
            this.Controls.Add(this.cbDvorane);
            this.Controls.Add(this.txtDrzava);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "UCDodajTim";
            this.Size = new System.Drawing.Size(835, 560);
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

        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtDrzava { get => txtDrzava; set => txtDrzava = value; }
        public ComboBox CbDvorane { get => cbDvorane; set => cbDvorane = value; }
        public Button BtnDodajTim { get => btnDodajTim; set => btnDodajTim = value; }
    }
}
