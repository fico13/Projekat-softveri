
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNadjiTim));
            this.dgvTimovi = new System.Windows.Forms.DataGridView();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drzavaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvoranaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojPobedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojPorazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodoviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.timBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTimovi
            // 
            this.dgvTimovi.AllowUserToAddRows = false;
            this.dgvTimovi.AllowUserToDeleteRows = false;
            this.dgvTimovi.AutoGenerateColumns = false;
            this.dgvTimovi.BackgroundColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTimovi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTimovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeDataGridViewTextBoxColumn,
            this.drzavaDataGridViewTextBoxColumn,
            this.dvoranaDataGridViewTextBoxColumn,
            this.brojPobedaDataGridViewTextBoxColumn,
            this.brojPorazaDataGridViewTextBoxColumn,
            this.bodoviDataGridViewTextBoxColumn});
            this.dgvTimovi.DataSource = this.timBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTimovi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTimovi.Location = new System.Drawing.Point(80, 208);
            this.dgvTimovi.Name = "dgvTimovi";
            this.dgvTimovi.ReadOnly = true;
            this.dgvTimovi.RowHeadersWidth = 51;
            this.dgvTimovi.RowTemplate.Height = 24;
            this.dgvTimovi.Size = new System.Drawing.Size(1025, 226);
            this.dgvTimovi.TabIndex = 12;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeDataGridViewTextBoxColumn.Width = 120;
            // 
            // drzavaDataGridViewTextBoxColumn
            // 
            this.drzavaDataGridViewTextBoxColumn.DataPropertyName = "Drzava";
            this.drzavaDataGridViewTextBoxColumn.HeaderText = "Drzava";
            this.drzavaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.drzavaDataGridViewTextBoxColumn.Name = "drzavaDataGridViewTextBoxColumn";
            this.drzavaDataGridViewTextBoxColumn.ReadOnly = true;
            this.drzavaDataGridViewTextBoxColumn.Width = 120;
            // 
            // dvoranaDataGridViewTextBoxColumn
            // 
            this.dvoranaDataGridViewTextBoxColumn.DataPropertyName = "Dvorana";
            this.dvoranaDataGridViewTextBoxColumn.HeaderText = "Dvorana";
            this.dvoranaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dvoranaDataGridViewTextBoxColumn.Name = "dvoranaDataGridViewTextBoxColumn";
            this.dvoranaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dvoranaDataGridViewTextBoxColumn.Width = 135;
            // 
            // brojPobedaDataGridViewTextBoxColumn
            // 
            this.brojPobedaDataGridViewTextBoxColumn.DataPropertyName = "BrojPobeda";
            this.brojPobedaDataGridViewTextBoxColumn.HeaderText = "Broj pobeda";
            this.brojPobedaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojPobedaDataGridViewTextBoxColumn.Name = "brojPobedaDataGridViewTextBoxColumn";
            this.brojPobedaDataGridViewTextBoxColumn.ReadOnly = true;
            this.brojPobedaDataGridViewTextBoxColumn.Width = 110;
            // 
            // brojPorazaDataGridViewTextBoxColumn
            // 
            this.brojPorazaDataGridViewTextBoxColumn.DataPropertyName = "BrojPoraza";
            this.brojPorazaDataGridViewTextBoxColumn.HeaderText = "Broj poraza";
            this.brojPorazaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojPorazaDataGridViewTextBoxColumn.Name = "brojPorazaDataGridViewTextBoxColumn";
            this.brojPorazaDataGridViewTextBoxColumn.ReadOnly = true;
            this.brojPorazaDataGridViewTextBoxColumn.Width = 110;
            // 
            // bodoviDataGridViewTextBoxColumn
            // 
            this.bodoviDataGridViewTextBoxColumn.DataPropertyName = "Bodovi";
            this.bodoviDataGridViewTextBoxColumn.HeaderText = "Bodovi";
            this.bodoviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bodoviDataGridViewTextBoxColumn.Name = "bodoviDataGridViewTextBoxColumn";
            this.bodoviDataGridViewTextBoxColumn.ReadOnly = true;
            this.bodoviDataGridViewTextBoxColumn.Width = 110;
            // 
            // timBindingSource
            // 
            this.timBindingSource.DataSource = typeof(Common.Domain.Tim);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPretrazi.BackgroundImage")));
            this.btnPretrazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPretrazi.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPretrazi.Location = new System.Drawing.Point(614, 152);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(212, 38);
            this.btnPretrazi.TabIndex = 11;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtDrzava
            // 
            this.txtDrzava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrzava.Location = new System.Drawing.Point(345, 163);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(216, 27);
            this.txtDrzava.TabIndex = 10;
            this.txtDrzava.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(81, 163);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(216, 27);
            this.txtNaziv.TabIndex = 9;
            this.txtNaziv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pronađi tim po državi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pronađi tim po nazivu";
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.BackColor = System.Drawing.Color.White;
            this.txtIme.Location = new System.Drawing.Point(178, 58);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(273, 28);
            this.txtIme.TabIndex = 14;
            this.txtIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ime";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OrangeRed;
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(81, 519);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 344);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije o timu";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Dvorana";
            // 
            // txtDvorana
            // 
            this.txtDvorana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDvorana.BackColor = System.Drawing.Color.White;
            this.txtDvorana.Location = new System.Drawing.Point(178, 263);
            this.txtDvorana.Name = "txtDvorana";
            this.txtDvorana.ReadOnly = true;
            this.txtDvorana.Size = new System.Drawing.Size(273, 28);
            this.txtDvorana.TabIndex = 24;
            this.txtDvorana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Bodovi";
            // 
            // txtBodovi
            // 
            this.txtBodovi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBodovi.BackColor = System.Drawing.Color.White;
            this.txtBodovi.Location = new System.Drawing.Point(178, 222);
            this.txtBodovi.Name = "txtBodovi";
            this.txtBodovi.ReadOnly = true;
            this.txtBodovi.Size = new System.Drawing.Size(273, 28);
            this.txtBodovi.TabIndex = 22;
            this.txtBodovi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Broj poraza";
            // 
            // txtBrojPoraza
            // 
            this.txtBrojPoraza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojPoraza.BackColor = System.Drawing.Color.White;
            this.txtBrojPoraza.Location = new System.Drawing.Point(178, 181);
            this.txtBrojPoraza.Name = "txtBrojPoraza";
            this.txtBrojPoraza.ReadOnly = true;
            this.txtBrojPoraza.Size = new System.Drawing.Size(273, 28);
            this.txtBrojPoraza.TabIndex = 20;
            this.txtBrojPoraza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Broj pobeda";
            // 
            // txtBrojPobeda
            // 
            this.txtBrojPobeda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojPobeda.BackColor = System.Drawing.Color.White;
            this.txtBrojPobeda.Location = new System.Drawing.Point(178, 140);
            this.txtBrojPobeda.Name = "txtBrojPobeda";
            this.txtBrojPobeda.ReadOnly = true;
            this.txtBrojPobeda.Size = new System.Drawing.Size(273, 28);
            this.txtBrojPobeda.TabIndex = 18;
            this.txtBrojPobeda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Država";
            // 
            // txtDrzavaTima
            // 
            this.txtDrzavaTima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDrzavaTima.BackColor = System.Drawing.Color.White;
            this.txtDrzavaTima.Location = new System.Drawing.Point(178, 99);
            this.txtDrzavaTima.Name = "txtDrzavaTima";
            this.txtDrzavaTima.ReadOnly = true;
            this.txtDrzavaTima.Size = new System.Drawing.Size(273, 28);
            this.txtDrzavaTima.TabIndex = 16;
            this.txtDrzavaTima.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPrikaziTim
            // 
            this.btnPrikaziTim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrikaziTim.BackgroundImage")));
            this.btnPrikaziTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrikaziTim.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPrikaziTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrikaziTim.Location = new System.Drawing.Point(80, 464);
            this.btnPrikaziTim.Name = "btnPrikaziTim";
            this.btnPrikaziTim.Size = new System.Drawing.Size(213, 38);
            this.btnPrikaziTim.TabIndex = 16;
            this.btnPrikaziTim.Text = "Prikaži tim";
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
            this.Size = new System.Drawing.Size(1287, 931);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timBindingSource)).EndInit();
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
        private BindingSource timBindingSource;
        private DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn drzavaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dvoranaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brojPobedaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brojPorazaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bodoviDataGridViewTextBoxColumn;

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
