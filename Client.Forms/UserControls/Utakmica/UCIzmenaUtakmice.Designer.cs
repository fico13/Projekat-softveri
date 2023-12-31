﻿
using System.Windows.Forms;

namespace Client.Forms.UserControls.Utakmica
{
    partial class UCIzmenaUtakmice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCIzmenaUtakmice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtAsistencije = new System.Windows.Forms.TextBox();
            this.lblGost = new System.Windows.Forms.Label();
            this.lblDomacin = new System.Windows.Forms.Label();
            this.dgvDomaci = new System.Windows.Forms.DataGridView();
            this.igracDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skokoviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asistencijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statistikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnPrikaziStatistiku = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPoeniGost = new System.Windows.Forms.TextBox();
            this.txtPoeniDomacin = new System.Windows.Forms.TextBox();
            this.txtGost = new System.Windows.Forms.TextBox();
            this.txtDomacin = new System.Windows.Forms.TextBox();
            this.gbPretraga = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTimovi = new System.Windows.Forms.ComboBox();
            this.btnPronadjiUtakmice = new System.Windows.Forms.Button();
            this.dgvUtakmice = new System.Windows.Forms.DataGridView();
            this.takmicenjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domacinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojPoenaDomacinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojPoenaGostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumOdigravanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojGledalacaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rundaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fazaTakmicenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utakmicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUcitajUtakmicu = new System.Windows.Forms.Button();
            this.dgvGosti = new System.Windows.Forms.DataGridView();
            this.igracDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poeniDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skokoviDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asistencijeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbUtakmica = new System.Windows.Forms.GroupBox();
            this.txtRunda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBrojGledalaca = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnUcitajStatistiku = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnIzmeniStatistiku = new System.Windows.Forms.Button();
            this.txtPoeni = new System.Windows.Forms.TextBox();
            this.txtSkokovi = new System.Windows.Forms.TextBox();
            this.txtIgrac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbStatistikaIgraca = new System.Windows.Forms.GroupBox();
            this.btnIzmeniUtakmicu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistikaBindingSource)).BeginInit();
            this.gbPretraga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utakmicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGosti)).BeginInit();
            this.gbUtakmica.SuspendLayout();
            this.gbStatistikaIgraca.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAsistencije
            // 
            this.txtAsistencije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAsistencije.Location = new System.Drawing.Point(164, 175);
            this.txtAsistencije.Name = "txtAsistencije";
            this.txtAsistencije.Size = new System.Drawing.Size(185, 27);
            this.txtAsistencije.TabIndex = 28;
            this.txtAsistencije.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGost
            // 
            this.lblGost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGost.AutoSize = true;
            this.lblGost.BackColor = System.Drawing.Color.OrangeRed;
            this.lblGost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGost.Location = new System.Drawing.Point(1330, 427);
            this.lblGost.Name = "lblGost";
            this.lblGost.Size = new System.Drawing.Size(0, 20);
            this.lblGost.TabIndex = 57;
            this.lblGost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDomacin
            // 
            this.lblDomacin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDomacin.AutoSize = true;
            this.lblDomacin.BackColor = System.Drawing.Color.OrangeRed;
            this.lblDomacin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomacin.Location = new System.Drawing.Point(63, 428);
            this.lblDomacin.Name = "lblDomacin";
            this.lblDomacin.Size = new System.Drawing.Size(0, 20);
            this.lblDomacin.TabIndex = 56;
            this.lblDomacin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDomaci
            // 
            this.dgvDomaci.AllowUserToAddRows = false;
            this.dgvDomaci.AllowUserToDeleteRows = false;
            this.dgvDomaci.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvDomaci.AutoGenerateColumns = false;
            this.dgvDomaci.BackgroundColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDomaci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDomaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDomaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.igracDataGridViewTextBoxColumn,
            this.poeniDataGridViewTextBoxColumn,
            this.skokoviDataGridViewTextBoxColumn,
            this.asistencijeDataGridViewTextBoxColumn});
            this.dgvDomaci.DataSource = this.statistikaBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDomaci.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDomaci.Location = new System.Drawing.Point(60, 452);
            this.dgvDomaci.Name = "dgvDomaci";
            this.dgvDomaci.ReadOnly = true;
            this.dgvDomaci.RowHeadersWidth = 51;
            this.dgvDomaci.RowTemplate.Height = 24;
            this.dgvDomaci.Size = new System.Drawing.Size(737, 183);
            this.dgvDomaci.TabIndex = 55;
            // 
            // igracDataGridViewTextBoxColumn
            // 
            this.igracDataGridViewTextBoxColumn.DataPropertyName = "Igrac";
            this.igracDataGridViewTextBoxColumn.HeaderText = "Igrač";
            this.igracDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.igracDataGridViewTextBoxColumn.Name = "igracDataGridViewTextBoxColumn";
            this.igracDataGridViewTextBoxColumn.ReadOnly = true;
            this.igracDataGridViewTextBoxColumn.Width = 125;
            // 
            // poeniDataGridViewTextBoxColumn
            // 
            this.poeniDataGridViewTextBoxColumn.DataPropertyName = "Poeni";
            this.poeniDataGridViewTextBoxColumn.HeaderText = "Poeni";
            this.poeniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.poeniDataGridViewTextBoxColumn.Name = "poeniDataGridViewTextBoxColumn";
            this.poeniDataGridViewTextBoxColumn.ReadOnly = true;
            this.poeniDataGridViewTextBoxColumn.Width = 125;
            // 
            // skokoviDataGridViewTextBoxColumn
            // 
            this.skokoviDataGridViewTextBoxColumn.DataPropertyName = "Skokovi";
            this.skokoviDataGridViewTextBoxColumn.HeaderText = "Skokovi";
            this.skokoviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.skokoviDataGridViewTextBoxColumn.Name = "skokoviDataGridViewTextBoxColumn";
            this.skokoviDataGridViewTextBoxColumn.ReadOnly = true;
            this.skokoviDataGridViewTextBoxColumn.Width = 125;
            // 
            // asistencijeDataGridViewTextBoxColumn
            // 
            this.asistencijeDataGridViewTextBoxColumn.DataPropertyName = "Asistencije";
            this.asistencijeDataGridViewTextBoxColumn.HeaderText = "Asistencije";
            this.asistencijeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.asistencijeDataGridViewTextBoxColumn.Name = "asistencijeDataGridViewTextBoxColumn";
            this.asistencijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.asistencijeDataGridViewTextBoxColumn.Width = 125;
            // 
            // statistikaBindingSource
            // 
            this.statistikaBindingSource.DataSource = typeof(Common.Domain.Statistika);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDatum.CustomFormat = "dd.MM.yyyy. HH:mm";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(190, 97);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(230, 27);
            this.dtpDatum.TabIndex = 27;
            this.dtpDatum.Value = new System.DateTime(2023, 1, 1, 20, 0, 0, 0);
            // 
            // btnPrikaziStatistiku
            // 
            this.btnPrikaziStatistiku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikaziStatistiku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrikaziStatistiku.BackgroundImage")));
            this.btnPrikaziStatistiku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrikaziStatistiku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrikaziStatistiku.Location = new System.Drawing.Point(22, 252);
            this.btnPrikaziStatistiku.Name = "btnPrikaziStatistiku";
            this.btnPrikaziStatistiku.Size = new System.Drawing.Size(260, 44);
            this.btnPrikaziStatistiku.TabIndex = 26;
            this.btnPrikaziStatistiku.Text = "Prikaži statistiku";
            this.btnPrikaziStatistiku.UseVisualStyleBackColor = true;
            this.btnPrikaziStatistiku.Click += new System.EventHandler(this.btnPrikaziStatistiku_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datum";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // txtPoeniGost
            // 
            this.txtPoeniGost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPoeniGost.Location = new System.Drawing.Point(312, 49);
            this.txtPoeniGost.MaxLength = 3;
            this.txtPoeniGost.Name = "txtPoeniGost";
            this.txtPoeniGost.Size = new System.Drawing.Size(51, 27);
            this.txtPoeniGost.TabIndex = 3;
            this.txtPoeniGost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPoeniDomacin
            // 
            this.txtPoeniDomacin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPoeniDomacin.Location = new System.Drawing.Point(231, 49);
            this.txtPoeniDomacin.MaxLength = 3;
            this.txtPoeniDomacin.Name = "txtPoeniDomacin";
            this.txtPoeniDomacin.Size = new System.Drawing.Size(51, 27);
            this.txtPoeniDomacin.TabIndex = 2;
            this.txtPoeniDomacin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGost
            // 
            this.txtGost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGost.Location = new System.Drawing.Point(387, 49);
            this.txtGost.Name = "txtGost";
            this.txtGost.ReadOnly = true;
            this.txtGost.Size = new System.Drawing.Size(185, 27);
            this.txtGost.TabIndex = 1;
            this.txtGost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDomacin
            // 
            this.txtDomacin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDomacin.Location = new System.Drawing.Point(22, 49);
            this.txtDomacin.Name = "txtDomacin";
            this.txtDomacin.ReadOnly = true;
            this.txtDomacin.Size = new System.Drawing.Size(185, 27);
            this.txtDomacin.TabIndex = 0;
            this.txtDomacin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbPretraga
            // 
            this.gbPretraga.BackColor = System.Drawing.Color.OrangeRed;
            this.gbPretraga.Controls.Add(this.label1);
            this.gbPretraga.Controls.Add(this.cbTimovi);
            this.gbPretraga.Controls.Add(this.btnPronadjiUtakmice);
            this.gbPretraga.Controls.Add(this.dgvUtakmice);
            this.gbPretraga.Controls.Add(this.btnUcitajUtakmicu);
            this.gbPretraga.Location = new System.Drawing.Point(61, 33);
            this.gbPretraga.Name = "gbPretraga";
            this.gbPretraga.Size = new System.Drawing.Size(1600, 330);
            this.gbPretraga.TabIndex = 63;
            this.gbPretraga.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tim";
            // 
            // cbTimovi
            // 
            this.cbTimovi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTimovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimovi.FormattingEnabled = true;
            this.cbTimovi.Location = new System.Drawing.Point(23, 57);
            this.cbTimovi.Name = "cbTimovi";
            this.cbTimovi.Size = new System.Drawing.Size(181, 28);
            this.cbTimovi.TabIndex = 31;
            // 
            // btnPronadjiUtakmice
            // 
            this.btnPronadjiUtakmice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPronadjiUtakmice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPronadjiUtakmice.BackgroundImage")));
            this.btnPronadjiUtakmice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPronadjiUtakmice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPronadjiUtakmice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPronadjiUtakmice.Location = new System.Drawing.Point(262, 41);
            this.btnPronadjiUtakmice.Name = "btnPronadjiUtakmice";
            this.btnPronadjiUtakmice.Size = new System.Drawing.Size(282, 44);
            this.btnPronadjiUtakmice.TabIndex = 32;
            this.btnPronadjiUtakmice.Text = "Pronađi utakmice";
            this.btnPronadjiUtakmice.UseVisualStyleBackColor = true;
            this.btnPronadjiUtakmice.Click += new System.EventHandler(this.btnPronadjiUtakmice_Click);
            // 
            // dgvUtakmice
            // 
            this.dgvUtakmice.AllowUserToAddRows = false;
            this.dgvUtakmice.AllowUserToDeleteRows = false;
            this.dgvUtakmice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUtakmice.AutoGenerateColumns = false;
            this.dgvUtakmice.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUtakmice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUtakmice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtakmice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.takmicenjeDataGridViewTextBoxColumn,
            this.domacinDataGridViewTextBoxColumn,
            this.brojPoenaDomacinDataGridViewTextBoxColumn,
            this.brojPoenaGostDataGridViewTextBoxColumn,
            this.gostDataGridViewTextBoxColumn,
            this.datumOdigravanjaDataGridViewTextBoxColumn,
            this.brojGledalacaDataGridViewTextBoxColumn,
            this.rundaDataGridViewTextBoxColumn,
            this.fazaTakmicenjaDataGridViewTextBoxColumn});
            this.dgvUtakmice.DataSource = this.utakmicaBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUtakmice.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvUtakmice.Location = new System.Drawing.Point(23, 108);
            this.dgvUtakmice.Name = "dgvUtakmice";
            this.dgvUtakmice.ReadOnly = true;
            this.dgvUtakmice.RowHeadersWidth = 51;
            this.dgvUtakmice.RowTemplate.Height = 24;
            this.dgvUtakmice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUtakmice.Size = new System.Drawing.Size(1570, 150);
            this.dgvUtakmice.TabIndex = 33;
            // 
            // takmicenjeDataGridViewTextBoxColumn
            // 
            this.takmicenjeDataGridViewTextBoxColumn.DataPropertyName = "Takmicenje";
            this.takmicenjeDataGridViewTextBoxColumn.HeaderText = "Takmičenje";
            this.takmicenjeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.takmicenjeDataGridViewTextBoxColumn.Name = "takmicenjeDataGridViewTextBoxColumn";
            this.takmicenjeDataGridViewTextBoxColumn.ReadOnly = true;
            this.takmicenjeDataGridViewTextBoxColumn.Width = 125;
            // 
            // domacinDataGridViewTextBoxColumn
            // 
            this.domacinDataGridViewTextBoxColumn.DataPropertyName = "Domacin";
            this.domacinDataGridViewTextBoxColumn.HeaderText = "Domaćin";
            this.domacinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.domacinDataGridViewTextBoxColumn.Name = "domacinDataGridViewTextBoxColumn";
            this.domacinDataGridViewTextBoxColumn.ReadOnly = true;
            this.domacinDataGridViewTextBoxColumn.Width = 125;
            // 
            // brojPoenaDomacinDataGridViewTextBoxColumn
            // 
            this.brojPoenaDomacinDataGridViewTextBoxColumn.DataPropertyName = "BrojPoenaDomacin";
            this.brojPoenaDomacinDataGridViewTextBoxColumn.HeaderText = "Broj poena domaćin";
            this.brojPoenaDomacinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojPoenaDomacinDataGridViewTextBoxColumn.Name = "brojPoenaDomacinDataGridViewTextBoxColumn";
            this.brojPoenaDomacinDataGridViewTextBoxColumn.ReadOnly = true;
            this.brojPoenaDomacinDataGridViewTextBoxColumn.Width = 125;
            // 
            // brojPoenaGostDataGridViewTextBoxColumn
            // 
            this.brojPoenaGostDataGridViewTextBoxColumn.DataPropertyName = "BrojPoenaGost";
            this.brojPoenaGostDataGridViewTextBoxColumn.HeaderText = "Broj poena gost";
            this.brojPoenaGostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojPoenaGostDataGridViewTextBoxColumn.Name = "brojPoenaGostDataGridViewTextBoxColumn";
            this.brojPoenaGostDataGridViewTextBoxColumn.ReadOnly = true;
            this.brojPoenaGostDataGridViewTextBoxColumn.Width = 125;
            // 
            // gostDataGridViewTextBoxColumn
            // 
            this.gostDataGridViewTextBoxColumn.DataPropertyName = "Gost";
            this.gostDataGridViewTextBoxColumn.HeaderText = "Gost";
            this.gostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gostDataGridViewTextBoxColumn.Name = "gostDataGridViewTextBoxColumn";
            this.gostDataGridViewTextBoxColumn.ReadOnly = true;
            this.gostDataGridViewTextBoxColumn.Width = 125;
            // 
            // datumOdigravanjaDataGridViewTextBoxColumn
            // 
            this.datumOdigravanjaDataGridViewTextBoxColumn.DataPropertyName = "DatumOdigravanja";
            this.datumOdigravanjaDataGridViewTextBoxColumn.HeaderText = "Datum odigravanja";
            this.datumOdigravanjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumOdigravanjaDataGridViewTextBoxColumn.Name = "datumOdigravanjaDataGridViewTextBoxColumn";
            this.datumOdigravanjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumOdigravanjaDataGridViewTextBoxColumn.Width = 125;
            // 
            // brojGledalacaDataGridViewTextBoxColumn
            // 
            this.brojGledalacaDataGridViewTextBoxColumn.DataPropertyName = "BrojGledalaca";
            this.brojGledalacaDataGridViewTextBoxColumn.HeaderText = "Broj gledalaca";
            this.brojGledalacaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojGledalacaDataGridViewTextBoxColumn.Name = "brojGledalacaDataGridViewTextBoxColumn";
            this.brojGledalacaDataGridViewTextBoxColumn.ReadOnly = true;
            this.brojGledalacaDataGridViewTextBoxColumn.Width = 125;
            // 
            // rundaDataGridViewTextBoxColumn
            // 
            this.rundaDataGridViewTextBoxColumn.DataPropertyName = "Runda";
            this.rundaDataGridViewTextBoxColumn.HeaderText = "Runda";
            this.rundaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rundaDataGridViewTextBoxColumn.Name = "rundaDataGridViewTextBoxColumn";
            this.rundaDataGridViewTextBoxColumn.ReadOnly = true;
            this.rundaDataGridViewTextBoxColumn.Width = 125;
            // 
            // fazaTakmicenjaDataGridViewTextBoxColumn
            // 
            this.fazaTakmicenjaDataGridViewTextBoxColumn.DataPropertyName = "FazaTakmicenja";
            this.fazaTakmicenjaDataGridViewTextBoxColumn.HeaderText = "Faza takmičenja";
            this.fazaTakmicenjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fazaTakmicenjaDataGridViewTextBoxColumn.Name = "fazaTakmicenjaDataGridViewTextBoxColumn";
            this.fazaTakmicenjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fazaTakmicenjaDataGridViewTextBoxColumn.Width = 125;
            // 
            // utakmicaBindingSource
            // 
            this.utakmicaBindingSource.DataSource = typeof(Common.Domain.Utakmica);
            // 
            // btnUcitajUtakmicu
            // 
            this.btnUcitajUtakmicu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUcitajUtakmicu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUcitajUtakmicu.BackgroundImage")));
            this.btnUcitajUtakmicu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUcitajUtakmicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitajUtakmicu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUcitajUtakmicu.Location = new System.Drawing.Point(23, 264);
            this.btnUcitajUtakmicu.Name = "btnUcitajUtakmicu";
            this.btnUcitajUtakmicu.Size = new System.Drawing.Size(282, 44);
            this.btnUcitajUtakmicu.TabIndex = 34;
            this.btnUcitajUtakmicu.Text = "Učitaj utakmicu";
            this.btnUcitajUtakmicu.UseVisualStyleBackColor = true;
            this.btnUcitajUtakmicu.Click += new System.EventHandler(this.btnUcitajUtakmicu_Click);
            // 
            // dgvGosti
            // 
            this.dgvGosti.AllowUserToAddRows = false;
            this.dgvGosti.AllowUserToDeleteRows = false;
            this.dgvGosti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvGosti.AutoGenerateColumns = false;
            this.dgvGosti.BackgroundColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGosti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvGosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGosti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.igracDataGridViewTextBoxColumn1,
            this.poeniDataGridViewTextBoxColumn1,
            this.skokoviDataGridViewTextBoxColumn1,
            this.asistencijeDataGridViewTextBoxColumn1});
            this.dgvGosti.DataSource = this.statistikaBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGosti.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvGosti.Location = new System.Drawing.Point(1326, 452);
            this.dgvGosti.Name = "dgvGosti";
            this.dgvGosti.ReadOnly = true;
            this.dgvGosti.RowHeadersWidth = 51;
            this.dgvGosti.RowTemplate.Height = 24;
            this.dgvGosti.Size = new System.Drawing.Size(737, 183);
            this.dgvGosti.TabIndex = 61;
            // 
            // igracDataGridViewTextBoxColumn1
            // 
            this.igracDataGridViewTextBoxColumn1.DataPropertyName = "Igrac";
            this.igracDataGridViewTextBoxColumn1.HeaderText = "Igrač";
            this.igracDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.igracDataGridViewTextBoxColumn1.Name = "igracDataGridViewTextBoxColumn1";
            this.igracDataGridViewTextBoxColumn1.ReadOnly = true;
            this.igracDataGridViewTextBoxColumn1.Width = 125;
            // 
            // poeniDataGridViewTextBoxColumn1
            // 
            this.poeniDataGridViewTextBoxColumn1.DataPropertyName = "Poeni";
            this.poeniDataGridViewTextBoxColumn1.HeaderText = "Poeni";
            this.poeniDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.poeniDataGridViewTextBoxColumn1.Name = "poeniDataGridViewTextBoxColumn1";
            this.poeniDataGridViewTextBoxColumn1.ReadOnly = true;
            this.poeniDataGridViewTextBoxColumn1.Width = 125;
            // 
            // skokoviDataGridViewTextBoxColumn1
            // 
            this.skokoviDataGridViewTextBoxColumn1.DataPropertyName = "Skokovi";
            this.skokoviDataGridViewTextBoxColumn1.HeaderText = "Skokovi";
            this.skokoviDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.skokoviDataGridViewTextBoxColumn1.Name = "skokoviDataGridViewTextBoxColumn1";
            this.skokoviDataGridViewTextBoxColumn1.ReadOnly = true;
            this.skokoviDataGridViewTextBoxColumn1.Width = 125;
            // 
            // asistencijeDataGridViewTextBoxColumn1
            // 
            this.asistencijeDataGridViewTextBoxColumn1.DataPropertyName = "Asistencije";
            this.asistencijeDataGridViewTextBoxColumn1.HeaderText = "Asistencije";
            this.asistencijeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.asistencijeDataGridViewTextBoxColumn1.Name = "asistencijeDataGridViewTextBoxColumn1";
            this.asistencijeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.asistencijeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // gbUtakmica
            // 
            this.gbUtakmica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUtakmica.BackColor = System.Drawing.Color.OrangeRed;
            this.gbUtakmica.Controls.Add(this.txtRunda);
            this.gbUtakmica.Controls.Add(this.label8);
            this.gbUtakmica.Controls.Add(this.txtBrojGledalaca);
            this.gbUtakmica.Controls.Add(this.label13);
            this.gbUtakmica.Controls.Add(this.dtpDatum);
            this.gbUtakmica.Controls.Add(this.btnPrikaziStatistiku);
            this.gbUtakmica.Controls.Add(this.label4);
            this.gbUtakmica.Controls.Add(this.label3);
            this.gbUtakmica.Controls.Add(this.txtPoeniGost);
            this.gbUtakmica.Controls.Add(this.txtPoeniDomacin);
            this.gbUtakmica.Controls.Add(this.txtGost);
            this.gbUtakmica.Controls.Add(this.txtDomacin);
            this.gbUtakmica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUtakmica.Location = new System.Drawing.Point(1820, 33);
            this.gbUtakmica.Name = "gbUtakmica";
            this.gbUtakmica.Size = new System.Drawing.Size(589, 330);
            this.gbUtakmica.TabIndex = 62;
            this.gbUtakmica.TabStop = false;
            this.gbUtakmica.Text = "Utakmica";
            // 
            // txtRunda
            // 
            this.txtRunda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRunda.Location = new System.Drawing.Point(190, 191);
            this.txtRunda.MaxLength = 3;
            this.txtRunda.Multiline = true;
            this.txtRunda.Name = "txtRunda";
            this.txtRunda.Size = new System.Drawing.Size(230, 27);
            this.txtRunda.TabIndex = 31;
            this.txtRunda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.OrangeRed;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Runda";
            // 
            // txtBrojGledalaca
            // 
            this.txtBrojGledalaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojGledalaca.Location = new System.Drawing.Point(190, 144);
            this.txtBrojGledalaca.MaxLength = 3;
            this.txtBrojGledalaca.Multiline = true;
            this.txtBrojGledalaca.Name = "txtBrojGledalaca";
            this.txtBrojGledalaca.Size = new System.Drawing.Size(230, 27);
            this.txtBrojGledalaca.TabIndex = 29;
            this.txtBrojGledalaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.OrangeRed;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Broj gledalaca";
            // 
            // btnUcitajStatistiku
            // 
            this.btnUcitajStatistiku.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUcitajStatistiku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUcitajStatistiku.BackgroundImage")));
            this.btnUcitajStatistiku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUcitajStatistiku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitajStatistiku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUcitajStatistiku.Location = new System.Drawing.Point(60, 659);
            this.btnUcitajStatistiku.Name = "btnUcitajStatistiku";
            this.btnUcitajStatistiku.Size = new System.Drawing.Size(253, 44);
            this.btnUcitajStatistiku.TabIndex = 58;
            this.btnUcitajStatistiku.Text = "Prikaži statistiku";
            this.btnUcitajStatistiku.UseVisualStyleBackColor = true;
            this.btnUcitajStatistiku.Click += new System.EventHandler(this.btnUcitajStatistiku_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Igrač";
            // 
            // btnIzmeniStatistiku
            // 
            this.btnIzmeniStatistiku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeniStatistiku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIzmeniStatistiku.BackgroundImage")));
            this.btnIzmeniStatistiku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIzmeniStatistiku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzmeniStatistiku.Location = new System.Drawing.Point(32, 220);
            this.btnIzmeniStatistiku.Name = "btnIzmeniStatistiku";
            this.btnIzmeniStatistiku.Size = new System.Drawing.Size(317, 44);
            this.btnIzmeniStatistiku.TabIndex = 26;
            this.btnIzmeniStatistiku.Text = "Izmeni statistiku igrača";
            this.btnIzmeniStatistiku.UseVisualStyleBackColor = true;
            this.btnIzmeniStatistiku.Click += new System.EventHandler(this.btnIzmeniStatistiku_Click);
            // 
            // txtPoeni
            // 
            this.txtPoeni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPoeni.Location = new System.Drawing.Point(164, 75);
            this.txtPoeni.Name = "txtPoeni";
            this.txtPoeni.Size = new System.Drawing.Size(185, 27);
            this.txtPoeni.TabIndex = 0;
            this.txtPoeni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSkokovi
            // 
            this.txtSkokovi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSkokovi.Location = new System.Drawing.Point(164, 122);
            this.txtSkokovi.Name = "txtSkokovi";
            this.txtSkokovi.Size = new System.Drawing.Size(185, 27);
            this.txtSkokovi.TabIndex = 4;
            this.txtSkokovi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIgrac
            // 
            this.txtIgrac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIgrac.Location = new System.Drawing.Point(164, 30);
            this.txtIgrac.Name = "txtIgrac";
            this.txtIgrac.ReadOnly = true;
            this.txtIgrac.Size = new System.Drawing.Size(185, 27);
            this.txtIgrac.TabIndex = 30;
            this.txtIgrac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Skokovi";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Poeni";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Asistencije";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Utakmica";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tim";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // gbStatistikaIgraca
            // 
            this.gbStatistikaIgraca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbStatistikaIgraca.BackColor = System.Drawing.Color.OrangeRed;
            this.gbStatistikaIgraca.Controls.Add(this.label7);
            this.gbStatistikaIgraca.Controls.Add(this.btnIzmeniStatistiku);
            this.gbStatistikaIgraca.Controls.Add(this.txtPoeni);
            this.gbStatistikaIgraca.Controls.Add(this.txtSkokovi);
            this.gbStatistikaIgraca.Controls.Add(this.txtIgrac);
            this.gbStatistikaIgraca.Controls.Add(this.label2);
            this.gbStatistikaIgraca.Controls.Add(this.label5);
            this.gbStatistikaIgraca.Controls.Add(this.label6);
            this.gbStatistikaIgraca.Controls.Add(this.txtAsistencije);
            this.gbStatistikaIgraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatistikaIgraca.Location = new System.Drawing.Point(431, 659);
            this.gbStatistikaIgraca.Name = "gbStatistikaIgraca";
            this.gbStatistikaIgraca.Size = new System.Drawing.Size(366, 283);
            this.gbStatistikaIgraca.TabIndex = 59;
            this.gbStatistikaIgraca.TabStop = false;
            this.gbStatistikaIgraca.Text = "Statistika igraca";
            // 
            // btnIzmeniUtakmicu
            // 
            this.btnIzmeniUtakmicu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnIzmeniUtakmicu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIzmeniUtakmicu.BackgroundImage")));
            this.btnIzmeniUtakmicu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIzmeniUtakmicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniUtakmicu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzmeniUtakmicu.Location = new System.Drawing.Point(812, 898);
            this.btnIzmeniUtakmicu.Name = "btnIzmeniUtakmicu";
            this.btnIzmeniUtakmicu.Size = new System.Drawing.Size(317, 44);
            this.btnIzmeniUtakmicu.TabIndex = 60;
            this.btnIzmeniUtakmicu.Text = "Izmeni utakmicu";
            this.btnIzmeniUtakmicu.UseVisualStyleBackColor = true;
            this.btnIzmeniUtakmicu.Click += new System.EventHandler(this.btnIzmeniUtakmicu_Click);
            // 
            // UCIzmenaUtakmice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblGost);
            this.Controls.Add(this.lblDomacin);
            this.Controls.Add(this.dgvDomaci);
            this.Controls.Add(this.gbPretraga);
            this.Controls.Add(this.dgvGosti);
            this.Controls.Add(this.gbUtakmica);
            this.Controls.Add(this.btnUcitajStatistiku);
            this.Controls.Add(this.gbStatistikaIgraca);
            this.Controls.Add(this.btnIzmeniUtakmicu);
            this.DoubleBuffered = true;
            this.Name = "UCIzmenaUtakmice";
            this.Size = new System.Drawing.Size(2495, 1147);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistikaBindingSource)).EndInit();
            this.gbPretraga.ResumeLayout(false);
            this.gbPretraga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utakmicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGosti)).EndInit();
            this.gbUtakmica.ResumeLayout(false);
            this.gbUtakmica.PerformLayout();
            this.gbStatistikaIgraca.ResumeLayout(false);
            this.gbStatistikaIgraca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAsistencije;
        private System.Windows.Forms.Label lblGost;
        private System.Windows.Forms.Label lblDomacin;
        private System.Windows.Forms.DataGridView dgvDomaci;
        private System.Windows.Forms.BindingSource statistikaBindingSource;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Button btnPrikaziStatistiku;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPoeniGost;
        private System.Windows.Forms.TextBox txtPoeniDomacin;
        private System.Windows.Forms.TextBox txtGost;
        private System.Windows.Forms.TextBox txtDomacin;
        private System.Windows.Forms.GroupBox gbPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTimovi;
        private System.Windows.Forms.Button btnPronadjiUtakmice;
        private System.Windows.Forms.DataGridView dgvUtakmice;
        private System.Windows.Forms.Button btnUcitajUtakmicu;
        private System.Windows.Forms.DataGridView dgvGosti;
        private System.Windows.Forms.GroupBox gbUtakmica;
        private System.Windows.Forms.Button btnUcitajStatistiku;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIzmeniStatistiku;
        private System.Windows.Forms.TextBox txtPoeni;
        private System.Windows.Forms.TextBox txtSkokovi;
        private System.Windows.Forms.TextBox txtIgrac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox gbStatistikaIgraca;
        private System.Windows.Forms.Button btnIzmeniUtakmicu;
        private DataGridViewTextBoxColumn igracDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn poeniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn skokoviDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn asistencijeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn igracDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn poeniDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn skokoviDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn asistencijeDataGridViewTextBoxColumn1;
        private TextBox txtBrojGledalaca;
        private Label label13;
        private TextBox txtRunda;
        private Label label8;
        private DataGridViewTextBoxColumn takmicenjeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn domacinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brojPoenaDomacinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brojPoenaGostDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gostDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datumOdigravanjaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brojGledalacaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rundaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fazaTakmicenjaDataGridViewTextBoxColumn;
        private BindingSource utakmicaBindingSource;

        public TextBox TxtAsistencije { get => txtAsistencije; set => txtAsistencije = value; }
        public Label LblGost { get => lblGost; set => lblGost = value; }
        public Label LblDomacin { get => lblDomacin; set => lblDomacin = value; }
        public DataGridView DgvDomaci { get => dgvDomaci; set => dgvDomaci = value; }
        public DataGridViewTextBoxColumn IgracDataGridViewTextBoxColumn { get => igracDataGridViewTextBoxColumn; set => igracDataGridViewTextBoxColumn = value; }
        public DataGridViewTextBoxColumn PoeniDataGridViewTextBoxColumn { get => poeniDataGridViewTextBoxColumn; set => poeniDataGridViewTextBoxColumn = value; }
        public DataGridViewTextBoxColumn SkokoviDataGridViewTextBoxColumn { get => skokoviDataGridViewTextBoxColumn; set => skokoviDataGridViewTextBoxColumn = value; }
        public DataGridViewTextBoxColumn AsistencijeDataGridViewTextBoxColumn { get => asistencijeDataGridViewTextBoxColumn; set => asistencijeDataGridViewTextBoxColumn = value; }
        public BindingSource StatistikaBindingSource { get => statistikaBindingSource; set => statistikaBindingSource = value; }
        public DateTimePicker DtpDatum { get => dtpDatum; set => dtpDatum = value; }
        public Button BtnPrikaziStatistiku { get => btnPrikaziStatistiku; set => btnPrikaziStatistiku = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public TextBox TxtPoeniGost { get => txtPoeniGost; set => txtPoeniGost = value; }
        public TextBox TxtPoeniDomacin { get => txtPoeniDomacin; set => txtPoeniDomacin = value; }
        public TextBox TxtGost { get => txtGost; set => txtGost = value; }
        public TextBox TxtDomacin { get => txtDomacin; set => txtDomacin = value; }
        public GroupBox GbPretraga { get => gbPretraga; set => gbPretraga = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public ComboBox CbTimovi { get => cbTimovi; set => cbTimovi = value; }
        public Button BtnPronadjiUtakmice { get => btnPronadjiUtakmice; set => btnPronadjiUtakmice = value; }
        public DataGridView DgvUtakmice { get => dgvUtakmice; set => dgvUtakmice = value; }
        public DataGridViewTextBoxColumn DomacinDataGridViewTextBoxColumn { get => domacinDataGridViewTextBoxColumn; set => domacinDataGridViewTextBoxColumn = value; }
        public DataGridViewTextBoxColumn BrojPoenaDomacinDataGridViewTextBoxColumn { get => brojPoenaDomacinDataGridViewTextBoxColumn; set => brojPoenaDomacinDataGridViewTextBoxColumn = value; }
        public DataGridViewTextBoxColumn BrojPoenaGostDataGridViewTextBoxColumn { get => brojPoenaGostDataGridViewTextBoxColumn; set => brojPoenaGostDataGridViewTextBoxColumn = value; }
        public DataGridViewTextBoxColumn GostDataGridViewTextBoxColumn { get => gostDataGridViewTextBoxColumn; set => gostDataGridViewTextBoxColumn = value; }
        public DataGridViewTextBoxColumn DatumOdigravanjaDataGridViewTextBoxColumn { get => datumOdigravanjaDataGridViewTextBoxColumn; set => datumOdigravanjaDataGridViewTextBoxColumn = value; }
        public BindingSource UtakmicaBindingSource { get => utakmicaBindingSource; set => utakmicaBindingSource = value; }
        public Button BtnUcitajUtakmicu { get => btnUcitajUtakmicu; set => btnUcitajUtakmicu = value; }
        public DataGridView DgvGosti { get => dgvGosti; set => dgvGosti = value; }
        public DataGridViewTextBoxColumn IgracDataGridViewTextBoxColumn1 { get => igracDataGridViewTextBoxColumn1; set => igracDataGridViewTextBoxColumn1 = value; }
        public DataGridViewTextBoxColumn PoeniDataGridViewTextBoxColumn1 { get => poeniDataGridViewTextBoxColumn1; set => poeniDataGridViewTextBoxColumn1 = value; }
        public DataGridViewTextBoxColumn SkokoviDataGridViewTextBoxColumn1 { get => skokoviDataGridViewTextBoxColumn1; set => skokoviDataGridViewTextBoxColumn1 = value; }
        public DataGridViewTextBoxColumn AsistencijeDataGridViewTextBoxColumn1 { get => asistencijeDataGridViewTextBoxColumn1; set => asistencijeDataGridViewTextBoxColumn1 = value; }
        public GroupBox GbUtakmica { get => gbUtakmica; set => gbUtakmica = value; }
        public Button BtnUcitajStatistiku { get => btnUcitajStatistiku; set => btnUcitajStatistiku = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public Button BtnIzmeniStatistiku { get => btnIzmeniStatistiku; set => btnIzmeniStatistiku = value; }
        public TextBox TxtPoeni { get => txtPoeni; set => txtPoeni = value; }
        public TextBox TxtSkokovi { get => txtSkokovi; set => txtSkokovi = value; }
        public TextBox TxtIgrac { get => txtIgrac; set => txtIgrac = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public DataGridViewTextBoxColumn DataGridViewTextBoxColumn1 { get => dataGridViewTextBoxColumn1; set => dataGridViewTextBoxColumn1 = value; }
        public GroupBox GbStatistikaIgraca { get => gbStatistikaIgraca; set => gbStatistikaIgraca = value; }
        public Button BtnIzmeniUtakmicu { get => btnIzmeniUtakmicu; set => btnIzmeniUtakmicu = value; }
        public TextBox TxtBrojGledalaca { get => txtBrojGledalaca; set => txtBrojGledalaca = value; }
        public TextBox TxtRunda { get => txtRunda; set => txtRunda = value; }
    }
}
