
using System.Windows.Forms;

namespace Client.Forms.UserControls.Utakmica
{
    partial class UCPretragaUtakmica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPretragaUtakmica));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPronadjiUtakmice = new System.Windows.Forms.Button();
            this.cbTimovi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBrojGledalaca = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnPrikaziStatistiku = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtPoeniGost = new System.Windows.Forms.TextBox();
            this.txtPoeniDomacin = new System.Windows.Forms.TextBox();
            this.txtGost = new System.Windows.Forms.TextBox();
            this.txtDomacin = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDomaci = new System.Windows.Forms.DataGridView();
            this.igracDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skokoviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asistencijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statistikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvGosti = new System.Windows.Forms.DataGridView();
            this.igracDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poeniDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skokoviDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asistencijeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDomacin = new System.Windows.Forms.Label();
            this.lblGost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utakmicaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGosti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPronadjiUtakmice
            // 
            this.btnPronadjiUtakmice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPronadjiUtakmice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPronadjiUtakmice.BackgroundImage")));
            this.btnPronadjiUtakmice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPronadjiUtakmice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPronadjiUtakmice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPronadjiUtakmice.Location = new System.Drawing.Point(326, 67);
            this.btnPronadjiUtakmice.Name = "btnPronadjiUtakmice";
            this.btnPronadjiUtakmice.Size = new System.Drawing.Size(264, 44);
            this.btnPronadjiUtakmice.TabIndex = 22;
            this.btnPronadjiUtakmice.Text = "Pronađi utakmice";
            this.btnPronadjiUtakmice.UseVisualStyleBackColor = true;
            this.btnPronadjiUtakmice.Click += new System.EventHandler(this.btnPronadjiUtakmice_Click);
            // 
            // cbTimovi
            // 
            this.cbTimovi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTimovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimovi.FormattingEnabled = true;
            this.cbTimovi.Location = new System.Drawing.Point(50, 83);
            this.cbTimovi.Name = "cbTimovi";
            this.cbTimovi.Size = new System.Drawing.Size(230, 28);
            this.cbTimovi.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tim";
            // 
            // dgvUtakmice
            // 
            this.dgvUtakmice.AllowUserToAddRows = false;
            this.dgvUtakmice.AllowUserToDeleteRows = false;
            this.dgvUtakmice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUtakmice.AutoGenerateColumns = false;
            this.dgvUtakmice.BackgroundColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUtakmice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUtakmice.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUtakmice.Location = new System.Drawing.Point(50, 134);
            this.dgvUtakmice.Name = "dgvUtakmice";
            this.dgvUtakmice.ReadOnly = true;
            this.dgvUtakmice.RowHeadersWidth = 51;
            this.dgvUtakmice.RowTemplate.Height = 24;
            this.dgvUtakmice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUtakmice.Size = new System.Drawing.Size(1570, 150);
            this.dgvUtakmice.TabIndex = 23;
            // 
            // takmicenjeDataGridViewTextBoxColumn
            // 
            this.takmicenjeDataGridViewTextBoxColumn.DataPropertyName = "Takmicenje";
            this.takmicenjeDataGridViewTextBoxColumn.HeaderText = "Takmicenje";
            this.takmicenjeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.takmicenjeDataGridViewTextBoxColumn.Name = "takmicenjeDataGridViewTextBoxColumn";
            this.takmicenjeDataGridViewTextBoxColumn.ReadOnly = true;
            this.takmicenjeDataGridViewTextBoxColumn.Width = 125;
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
            // brojPoenaDomacinDataGridViewTextBoxColumn
            // 
            this.brojPoenaDomacinDataGridViewTextBoxColumn.DataPropertyName = "BrojPoenaDomacin";
            this.brojPoenaDomacinDataGridViewTextBoxColumn.HeaderText = "Broj poena domacin";
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
            this.fazaTakmicenjaDataGridViewTextBoxColumn.HeaderText = "Faza takmicenja";
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
            this.btnUcitajUtakmicu.Location = new System.Drawing.Point(50, 311);
            this.btnUcitajUtakmicu.Name = "btnUcitajUtakmicu";
            this.btnUcitajUtakmicu.Size = new System.Drawing.Size(282, 44);
            this.btnUcitajUtakmicu.TabIndex = 24;
            this.btnUcitajUtakmicu.Text = "Učitaj utakmicu";
            this.btnUcitajUtakmicu.UseVisualStyleBackColor = true;
            this.btnUcitajUtakmicu.Click += new System.EventHandler(this.btnUcitajUtakmicu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Controls.Add(this.txtBrojGledalaca);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnPrikaziStatistiku);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDatum);
            this.groupBox1.Controls.Add(this.txtPoeniGost);
            this.groupBox1.Controls.Add(this.txtPoeniDomacin);
            this.groupBox1.Controls.Add(this.txtGost);
            this.groupBox1.Controls.Add(this.txtDomacin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 246);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utakmica";
            // 
            // txtBrojGledalaca
            // 
            this.txtBrojGledalaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojGledalaca.Location = new System.Drawing.Point(180, 142);
            this.txtBrojGledalaca.MaxLength = 3;
            this.txtBrojGledalaca.Multiline = true;
            this.txtBrojGledalaca.Name = "txtBrojGledalaca";
            this.txtBrojGledalaca.ReadOnly = true;
            this.txtBrojGledalaca.Size = new System.Drawing.Size(242, 27);
            this.txtBrojGledalaca.TabIndex = 28;
            this.txtBrojGledalaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.OrangeRed;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Broj gledalaca";
            // 
            // btnPrikaziStatistiku
            // 
            this.btnPrikaziStatistiku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikaziStatistiku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrikaziStatistiku.BackgroundImage")));
            this.btnPrikaziStatistiku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrikaziStatistiku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrikaziStatistiku.Location = new System.Drawing.Point(22, 183);
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
            this.label4.Location = new System.Drawing.Point(30, 94);
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
            this.label3.Location = new System.Drawing.Point(288, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // txtDatum
            // 
            this.txtDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatum.Location = new System.Drawing.Point(180, 91);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(242, 27);
            this.txtDatum.TabIndex = 4;
            // 
            // txtPoeniGost
            // 
            this.txtPoeniGost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPoeniGost.Location = new System.Drawing.Point(312, 41);
            this.txtPoeniGost.Name = "txtPoeniGost";
            this.txtPoeniGost.ReadOnly = true;
            this.txtPoeniGost.Size = new System.Drawing.Size(51, 27);
            this.txtPoeniGost.TabIndex = 3;
            this.txtPoeniGost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPoeniDomacin
            // 
            this.txtPoeniDomacin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPoeniDomacin.Location = new System.Drawing.Point(231, 41);
            this.txtPoeniDomacin.Name = "txtPoeniDomacin";
            this.txtPoeniDomacin.ReadOnly = true;
            this.txtPoeniDomacin.Size = new System.Drawing.Size(51, 27);
            this.txtPoeniDomacin.TabIndex = 2;
            this.txtPoeniDomacin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGost
            // 
            this.txtGost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGost.Location = new System.Drawing.Point(387, 41);
            this.txtGost.Name = "txtGost";
            this.txtGost.ReadOnly = true;
            this.txtGost.Size = new System.Drawing.Size(185, 27);
            this.txtGost.TabIndex = 1;
            this.txtGost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDomacin
            // 
            this.txtDomacin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDomacin.Location = new System.Drawing.Point(22, 41);
            this.txtDomacin.Name = "txtDomacin";
            this.txtDomacin.ReadOnly = true;
            this.txtDomacin.Size = new System.Drawing.Size(185, 27);
            this.txtDomacin.TabIndex = 0;
            this.txtDomacin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Utakmica";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tim";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dgvDomaci
            // 
            this.dgvDomaci.AllowUserToAddRows = false;
            this.dgvDomaci.AllowUserToDeleteRows = false;
            this.dgvDomaci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDomaci.AutoGenerateColumns = false;
            this.dgvDomaci.BackgroundColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDomaci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDomaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDomaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.igracDataGridViewTextBoxColumn,
            this.poeniDataGridViewTextBoxColumn,
            this.skokoviDataGridViewTextBoxColumn,
            this.asistencijeDataGridViewTextBoxColumn});
            this.dgvDomaci.DataSource = this.statistikaBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDomaci.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDomaci.Location = new System.Drawing.Point(948, 364);
            this.dgvDomaci.Name = "dgvDomaci";
            this.dgvDomaci.ReadOnly = true;
            this.dgvDomaci.RowHeadersWidth = 51;
            this.dgvDomaci.RowTemplate.Height = 24;
            this.dgvDomaci.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDomaci.Size = new System.Drawing.Size(672, 183);
            this.dgvDomaci.TabIndex = 26;
            // 
            // igracDataGridViewTextBoxColumn
            // 
            this.igracDataGridViewTextBoxColumn.DataPropertyName = "Igrac";
            this.igracDataGridViewTextBoxColumn.HeaderText = "Igrač";
            this.igracDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.igracDataGridViewTextBoxColumn.Name = "igracDataGridViewTextBoxColumn";
            this.igracDataGridViewTextBoxColumn.ReadOnly = true;
            this.igracDataGridViewTextBoxColumn.Width = 120;
            // 
            // poeniDataGridViewTextBoxColumn
            // 
            this.poeniDataGridViewTextBoxColumn.DataPropertyName = "Poeni";
            this.poeniDataGridViewTextBoxColumn.HeaderText = "Poeni";
            this.poeniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.poeniDataGridViewTextBoxColumn.Name = "poeniDataGridViewTextBoxColumn";
            this.poeniDataGridViewTextBoxColumn.ReadOnly = true;
            this.poeniDataGridViewTextBoxColumn.Width = 110;
            // 
            // skokoviDataGridViewTextBoxColumn
            // 
            this.skokoviDataGridViewTextBoxColumn.DataPropertyName = "Skokovi";
            this.skokoviDataGridViewTextBoxColumn.HeaderText = "Skokovi";
            this.skokoviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.skokoviDataGridViewTextBoxColumn.Name = "skokoviDataGridViewTextBoxColumn";
            this.skokoviDataGridViewTextBoxColumn.ReadOnly = true;
            this.skokoviDataGridViewTextBoxColumn.Width = 110;
            // 
            // asistencijeDataGridViewTextBoxColumn
            // 
            this.asistencijeDataGridViewTextBoxColumn.DataPropertyName = "Asistencije";
            this.asistencijeDataGridViewTextBoxColumn.HeaderText = "Asistencije";
            this.asistencijeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.asistencijeDataGridViewTextBoxColumn.Name = "asistencijeDataGridViewTextBoxColumn";
            this.asistencijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.asistencijeDataGridViewTextBoxColumn.Width = 110;
            // 
            // statistikaBindingSource
            // 
            this.statistikaBindingSource.DataSource = typeof(Common.Domain.Statistika);
            // 
            // dgvGosti
            // 
            this.dgvGosti.AllowUserToAddRows = false;
            this.dgvGosti.AllowUserToDeleteRows = false;
            this.dgvGosti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvGosti.AutoGenerateColumns = false;
            this.dgvGosti.BackgroundColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGosti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGosti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.igracDataGridViewTextBoxColumn1,
            this.poeniDataGridViewTextBoxColumn1,
            this.skokoviDataGridViewTextBoxColumn1,
            this.asistencijeDataGridViewTextBoxColumn1});
            this.dgvGosti.DataSource = this.statistikaBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGosti.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGosti.Location = new System.Drawing.Point(948, 607);
            this.dgvGosti.Name = "dgvGosti";
            this.dgvGosti.ReadOnly = true;
            this.dgvGosti.RowHeadersWidth = 51;
            this.dgvGosti.RowTemplate.Height = 24;
            this.dgvGosti.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvGosti.Size = new System.Drawing.Size(672, 183);
            this.dgvGosti.TabIndex = 27;
            // 
            // igracDataGridViewTextBoxColumn1
            // 
            this.igracDataGridViewTextBoxColumn1.DataPropertyName = "Igrac";
            this.igracDataGridViewTextBoxColumn1.HeaderText = "Igrač";
            this.igracDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.igracDataGridViewTextBoxColumn1.Name = "igracDataGridViewTextBoxColumn1";
            this.igracDataGridViewTextBoxColumn1.ReadOnly = true;
            this.igracDataGridViewTextBoxColumn1.Width = 120;
            // 
            // poeniDataGridViewTextBoxColumn1
            // 
            this.poeniDataGridViewTextBoxColumn1.DataPropertyName = "Poeni";
            this.poeniDataGridViewTextBoxColumn1.HeaderText = "Poeni";
            this.poeniDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.poeniDataGridViewTextBoxColumn1.Name = "poeniDataGridViewTextBoxColumn1";
            this.poeniDataGridViewTextBoxColumn1.ReadOnly = true;
            this.poeniDataGridViewTextBoxColumn1.Width = 110;
            // 
            // skokoviDataGridViewTextBoxColumn1
            // 
            this.skokoviDataGridViewTextBoxColumn1.DataPropertyName = "Skokovi";
            this.skokoviDataGridViewTextBoxColumn1.HeaderText = "Skokovi";
            this.skokoviDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.skokoviDataGridViewTextBoxColumn1.Name = "skokoviDataGridViewTextBoxColumn1";
            this.skokoviDataGridViewTextBoxColumn1.ReadOnly = true;
            this.skokoviDataGridViewTextBoxColumn1.Width = 110;
            // 
            // asistencijeDataGridViewTextBoxColumn1
            // 
            this.asistencijeDataGridViewTextBoxColumn1.DataPropertyName = "Asistencije";
            this.asistencijeDataGridViewTextBoxColumn1.HeaderText = "Asistencije";
            this.asistencijeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.asistencijeDataGridViewTextBoxColumn1.Name = "asistencijeDataGridViewTextBoxColumn1";
            this.asistencijeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.asistencijeDataGridViewTextBoxColumn1.Width = 110;
            // 
            // lblDomacin
            // 
            this.lblDomacin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDomacin.AutoSize = true;
            this.lblDomacin.BackColor = System.Drawing.Color.OrangeRed;
            this.lblDomacin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomacin.Location = new System.Drawing.Point(910, 325);
            this.lblDomacin.Name = "lblDomacin";
            this.lblDomacin.Size = new System.Drawing.Size(0, 20);
            this.lblDomacin.TabIndex = 28;
            this.lblDomacin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGost
            // 
            this.lblGost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGost.AutoSize = true;
            this.lblGost.BackColor = System.Drawing.Color.OrangeRed;
            this.lblGost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGost.Location = new System.Drawing.Point(910, 573);
            this.lblGost.Name = "lblGost";
            this.lblGost.Size = new System.Drawing.Size(0, 20);
            this.lblGost.TabIndex = 29;
            this.lblGost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCPretragaUtakmica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblGost);
            this.Controls.Add(this.lblDomacin);
            this.Controls.Add(this.dgvGosti);
            this.Controls.Add(this.dgvDomaci);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUcitajUtakmicu);
            this.Controls.Add(this.dgvUtakmice);
            this.Controls.Add(this.btnPronadjiUtakmice);
            this.Controls.Add(this.cbTimovi);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "UCPretragaUtakmica";
            this.Size = new System.Drawing.Size(1781, 804);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utakmicaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGosti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPronadjiUtakmice;
        private System.Windows.Forms.ComboBox cbTimovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUtakmice;
        private System.Windows.Forms.Button btnUcitajUtakmicu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtPoeniGost;
        private System.Windows.Forms.TextBox txtPoeniDomacin;
        private System.Windows.Forms.TextBox txtGost;
        private System.Windows.Forms.TextBox txtDomacin;
        private System.Windows.Forms.Label label4;
        private Button btnPrikaziStatistiku;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridView dgvDomaci;
        private DataGridView dgvGosti;
        private BindingSource statistikaBindingSource;
        private Label lblDomacin;
        private Label lblGost;
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
        private BindingSource utakmicaBindingSource;
        private DataGridViewTextBoxColumn takmicenjeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn domacinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brojPoenaDomacinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brojPoenaGostDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gostDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datumOdigravanjaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brojGledalacaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rundaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fazaTakmicenjaDataGridViewTextBoxColumn;

        public ComboBox CbTimovi { get => cbTimovi; set => cbTimovi = value; }
        public DataGridView DgvUtakmice { get => dgvUtakmice; set => dgvUtakmice = value; }
        public Button BtnUcitajUtakmicu { get => btnUcitajUtakmicu; set => btnUcitajUtakmicu = value; }
        public TextBox TxtDatum { get => txtDatum; set => txtDatum = value; }
        public TextBox TxtPoeniGost { get => txtPoeniGost; set => txtPoeniGost = value; }
        public TextBox TxtPoeniDomacin { get => txtPoeniDomacin; set => txtPoeniDomacin = value; }
        public TextBox TxtGost { get => txtGost; set => txtGost = value; }
        public TextBox TxtDomacin { get => txtDomacin; set => txtDomacin = value; }
        public Button BtnPrikaziStatistiku { get => btnPrikaziStatistiku; set => btnPrikaziStatistiku = value; }
        public DataGridView DgvDomaci { get => dgvDomaci; set => dgvDomaci = value; }
        public DataGridView DgvGosti { get => dgvGosti; set => dgvGosti = value; }
        public Label LblDomacin { get => lblDomacin; set => lblDomacin = value; }
        public Label LblGost { get => lblGost; set => lblGost = value; }
        public TextBox TxtBrojGledalaca { get => txtBrojGledalaca; set => txtBrojGledalaca = value; }
    }
}
