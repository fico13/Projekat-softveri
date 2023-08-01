
using System.Windows.Forms;

namespace Client.Forms.UserControls.Dvorana
{
    partial class UCDodajDvoranu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDodajDvoranu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImeDvorane = new System.Windows.Forms.TextBox();
            this.txtDrzava = new System.Windows.Forms.TextBox();
            this.txtKapacitet = new System.Windows.Forms.TextBox();
            this.btnDodajDvoranu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Država";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kapacitet";
            // 
            // txtImeDvorane
            // 
            this.txtImeDvorane.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtImeDvorane.Location = new System.Drawing.Point(316, 90);
            this.txtImeDvorane.Name = "txtImeDvorane";
            this.txtImeDvorane.Size = new System.Drawing.Size(246, 22);
            this.txtImeDvorane.TabIndex = 3;
            // 
            // txtDrzava
            // 
            this.txtDrzava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDrzava.Location = new System.Drawing.Point(316, 145);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(246, 22);
            this.txtDrzava.TabIndex = 4;
            // 
            // txtKapacitet
            // 
            this.txtKapacitet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKapacitet.Location = new System.Drawing.Point(316, 200);
            this.txtKapacitet.Name = "txtKapacitet";
            this.txtKapacitet.Size = new System.Drawing.Size(246, 22);
            this.txtKapacitet.TabIndex = 5;
            // 
            // btnDodajDvoranu
            // 
            this.btnDodajDvoranu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajDvoranu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodajDvoranu.BackgroundImage")));
            this.btnDodajDvoranu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDodajDvoranu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajDvoranu.Location = new System.Drawing.Point(316, 257);
            this.btnDodajDvoranu.Name = "btnDodajDvoranu";
            this.btnDodajDvoranu.Size = new System.Drawing.Size(246, 46);
            this.btnDodajDvoranu.TabIndex = 6;
            this.btnDodajDvoranu.Text = "Dodaj dvoranu";
            this.btnDodajDvoranu.UseVisualStyleBackColor = true;
            this.btnDodajDvoranu.Click += new System.EventHandler(this.btnDodajDvoranu_Click);
            // 
            // UCDodajDvoranu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnDodajDvoranu);
            this.Controls.Add(this.txtKapacitet);
            this.Controls.Add(this.txtDrzava);
            this.Controls.Add(this.txtImeDvorane);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCDodajDvoranu";
            this.Size = new System.Drawing.Size(794, 463);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImeDvorane;
        private System.Windows.Forms.TextBox txtDrzava;
        private System.Windows.Forms.TextBox txtKapacitet;
        private System.Windows.Forms.Button btnDodajDvoranu;

        public TextBox TxtImeDvorane { get => txtImeDvorane; set => txtImeDvorane = value; }
        public TextBox TxtDrzava { get => txtDrzava; set => txtDrzava = value; }
        public TextBox TxtKapacitet { get => txtKapacitet; set => txtKapacitet = value; }
        public Button BtnDodajDvoranu { get => btnDodajDvoranu; set => btnDodajDvoranu = value; }
    }
}
