
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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Država";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dvorana";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(163, 116);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(201, 22);
            this.txtIme.TabIndex = 3;
            // 
            // txtDrzava
            // 
            this.txtDrzava.Location = new System.Drawing.Point(163, 166);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(201, 22);
            this.txtDrzava.TabIndex = 4;
            // 
            // cbDvorane
            // 
            this.cbDvorane.FormattingEnabled = true;
            this.cbDvorane.Location = new System.Drawing.Point(163, 218);
            this.cbDvorane.Name = "cbDvorane";
            this.cbDvorane.Size = new System.Drawing.Size(201, 24);
            this.cbDvorane.TabIndex = 5;
            // 
            // btnDodajTim
            // 
            this.btnDodajTim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodajTim.BackgroundImage")));
            this.btnDodajTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDodajTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajTim.Location = new System.Drawing.Point(163, 281);
            this.btnDodajTim.Name = "btnDodajTim";
            this.btnDodajTim.Size = new System.Drawing.Size(201, 36);
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
            this.Name = "UCDodajTim";
            this.Size = new System.Drawing.Size(474, 371);
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
