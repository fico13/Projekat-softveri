
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTimovi
            // 
            this.dgvTimovi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTimovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimovi.Location = new System.Drawing.Point(66, 245);
            this.dgvTimovi.Name = "dgvTimovi";
            this.dgvTimovi.RowHeadersWidth = 51;
            this.dgvTimovi.RowTemplate.Height = 24;
            this.dgvTimovi.Size = new System.Drawing.Size(407, 226);
            this.dgvTimovi.TabIndex = 12;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPretrazi.BackgroundImage")));
            this.btnPretrazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPretrazi.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPretrazi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPretrazi.Location = new System.Drawing.Point(66, 165);
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
            this.txtDrzava.Location = new System.Drawing.Point(295, 121);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(178, 22);
            this.txtDrzava.TabIndex = 10;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Location = new System.Drawing.Point(66, 121);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(178, 22);
            this.txtNaziv.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pronadji tim po državi";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pronadji tim po nazivu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(490, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 517);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // UCNadjiTim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvTimovi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtDrzava);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "UCNadjiTim";
            this.Size = new System.Drawing.Size(992, 558);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;

        public DataGridView DgvTimovi { get => dgvTimovi; set => dgvTimovi = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public TextBox TxtDrzava { get => txtDrzava; set => txtDrzava = value; }
        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
    }
}
