﻿
using System.Windows.Forms;

namespace Client.Forms.UserControls.Igrac
{
    partial class UCPretragaIgraca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPretragaIgraca));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDatumRodjenja = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.txtPozicija = new System.Windows.Forms.TextBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTezina = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVisina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBrojNaDresu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDrzava = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnIzaberiIgraca = new System.Windows.Forms.Button();
            this.dgvIgraci = new System.Windows.Forms.DataGridView();
            this.igracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTraziIgraca = new System.Windows.Forms.Button();
            this.txtPrezimeIgraca = new System.Windows.Forms.TextBox();
            this.txtImeIgraca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imeIgracaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeIgracaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drzavaIgracaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumRodjenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozicijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojNaDresuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tezinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igracBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Controls.Add(this.txtDatumRodjenja);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnStatistika);
            this.groupBox1.Controls.Add(this.txtPozicija);
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTezina);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtVisina);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBrojNaDresu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDrzava);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(969, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 580);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Igrač";
            // 
            // txtDatumRodjenja
            // 
            this.txtDatumRodjenja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatumRodjenja.Location = new System.Drawing.Point(198, 182);
            this.txtDatumRodjenja.Name = "txtDatumRodjenja";
            this.txtDatumRodjenja.ReadOnly = true;
            this.txtDatumRodjenja.Size = new System.Drawing.Size(232, 27);
            this.txtDatumRodjenja.TabIndex = 45;
            this.txtDatumRodjenja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Datum rođenja";
            // 
            // btnStatistika
            // 
            this.btnStatistika.Location = new System.Drawing.Point(198, 479);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(232, 38);
            this.btnStatistika.TabIndex = 43;
            this.btnStatistika.Text = "Prikaži statistiku";
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // txtPozicija
            // 
            this.txtPozicija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPozicija.Location = new System.Drawing.Point(198, 231);
            this.txtPozicija.Name = "txtPozicija";
            this.txtPozicija.ReadOnly = true;
            this.txtPozicija.Size = new System.Drawing.Size(232, 27);
            this.txtPozicija.TabIndex = 42;
            this.txtPozicija.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTim
            // 
            this.txtTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTim.Location = new System.Drawing.Point(198, 427);
            this.txtTim.Name = "txtTim";
            this.txtTim.ReadOnly = true;
            this.txtTim.Size = new System.Drawing.Size(232, 27);
            this.txtTim.TabIndex = 41;
            this.txtTim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 434);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Tim";
            // 
            // txtTezina
            // 
            this.txtTezina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTezina.Location = new System.Drawing.Point(198, 378);
            this.txtTezina.Name = "txtTezina";
            this.txtTezina.ReadOnly = true;
            this.txtTezina.Size = new System.Drawing.Size(232, 27);
            this.txtTezina.TabIndex = 39;
            this.txtTezina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Težina (kg)";
            // 
            // txtVisina
            // 
            this.txtVisina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVisina.Location = new System.Drawing.Point(198, 329);
            this.txtVisina.Name = "txtVisina";
            this.txtVisina.ReadOnly = true;
            this.txtVisina.Size = new System.Drawing.Size(232, 27);
            this.txtVisina.TabIndex = 37;
            this.txtVisina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Visina (cm)";
            // 
            // txtBrojNaDresu
            // 
            this.txtBrojNaDresu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojNaDresu.Location = new System.Drawing.Point(198, 280);
            this.txtBrojNaDresu.Name = "txtBrojNaDresu";
            this.txtBrojNaDresu.ReadOnly = true;
            this.txtBrojNaDresu.Size = new System.Drawing.Size(232, 27);
            this.txtBrojNaDresu.TabIndex = 35;
            this.txtBrojNaDresu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Broj na dresu";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrezime.Location = new System.Drawing.Point(198, 84);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(232, 27);
            this.txtPrezime.TabIndex = 33;
            this.txtPrezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Prezime";
            // 
            // txtDrzava
            // 
            this.txtDrzava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDrzava.Location = new System.Drawing.Point(198, 133);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.ReadOnly = true;
            this.txtDrzava.Size = new System.Drawing.Size(232, 27);
            this.txtDrzava.TabIndex = 30;
            this.txtDrzava.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.Location = new System.Drawing.Point(198, 35);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(232, 27);
            this.txtIme.TabIndex = 29;
            this.txtIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Pozicija";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Država";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Ime";
            // 
            // btnIzaberiIgraca
            // 
            this.btnIzaberiIgraca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIzaberiIgraca.BackgroundImage")));
            this.btnIzaberiIgraca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIzaberiIgraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzaberiIgraca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzaberiIgraca.Location = new System.Drawing.Point(40, 483);
            this.btnIzaberiIgraca.Name = "btnIzaberiIgraca";
            this.btnIzaberiIgraca.Size = new System.Drawing.Size(241, 41);
            this.btnIzaberiIgraca.TabIndex = 31;
            this.btnIzaberiIgraca.Text = "Izaberi igrača";
            this.btnIzaberiIgraca.UseVisualStyleBackColor = true;
            this.btnIzaberiIgraca.Click += new System.EventHandler(this.btnIzaberiIgraca_Click);
            // 
            // dgvIgraci
            // 
            this.dgvIgraci.AllowUserToAddRows = false;
            this.dgvIgraci.AllowUserToDeleteRows = false;
            this.dgvIgraci.AutoGenerateColumns = false;
            this.dgvIgraci.BackgroundColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIgraci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIgraci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgraci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeIgracaDataGridViewTextBoxColumn,
            this.prezimeIgracaDataGridViewTextBoxColumn,
            this.drzavaIgracaDataGridViewTextBoxColumn,
            this.datumRodjenjaDataGridViewTextBoxColumn,
            this.timDataGridViewTextBoxColumn,
            this.pozicijaDataGridViewTextBoxColumn,
            this.brojNaDresuDataGridViewTextBoxColumn,
            this.visinaDataGridViewTextBoxColumn,
            this.tezinaDataGridViewTextBoxColumn});
            this.dgvIgraci.DataSource = this.igracBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIgraci.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIgraci.Location = new System.Drawing.Point(40, 227);
            this.dgvIgraci.Name = "dgvIgraci";
            this.dgvIgraci.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIgraci.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIgraci.RowHeadersWidth = 51;
            this.dgvIgraci.RowTemplate.Height = 24;
            this.dgvIgraci.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvIgraci.Size = new System.Drawing.Size(1430, 227);
            this.dgvIgraci.TabIndex = 30;
            // 
            // igracBindingSource
            // 
            this.igracBindingSource.DataSource = typeof(Common.Domain.Igrac);
            // 
            // btnTraziIgraca
            // 
            this.btnTraziIgraca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTraziIgraca.BackgroundImage")));
            this.btnTraziIgraca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTraziIgraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraziIgraca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraziIgraca.Location = new System.Drawing.Point(40, 171);
            this.btnTraziIgraca.Name = "btnTraziIgraca";
            this.btnTraziIgraca.Size = new System.Drawing.Size(241, 41);
            this.btnTraziIgraca.TabIndex = 29;
            this.btnTraziIgraca.Text = "Nađi igrače";
            this.btnTraziIgraca.UseVisualStyleBackColor = true;
            this.btnTraziIgraca.Click += new System.EventHandler(this.btnTraziIgraca_Click);
            // 
            // txtPrezimeIgraca
            // 
            this.txtPrezimeIgraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezimeIgraca.Location = new System.Drawing.Point(376, 127);
            this.txtPrezimeIgraca.Name = "txtPrezimeIgraca";
            this.txtPrezimeIgraca.Size = new System.Drawing.Size(241, 27);
            this.txtPrezimeIgraca.TabIndex = 28;
            // 
            // txtImeIgraca
            // 
            this.txtImeIgraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImeIgraca.Location = new System.Drawing.Point(40, 127);
            this.txtImeIgraca.Name = "txtImeIgraca";
            this.txtImeIgraca.Size = new System.Drawing.Size(241, 27);
            this.txtImeIgraca.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Chocolate;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Prezime igrača";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ime igrača";
            // 
            // imeIgracaDataGridViewTextBoxColumn
            // 
            this.imeIgracaDataGridViewTextBoxColumn.DataPropertyName = "ImeIgraca";
            this.imeIgracaDataGridViewTextBoxColumn.HeaderText = "Ime igrača";
            this.imeIgracaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imeIgracaDataGridViewTextBoxColumn.Name = "imeIgracaDataGridViewTextBoxColumn";
            this.imeIgracaDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeIgracaDataGridViewTextBoxColumn.Width = 120;
            // 
            // prezimeIgracaDataGridViewTextBoxColumn
            // 
            this.prezimeIgracaDataGridViewTextBoxColumn.DataPropertyName = "PrezimeIgraca";
            this.prezimeIgracaDataGridViewTextBoxColumn.HeaderText = "Prezime igrača";
            this.prezimeIgracaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prezimeIgracaDataGridViewTextBoxColumn.Name = "prezimeIgracaDataGridViewTextBoxColumn";
            this.prezimeIgracaDataGridViewTextBoxColumn.ReadOnly = true;
            this.prezimeIgracaDataGridViewTextBoxColumn.Width = 120;
            // 
            // drzavaIgracaDataGridViewTextBoxColumn
            // 
            this.drzavaIgracaDataGridViewTextBoxColumn.DataPropertyName = "DrzavaIgraca";
            this.drzavaIgracaDataGridViewTextBoxColumn.HeaderText = "Država ";
            this.drzavaIgracaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.drzavaIgracaDataGridViewTextBoxColumn.Name = "drzavaIgracaDataGridViewTextBoxColumn";
            this.drzavaIgracaDataGridViewTextBoxColumn.ReadOnly = true;
            this.drzavaIgracaDataGridViewTextBoxColumn.Width = 120;
            // 
            // datumRodjenjaDataGridViewTextBoxColumn
            // 
            this.datumRodjenjaDataGridViewTextBoxColumn.DataPropertyName = "DatumRodjenja";
            this.datumRodjenjaDataGridViewTextBoxColumn.HeaderText = "Datum rodjenja";
            this.datumRodjenjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumRodjenjaDataGridViewTextBoxColumn.Name = "datumRodjenjaDataGridViewTextBoxColumn";
            this.datumRodjenjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumRodjenjaDataGridViewTextBoxColumn.Width = 120;
            // 
            // timDataGridViewTextBoxColumn
            // 
            this.timDataGridViewTextBoxColumn.DataPropertyName = "Tim";
            this.timDataGridViewTextBoxColumn.HeaderText = "Tim";
            this.timDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timDataGridViewTextBoxColumn.Name = "timDataGridViewTextBoxColumn";
            this.timDataGridViewTextBoxColumn.ReadOnly = true;
            this.timDataGridViewTextBoxColumn.Width = 120;
            // 
            // pozicijaDataGridViewTextBoxColumn
            // 
            this.pozicijaDataGridViewTextBoxColumn.DataPropertyName = "Pozicija";
            this.pozicijaDataGridViewTextBoxColumn.HeaderText = "Pozicija";
            this.pozicijaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pozicijaDataGridViewTextBoxColumn.Name = "pozicijaDataGridViewTextBoxColumn";
            this.pozicijaDataGridViewTextBoxColumn.ReadOnly = true;
            this.pozicijaDataGridViewTextBoxColumn.Width = 120;
            // 
            // brojNaDresuDataGridViewTextBoxColumn
            // 
            this.brojNaDresuDataGridViewTextBoxColumn.DataPropertyName = "BrojNaDresu";
            this.brojNaDresuDataGridViewTextBoxColumn.HeaderText = "Broj na dresu";
            this.brojNaDresuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojNaDresuDataGridViewTextBoxColumn.Name = "brojNaDresuDataGridViewTextBoxColumn";
            this.brojNaDresuDataGridViewTextBoxColumn.ReadOnly = true;
            this.brojNaDresuDataGridViewTextBoxColumn.Width = 120;
            // 
            // visinaDataGridViewTextBoxColumn
            // 
            this.visinaDataGridViewTextBoxColumn.DataPropertyName = "Visina";
            this.visinaDataGridViewTextBoxColumn.HeaderText = "Visina (cm)";
            this.visinaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.visinaDataGridViewTextBoxColumn.Name = "visinaDataGridViewTextBoxColumn";
            this.visinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.visinaDataGridViewTextBoxColumn.Width = 90;
            // 
            // tezinaDataGridViewTextBoxColumn
            // 
            this.tezinaDataGridViewTextBoxColumn.DataPropertyName = "Tezina";
            this.tezinaDataGridViewTextBoxColumn.HeaderText = "Težina (kg)";
            this.tezinaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tezinaDataGridViewTextBoxColumn.Name = "tezinaDataGridViewTextBoxColumn";
            this.tezinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tezinaDataGridViewTextBoxColumn.Width = 90;
            // 
            // UCPretragaIgraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIzaberiIgraca);
            this.Controls.Add(this.dgvIgraci);
            this.Controls.Add(this.btnTraziIgraca);
            this.Controls.Add(this.txtPrezimeIgraca);
            this.Controls.Add(this.txtImeIgraca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "UCPretragaIgraca";
            this.Size = new System.Drawing.Size(1498, 825);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igracBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTezina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVisina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBrojNaDresu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDrzava;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnIzaberiIgraca;
        private System.Windows.Forms.DataGridView dgvIgraci;
        private System.Windows.Forms.Button btnTraziIgraca;
        private System.Windows.Forms.TextBox txtPrezimeIgraca;
        private System.Windows.Forms.TextBox txtImeIgraca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPozicija;
        private Button btnStatistika;
        private BindingSource igracBindingSource;
        private TextBox txtDatumRodjenja;
        private Label label11;
        private DataGridViewTextBoxColumn imeIgracaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prezimeIgracaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn drzavaIgracaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datumRodjenjaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pozicijaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brojNaDresuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn visinaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tezinaDataGridViewTextBoxColumn;

        public TextBox TxtTezina { get => txtTezina; set => txtTezina = value; }
        public TextBox TxtVisina { get => txtVisina; set => txtVisina = value; }
        public TextBox TxtBrojNaDresu { get => txtBrojNaDresu; set => txtBrojNaDresu = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtDrzava { get => txtDrzava; set => txtDrzava = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public DataGridView DgvIgraci { get => dgvIgraci; set => dgvIgraci = value; }
        public TextBox TxtPrezimeIgraca { get => txtPrezimeIgraca; set => txtPrezimeIgraca = value; }
        public TextBox TxtImeIgraca { get => txtImeIgraca; set => txtImeIgraca = value; }
        public TextBox TxtTim { get => txtTim; set => txtTim = value; }
        public TextBox TxtPozicija { get => txtPozicija; set => txtPozicija = value; }
        public Button BtnStatistika { get => btnStatistika; set => btnStatistika = value; }
        public TextBox TxtDatumRodjenja { get => txtDatumRodjenja; set => txtDatumRodjenja = value; }
    }
}
