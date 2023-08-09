
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
            this.btnDodajDvoranu = new System.Windows.Forms.Button();
            this.txtKapacitet = new System.Windows.Forms.TextBox();
            this.txtDrzava = new System.Windows.Forms.TextBox();
            this.txtImeDvorane = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodajDvoranu
            // 
            this.btnDodajDvoranu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajDvoranu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodajDvoranu.BackgroundImage")));
            this.btnDodajDvoranu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDodajDvoranu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajDvoranu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajDvoranu.Location = new System.Drawing.Point(204, 199);
            this.btnDodajDvoranu.Name = "btnDodajDvoranu";
            this.btnDodajDvoranu.Size = new System.Drawing.Size(246, 46);
            this.btnDodajDvoranu.TabIndex = 13;
            this.btnDodajDvoranu.Text = "Dodaj dvoranu";
            this.btnDodajDvoranu.UseVisualStyleBackColor = true;
            this.btnDodajDvoranu.Click += new System.EventHandler(this.btnDodajDvoranu_Click);
            // 
            // txtKapacitet
            // 
            this.txtKapacitet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKapacitet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKapacitet.Location = new System.Drawing.Point(204, 144);
            this.txtKapacitet.Name = "txtKapacitet";
            this.txtKapacitet.Size = new System.Drawing.Size(246, 27);
            this.txtKapacitet.TabIndex = 12;
            this.txtKapacitet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDrzava
            // 
            this.txtDrzava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDrzava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrzava.Location = new System.Drawing.Point(204, 89);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(246, 27);
            this.txtDrzava.TabIndex = 11;
            this.txtDrzava.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtImeDvorane
            // 
            this.txtImeDvorane.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtImeDvorane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImeDvorane.Location = new System.Drawing.Point(204, 34);
            this.txtImeDvorane.Name = "txtImeDvorane";
            this.txtImeDvorane.Size = new System.Drawing.Size(246, 27);
            this.txtImeDvorane.TabIndex = 10;
            this.txtImeDvorane.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OrangeRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(62, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kapacitet";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(62, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Država";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(62, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime";
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
            this.DoubleBuffered = true;
            this.Name = "UCDodajDvoranu";
            this.Size = new System.Drawing.Size(551, 302);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajDvoranu;
        private System.Windows.Forms.TextBox txtKapacitet;
        private System.Windows.Forms.TextBox txtDrzava;
        private System.Windows.Forms.TextBox txtImeDvorane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        public Button BtnDodajDvoranu { get => btnDodajDvoranu; set => btnDodajDvoranu = value; }
        public TextBox TxtKapacitet { get => txtKapacitet; set => txtKapacitet = value; }
        public TextBox TxtDrzava { get => txtDrzava; set => txtDrzava = value; }
        public TextBox TxtImeDvorane { get => txtImeDvorane; set => txtImeDvorane = value; }
    }
}
