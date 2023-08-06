
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCIzmenaUtakmice));
            this.lblDomacin = new System.Windows.Forms.Label();
            this.lblGost = new System.Windows.Forms.Label();
            this.dgvGosti = new System.Windows.Forms.DataGridView();
            this.statistikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asistencijeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skokoviDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poeniDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igracDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asistencijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skokoviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igracDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDomaci = new System.Windows.Forms.DataGridView();
            this.txtDomacin = new System.Windows.Forms.TextBox();
            this.txtGost = new System.Windows.Forms.TextBox();
            this.txtPoeniDomacin = new System.Windows.Forms.TextBox();
            this.txtPoeniGost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrikaziStatistiku = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.gbUtakmica = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUcitajStatistiku = new System.Windows.Forms.Button();
            this.gbStatistikaIgraca = new System.Windows.Forms.GroupBox();
            this.txtAsistencije = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIgrac = new System.Windows.Forms.TextBox();
            this.txtSkokovi = new System.Windows.Forms.TextBox();
            this.txtPoeni = new System.Windows.Forms.TextBox();
            this.btnIzmeniStatistiku = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnIzmeniUtakmicu = new System.Windows.Forms.Button();
            this.utakmicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUcitajUtakmicu = new System.Windows.Forms.Button();
            this.dgvUtakmice = new System.Windows.Forms.DataGridView();
            this.datumOdigravanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojPoenaGostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojPoenaDomacinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domacinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPronadjiUtakmice = new System.Windows.Forms.Button();
            this.cbTimovi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPretraga = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGosti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomaci)).BeginInit();
            this.gbUtakmica.SuspendLayout();
            this.gbStatistikaIgraca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utakmicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).BeginInit();
            this.gbPretraga.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDomacin
            // 
            this.lblDomacin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDomacin.AutoSize = true;
            this.lblDomacin.Location = new System.Drawing.Point(28, 538);
            this.lblDomacin.Name = "lblDomacin";
            this.lblDomacin.Size = new System.Drawing.Size(0, 17);
            this.lblDomacin.TabIndex = 38;
            // 
            // lblGost
            // 
            this.lblGost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGost.AutoSize = true;
            this.lblGost.Location = new System.Drawing.Point(872, 538);
            this.lblGost.Name = "lblGost";
            this.lblGost.Size = new System.Drawing.Size(0, 17);
            this.lblGost.TabIndex = 39;
            // 
            // dgvGosti
            // 
            this.dgvGosti.AllowUserToAddRows = false;
            this.dgvGosti.AllowUserToDeleteRows = false;
            this.dgvGosti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvGosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGosti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.igracDataGridViewTextBoxColumn1,
            this.poeniDataGridViewTextBoxColumn1,
            this.skokoviDataGridViewTextBoxColumn1,
            this.asistencijeDataGridViewTextBoxColumn1});
            this.dgvGosti.Location = new System.Drawing.Point(875, 593);
            this.dgvGosti.Name = "dgvGosti";
            this.dgvGosti.ReadOnly = true;
            this.dgvGosti.RowHeadersWidth = 51;
            this.dgvGosti.RowTemplate.Height = 24;
            this.dgvGosti.Size = new System.Drawing.Size(764, 183);
            this.dgvGosti.TabIndex = 37;
            // 
            // statistikaBindingSource
            // 
            this.statistikaBindingSource.DataSource = typeof(Common.Domain.Statistika);
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
            // skokoviDataGridViewTextBoxColumn1
            // 
            this.skokoviDataGridViewTextBoxColumn1.DataPropertyName = "Skokovi";
            this.skokoviDataGridViewTextBoxColumn1.HeaderText = "Skokovi";
            this.skokoviDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.skokoviDataGridViewTextBoxColumn1.Name = "skokoviDataGridViewTextBoxColumn1";
            this.skokoviDataGridViewTextBoxColumn1.ReadOnly = true;
            this.skokoviDataGridViewTextBoxColumn1.Width = 125;
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
            // igracDataGridViewTextBoxColumn1
            // 
            this.igracDataGridViewTextBoxColumn1.DataPropertyName = "Igrac";
            this.igracDataGridViewTextBoxColumn1.HeaderText = "Igrac";
            this.igracDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.igracDataGridViewTextBoxColumn1.Name = "igracDataGridViewTextBoxColumn1";
            this.igracDataGridViewTextBoxColumn1.ReadOnly = true;
            this.igracDataGridViewTextBoxColumn1.Width = 125;
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
            // skokoviDataGridViewTextBoxColumn
            // 
            this.skokoviDataGridViewTextBoxColumn.DataPropertyName = "Skokovi";
            this.skokoviDataGridViewTextBoxColumn.HeaderText = "Skokovi";
            this.skokoviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.skokoviDataGridViewTextBoxColumn.Name = "skokoviDataGridViewTextBoxColumn";
            this.skokoviDataGridViewTextBoxColumn.ReadOnly = true;
            this.skokoviDataGridViewTextBoxColumn.Width = 125;
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
            // igracDataGridViewTextBoxColumn
            // 
            this.igracDataGridViewTextBoxColumn.DataPropertyName = "Igrac";
            this.igracDataGridViewTextBoxColumn.HeaderText = "Igrac";
            this.igracDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.igracDataGridViewTextBoxColumn.Name = "igracDataGridViewTextBoxColumn";
            this.igracDataGridViewTextBoxColumn.ReadOnly = true;
            this.igracDataGridViewTextBoxColumn.Width = 125;
            // 
            // dgvDomaci
            // 
            this.dgvDomaci.AllowUserToAddRows = false;
            this.dgvDomaci.AllowUserToDeleteRows = false;
            this.dgvDomaci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDomaci.AutoGenerateColumns = false;
            this.dgvDomaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDomaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.igracDataGridViewTextBoxColumn,
            this.poeniDataGridViewTextBoxColumn,
            this.skokoviDataGridViewTextBoxColumn,
            this.asistencijeDataGridViewTextBoxColumn});
            this.dgvDomaci.DataSource = this.statistikaBindingSource;
            this.dgvDomaci.Location = new System.Drawing.Point(29, 593);
            this.dgvDomaci.Name = "dgvDomaci";
            this.dgvDomaci.ReadOnly = true;
            this.dgvDomaci.RowHeadersWidth = 51;
            this.dgvDomaci.RowTemplate.Height = 24;
            this.dgvDomaci.Size = new System.Drawing.Size(764, 183);
            this.dgvDomaci.TabIndex = 36;
            // 
            // txtDomacin
            // 
            this.txtDomacin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDomacin.Location = new System.Drawing.Point(22, 34);
            this.txtDomacin.Name = "txtDomacin";
            this.txtDomacin.ReadOnly = true;
            this.txtDomacin.Size = new System.Drawing.Size(185, 22);
            this.txtDomacin.TabIndex = 0;
            // 
            // txtGost
            // 
            this.txtGost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGost.Location = new System.Drawing.Point(387, 34);
            this.txtGost.Name = "txtGost";
            this.txtGost.ReadOnly = true;
            this.txtGost.Size = new System.Drawing.Size(185, 22);
            this.txtGost.TabIndex = 1;
            // 
            // txtPoeniDomacin
            // 
            this.txtPoeniDomacin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPoeniDomacin.Location = new System.Drawing.Point(231, 34);
            this.txtPoeniDomacin.Name = "txtPoeniDomacin";
            this.txtPoeniDomacin.Size = new System.Drawing.Size(51, 22);
            this.txtPoeniDomacin.TabIndex = 2;
            // 
            // txtPoeniGost
            // 
            this.txtPoeniGost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPoeniGost.Location = new System.Drawing.Point(312, 34);
            this.txtPoeniGost.Name = "txtPoeniGost";
            this.txtPoeniGost.Size = new System.Drawing.Size(51, 22);
            this.txtPoeniGost.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datum";
            // 
            // btnPrikaziStatistiku
            // 
            this.btnPrikaziStatistiku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikaziStatistiku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrikaziStatistiku.BackgroundImage")));
            this.btnPrikaziStatistiku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrikaziStatistiku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrikaziStatistiku.Location = new System.Drawing.Point(22, 120);
            this.btnPrikaziStatistiku.Name = "btnPrikaziStatistiku";
            this.btnPrikaziStatistiku.Size = new System.Drawing.Size(208, 44);
            this.btnPrikaziStatistiku.TabIndex = 26;
            this.btnPrikaziStatistiku.Text = "Prikazi statistiku";
            this.btnPrikaziStatistiku.UseVisualStyleBackColor = true;
            this.btnPrikaziStatistiku.Click += new System.EventHandler(this.btnPrikaziStatistiku_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDatum.CustomFormat = "dd.MM.yyyy. HH:mm";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(108, 82);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(216, 22);
            this.dtpDatum.TabIndex = 27;
            this.dtpDatum.Value = new System.DateTime(2023, 1, 1, 20, 0, 0, 0);
            // 
            // gbUtakmica
            // 
            this.gbUtakmica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbUtakmica.Controls.Add(this.dtpDatum);
            this.gbUtakmica.Controls.Add(this.btnPrikaziStatistiku);
            this.gbUtakmica.Controls.Add(this.label4);
            this.gbUtakmica.Controls.Add(this.label3);
            this.gbUtakmica.Controls.Add(this.txtPoeniGost);
            this.gbUtakmica.Controls.Add(this.txtPoeniDomacin);
            this.gbUtakmica.Controls.Add(this.txtGost);
            this.gbUtakmica.Controls.Add(this.txtDomacin);
            this.gbUtakmica.Location = new System.Drawing.Point(29, 300);
            this.gbUtakmica.Name = "gbUtakmica";
            this.gbUtakmica.Size = new System.Drawing.Size(589, 201);
            this.gbUtakmica.TabIndex = 35;
            this.gbUtakmica.TabStop = false;
            this.gbUtakmica.Text = "Utakmica";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Utakmica";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tim";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // btnUcitajStatistiku
            // 
            this.btnUcitajStatistiku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUcitajStatistiku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUcitajStatistiku.BackgroundImage")));
            this.btnUcitajStatistiku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUcitajStatistiku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUcitajStatistiku.Location = new System.Drawing.Point(28, 782);
            this.btnUcitajStatistiku.Name = "btnUcitajStatistiku";
            this.btnUcitajStatistiku.Size = new System.Drawing.Size(208, 44);
            this.btnUcitajStatistiku.TabIndex = 40;
            this.btnUcitajStatistiku.Text = "Ucitaj statistiku";
            this.btnUcitajStatistiku.UseVisualStyleBackColor = true;
            this.btnUcitajStatistiku.Click += new System.EventHandler(this.btnUcitajStatistiku_Click);
            // 
            // gbStatistikaIgraca
            // 
            this.gbStatistikaIgraca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbStatistikaIgraca.Controls.Add(this.label7);
            this.gbStatistikaIgraca.Controls.Add(this.btnIzmeniStatistiku);
            this.gbStatistikaIgraca.Controls.Add(this.txtPoeni);
            this.gbStatistikaIgraca.Controls.Add(this.txtSkokovi);
            this.gbStatistikaIgraca.Controls.Add(this.txtIgrac);
            this.gbStatistikaIgraca.Controls.Add(this.label2);
            this.gbStatistikaIgraca.Controls.Add(this.label5);
            this.gbStatistikaIgraca.Controls.Add(this.label6);
            this.gbStatistikaIgraca.Controls.Add(this.txtAsistencije);
            this.gbStatistikaIgraca.Location = new System.Drawing.Point(31, 847);
            this.gbStatistikaIgraca.Name = "gbStatistikaIgraca";
            this.gbStatistikaIgraca.Size = new System.Drawing.Size(324, 283);
            this.gbStatistikaIgraca.TabIndex = 41;
            this.gbStatistikaIgraca.TabStop = false;
            this.gbStatistikaIgraca.Text = "Statistika igraca";
            // 
            // txtAsistencije
            // 
            this.txtAsistencije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAsistencije.Location = new System.Drawing.Point(99, 179);
            this.txtAsistencije.Name = "txtAsistencije";
            this.txtAsistencije.Size = new System.Drawing.Size(185, 22);
            this.txtAsistencije.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Asistencije";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Poeni";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Skokovi";
            // 
            // txtIgrac
            // 
            this.txtIgrac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIgrac.Location = new System.Drawing.Point(99, 34);
            this.txtIgrac.Name = "txtIgrac";
            this.txtIgrac.ReadOnly = true;
            this.txtIgrac.Size = new System.Drawing.Size(185, 22);
            this.txtIgrac.TabIndex = 30;
            // 
            // txtSkokovi
            // 
            this.txtSkokovi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSkokovi.Location = new System.Drawing.Point(99, 126);
            this.txtSkokovi.Name = "txtSkokovi";
            this.txtSkokovi.Size = new System.Drawing.Size(185, 22);
            this.txtSkokovi.TabIndex = 4;
            // 
            // txtPoeni
            // 
            this.txtPoeni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPoeni.Location = new System.Drawing.Point(99, 79);
            this.txtPoeni.Name = "txtPoeni";
            this.txtPoeni.Size = new System.Drawing.Size(185, 22);
            this.txtPoeni.TabIndex = 0;
            // 
            // btnIzmeniStatistiku
            // 
            this.btnIzmeniStatistiku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeniStatistiku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIzmeniStatistiku.BackgroundImage")));
            this.btnIzmeniStatistiku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIzmeniStatistiku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzmeniStatistiku.Location = new System.Drawing.Point(11, 233);
            this.btnIzmeniStatistiku.Name = "btnIzmeniStatistiku";
            this.btnIzmeniStatistiku.Size = new System.Drawing.Size(273, 44);
            this.btnIzmeniStatistiku.TabIndex = 26;
            this.btnIzmeniStatistiku.Text = "Izmeni statistiku igraca";
            this.btnIzmeniStatistiku.UseVisualStyleBackColor = true;
            this.btnIzmeniStatistiku.Click += new System.EventHandler(this.btnIzmeniStatistiku_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Igrac";
            // 
            // btnIzmeniUtakmicu
            // 
            this.btnIzmeniUtakmicu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeniUtakmicu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIzmeniUtakmicu.BackgroundImage")));
            this.btnIzmeniUtakmicu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIzmeniUtakmicu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzmeniUtakmicu.Location = new System.Drawing.Point(379, 1086);
            this.btnIzmeniUtakmicu.Name = "btnIzmeniUtakmicu";
            this.btnIzmeniUtakmicu.Size = new System.Drawing.Size(273, 44);
            this.btnIzmeniUtakmicu.TabIndex = 42;
            this.btnIzmeniUtakmicu.Text = "Izmeni utakmicu";
            this.btnIzmeniUtakmicu.UseVisualStyleBackColor = true;
            this.btnIzmeniUtakmicu.Click += new System.EventHandler(this.btnIzmeniUtakmicu_Click);
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
            this.btnUcitajUtakmicu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUcitajUtakmicu.Location = new System.Drawing.Point(32, 264);
            this.btnUcitajUtakmicu.Name = "btnUcitajUtakmicu";
            this.btnUcitajUtakmicu.Size = new System.Drawing.Size(230, 44);
            this.btnUcitajUtakmicu.TabIndex = 34;
            this.btnUcitajUtakmicu.Text = "Ucitaj utakmicu";
            this.btnUcitajUtakmicu.UseVisualStyleBackColor = true;
            this.btnUcitajUtakmicu.Click += new System.EventHandler(this.btnUcitajUtakmicu_Click);
            // 
            // dgvUtakmice
            // 
            this.dgvUtakmice.AllowUserToAddRows = false;
            this.dgvUtakmice.AllowUserToDeleteRows = false;
            this.dgvUtakmice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUtakmice.AutoGenerateColumns = false;
            this.dgvUtakmice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtakmice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.domacinDataGridViewTextBoxColumn,
            this.brojPoenaDomacinDataGridViewTextBoxColumn,
            this.brojPoenaGostDataGridViewTextBoxColumn,
            this.gostDataGridViewTextBoxColumn,
            this.datumOdigravanjaDataGridViewTextBoxColumn});
            this.dgvUtakmice.DataSource = this.utakmicaBindingSource;
            this.dgvUtakmice.Location = new System.Drawing.Point(26, 108);
            this.dgvUtakmice.Name = "dgvUtakmice";
            this.dgvUtakmice.ReadOnly = true;
            this.dgvUtakmice.RowHeadersWidth = 51;
            this.dgvUtakmice.RowTemplate.Height = 24;
            this.dgvUtakmice.Size = new System.Drawing.Size(945, 150);
            this.dgvUtakmice.TabIndex = 33;
            // 
            // datumOdigravanjaDataGridViewTextBoxColumn
            // 
            this.datumOdigravanjaDataGridViewTextBoxColumn.DataPropertyName = "DatumOdigravanja";
            this.datumOdigravanjaDataGridViewTextBoxColumn.HeaderText = "DatumOdigravanja";
            this.datumOdigravanjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumOdigravanjaDataGridViewTextBoxColumn.Name = "datumOdigravanjaDataGridViewTextBoxColumn";
            this.datumOdigravanjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumOdigravanjaDataGridViewTextBoxColumn.Width = 125;
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
            // brojPoenaGostDataGridViewTextBoxColumn
            // 
            this.brojPoenaGostDataGridViewTextBoxColumn.DataPropertyName = "BrojPoenaGost";
            this.brojPoenaGostDataGridViewTextBoxColumn.HeaderText = "BrojPoenaGost";
            this.brojPoenaGostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojPoenaGostDataGridViewTextBoxColumn.Name = "brojPoenaGostDataGridViewTextBoxColumn";
            this.brojPoenaGostDataGridViewTextBoxColumn.ReadOnly = true;
            this.brojPoenaGostDataGridViewTextBoxColumn.Width = 125;
            // 
            // brojPoenaDomacinDataGridViewTextBoxColumn
            // 
            this.brojPoenaDomacinDataGridViewTextBoxColumn.DataPropertyName = "BrojPoenaDomacin";
            this.brojPoenaDomacinDataGridViewTextBoxColumn.HeaderText = "BrojPoenaDomacin";
            this.brojPoenaDomacinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojPoenaDomacinDataGridViewTextBoxColumn.Name = "brojPoenaDomacinDataGridViewTextBoxColumn";
            this.brojPoenaDomacinDataGridViewTextBoxColumn.ReadOnly = true;
            this.brojPoenaDomacinDataGridViewTextBoxColumn.Width = 125;
            // 
            // domacinDataGridViewTextBoxColumn
            // 
            this.domacinDataGridViewTextBoxColumn.DataPropertyName = "Domacin";
            this.domacinDataGridViewTextBoxColumn.HeaderText = "Domacin";
            this.domacinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.domacinDataGridViewTextBoxColumn.Name = "domacinDataGridViewTextBoxColumn";
            this.domacinDataGridViewTextBoxColumn.ReadOnly = true;
            this.domacinDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnPronadjiUtakmice
            // 
            this.btnPronadjiUtakmice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPronadjiUtakmice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPronadjiUtakmice.BackgroundImage")));
            this.btnPronadjiUtakmice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPronadjiUtakmice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPronadjiUtakmice.Location = new System.Drawing.Point(265, 37);
            this.btnPronadjiUtakmice.Name = "btnPronadjiUtakmice";
            this.btnPronadjiUtakmice.Size = new System.Drawing.Size(230, 44);
            this.btnPronadjiUtakmice.TabIndex = 32;
            this.btnPronadjiUtakmice.Text = "Pronadji utakmice";
            this.btnPronadjiUtakmice.UseVisualStyleBackColor = true;
            this.btnPronadjiUtakmice.Click += new System.EventHandler(this.btnPronadjiUtakmice_Click);
            // 
            // cbTimovi
            // 
            this.cbTimovi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTimovi.FormattingEnabled = true;
            this.cbTimovi.Location = new System.Drawing.Point(26, 57);
            this.cbTimovi.Name = "cbTimovi";
            this.cbTimovi.Size = new System.Drawing.Size(181, 24);
            this.cbTimovi.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tim";
            // 
            // gbPretraga
            // 
            this.gbPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbPretraga.Controls.Add(this.label1);
            this.gbPretraga.Controls.Add(this.cbTimovi);
            this.gbPretraga.Controls.Add(this.btnPronadjiUtakmice);
            this.gbPretraga.Controls.Add(this.dgvUtakmice);
            this.gbPretraga.Controls.Add(this.btnUcitajUtakmicu);
            this.gbPretraga.Location = new System.Drawing.Point(29, 242);
            this.gbPretraga.Name = "gbPretraga";
            this.gbPretraga.Size = new System.Drawing.Size(1000, 330);
            this.gbPretraga.TabIndex = 43;
            this.gbPretraga.TabStop = false;
            // 
            // UCIzmenaUtakmice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.gbPretraga);
            this.Controls.Add(this.btnIzmeniUtakmicu);
            this.Controls.Add(this.gbStatistikaIgraca);
            this.Controls.Add(this.btnUcitajStatistiku);
            this.Controls.Add(this.dgvDomaci);
            this.Controls.Add(this.gbUtakmica);
            this.Controls.Add(this.dgvGosti);
            this.Controls.Add(this.lblGost);
            this.Controls.Add(this.lblDomacin);
            this.Name = "UCIzmenaUtakmice";
            this.Size = new System.Drawing.Size(1766, 1500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGosti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomaci)).EndInit();
            this.gbUtakmica.ResumeLayout(false);
            this.gbUtakmica.PerformLayout();
            this.gbStatistikaIgraca.ResumeLayout(false);
            this.gbStatistikaIgraca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utakmicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).EndInit();
            this.gbPretraga.ResumeLayout(false);
            this.gbPretraga.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDomacin;
        private Label lblGost;
        private DataGridView dgvGosti;
        private DataGridViewTextBoxColumn igracDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn poeniDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn skokoviDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn asistencijeDataGridViewTextBoxColumn1;
        private BindingSource statistikaBindingSource;
        private DataGridViewTextBoxColumn asistencijeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn skokoviDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn poeniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn igracDataGridViewTextBoxColumn;
        private DataGridView dgvDomaci;
        private TextBox txtDomacin;
        private TextBox txtGost;
        private TextBox txtPoeniDomacin;
        private TextBox txtPoeniGost;
        private Label label3;
        private Label label4;
        private Button btnPrikaziStatistiku;
        private DateTimePicker dtpDatum;
        private GroupBox gbUtakmica;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button btnUcitajStatistiku;
        private GroupBox gbStatistikaIgraca;
        private Label label7;
        private Button btnIzmeniStatistiku;
        private TextBox txtPoeni;
        private TextBox txtSkokovi;
        private TextBox txtIgrac;
        private Label label2;
        private Label label5;
        private Label label6;
        private TextBox txtAsistencije;
        private Button btnIzmeniUtakmicu;
        private BindingSource utakmicaBindingSource;
        private Button btnUcitajUtakmicu;
        private DataGridView dgvUtakmice;
        private DataGridViewTextBoxColumn domacinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brojPoenaDomacinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brojPoenaGostDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gostDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datumOdigravanjaDataGridViewTextBoxColumn;
        private Button btnPronadjiUtakmice;
        private ComboBox cbTimovi;
        private Label label1;
        private GroupBox gbPretraga;

        public Button BtnPrikaziStatistiku { get => btnPrikaziStatistiku; set => btnPrikaziStatistiku = value; }
        public DataGridView DgvDomaci { get => dgvDomaci; set => dgvDomaci = value; }
        public DataGridView DgvGosti { get => dgvGosti; set => dgvGosti = value; }
        public Label LblGost { get => lblGost; set => lblGost = value; }
        public TextBox TxtPoeniGost { get => txtPoeniGost; set => txtPoeniGost = value; }
        public TextBox TxtGost { get => txtGost; set => txtGost = value; }
        public TextBox TxtDomacin { get => txtDomacin; set => txtDomacin = value; }
        public Label LblDomacin { get => lblDomacin; set => lblDomacin = value; }
        public TextBox TxtPoeniDomacin { get => txtPoeniDomacin; set => txtPoeniDomacin = value; }
        public Button BtnUcitajUtakmicu { get => btnUcitajUtakmicu; set => btnUcitajUtakmicu = value; }
        public DataGridView DgvUtakmice { get => dgvUtakmice; set => dgvUtakmice = value; }
        public ComboBox CbTimovi { get => cbTimovi; set => cbTimovi = value; }
        public Button BtnPronadjiUtakmice { get => btnPronadjiUtakmice; set => btnPronadjiUtakmice = value; }
        public Button BtnUcitajStatistiku { get => btnUcitajStatistiku; set => btnUcitajStatistiku = value; }
        public Button BtnIzmeniStatistiku { get => btnIzmeniStatistiku; set => btnIzmeniStatistiku = value; }
        public TextBox TxtIgrac { get => txtIgrac; set => txtIgrac = value; }
        public TextBox TxtAsistencije { get => txtAsistencije; set => txtAsistencije = value; }
        public TextBox TxtSkokovi { get => txtSkokovi; set => txtSkokovi = value; }
        public TextBox TxtPoeni { get => txtPoeni; set => txtPoeni = value; }
        public GroupBox GbStatistikaIgraca { get => gbStatistikaIgraca; set => gbStatistikaIgraca = value; }
        public DateTimePicker DtpDatum { get => dtpDatum; set => dtpDatum = value; }
        public Button BtnIzmeniUtakmicu { get => btnIzmeniUtakmicu; set => btnIzmeniUtakmicu = value; }
        public GroupBox GbUtakmica { get => gbUtakmica; set => gbUtakmica = value; }
        public GroupBox GbPretraga { get => gbPretraga; set => gbPretraga = value; }
    }
}
