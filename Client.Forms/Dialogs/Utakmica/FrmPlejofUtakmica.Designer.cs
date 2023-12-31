﻿
using System.Windows.Forms;

namespace Client.Forms.Dialogs.Utakmica
{
    partial class FrmPlejofUtakmica
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlejofUtakmica));
            this.nudRunda = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAsistencijeGostIgrac = new System.Windows.Forms.TextBox();
            this.txtSkokoviGostIgrac = new System.Windows.Forms.TextBox();
            this.txtPoeniGostIgrac = new System.Windows.Forms.TextBox();
            this.btnDodajStatistikuGost = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbIgracGosta = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUcitajIgrace = new System.Windows.Forms.Button();
            this.btnSacuvajUtakmicu = new System.Windows.Forms.Button();
            this.txtBrojGledalaca = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAsistencijeDomacinIgrac = new System.Windows.Forms.TextBox();
            this.txtSkokoviDomacinIgrac = new System.Windows.Forms.TextBox();
            this.txtPoeniDomacinIgrac = new System.Windows.Forms.TextBox();
            this.btnDodajStatistikuDomacin = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbIgracDomacina = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrojPoenaGost = new System.Windows.Forms.TextBox();
            this.txtBrojPoenaDomacin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTim1 = new System.Windows.Forms.TextBox();
            this.txtTim2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunda)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudRunda
            // 
            this.nudRunda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudRunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRunda.Location = new System.Drawing.Point(253, 179);
            this.nudRunda.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRunda.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRunda.Name = "nudRunda";
            this.nudRunda.Size = new System.Drawing.Size(58, 27);
            this.nudRunda.TabIndex = 51;
            this.nudRunda.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.OrangeRed;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(145, 186);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 50;
            this.label14.Text = "Runda";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.OrangeRed;
            this.groupBox2.Controls.Add(this.txtAsistencijeGostIgrac);
            this.groupBox2.Controls.Add(this.txtSkokoviGostIgrac);
            this.groupBox2.Controls.Add(this.txtPoeniGostIgrac);
            this.groupBox2.Controls.Add(this.btnDodajStatistikuGost);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbIgracGosta);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(807, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 332);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistika igrača gost";
            // 
            // txtAsistencijeGostIgrac
            // 
            this.txtAsistencijeGostIgrac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAsistencijeGostIgrac.Location = new System.Drawing.Point(151, 219);
            this.txtAsistencijeGostIgrac.MaxLength = 3;
            this.txtAsistencijeGostIgrac.Name = "txtAsistencijeGostIgrac";
            this.txtAsistencijeGostIgrac.Size = new System.Drawing.Size(53, 27);
            this.txtAsistencijeGostIgrac.TabIndex = 23;
            this.txtAsistencijeGostIgrac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSkokoviGostIgrac
            // 
            this.txtSkokoviGostIgrac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSkokoviGostIgrac.Location = new System.Drawing.Point(151, 176);
            this.txtSkokoviGostIgrac.MaxLength = 3;
            this.txtSkokoviGostIgrac.Name = "txtSkokoviGostIgrac";
            this.txtSkokoviGostIgrac.Size = new System.Drawing.Size(53, 27);
            this.txtSkokoviGostIgrac.TabIndex = 22;
            this.txtSkokoviGostIgrac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPoeniGostIgrac
            // 
            this.txtPoeniGostIgrac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPoeniGostIgrac.Location = new System.Drawing.Point(151, 125);
            this.txtPoeniGostIgrac.MaxLength = 3;
            this.txtPoeniGostIgrac.Name = "txtPoeniGostIgrac";
            this.txtPoeniGostIgrac.Size = new System.Drawing.Size(53, 27);
            this.txtPoeniGostIgrac.TabIndex = 21;
            this.txtPoeniGostIgrac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDodajStatistikuGost
            // 
            this.btnDodajStatistikuGost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajStatistikuGost.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodajStatistikuGost.BackgroundImage")));
            this.btnDodajStatistikuGost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDodajStatistikuGost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajStatistikuGost.Location = new System.Drawing.Point(22, 272);
            this.btnDodajStatistikuGost.Name = "btnDodajStatistikuGost";
            this.btnDodajStatistikuGost.Size = new System.Drawing.Size(313, 44);
            this.btnDodajStatistikuGost.TabIndex = 20;
            this.btnDodajStatistikuGost.Text = "Dodaj statistiku igrača";
            this.btnDodajStatistikuGost.UseVisualStyleBackColor = true;
            this.btnDodajStatistikuGost.Click += new System.EventHandler(this.btnDodajStatistikuGost_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Asistencije";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Skokovi";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Poeni";
            // 
            // cbIgracGosta
            // 
            this.cbIgracGosta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbIgracGosta.FormattingEnabled = true;
            this.cbIgracGosta.Location = new System.Drawing.Point(23, 77);
            this.cbIgracGosta.Name = "cbIgracGosta";
            this.cbIgracGosta.Size = new System.Drawing.Size(283, 28);
            this.cbIgracGosta.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Igrač";
            // 
            // btnUcitajIgrace
            // 
            this.btnUcitajIgrace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUcitajIgrace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUcitajIgrace.BackgroundImage")));
            this.btnUcitajIgrace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUcitajIgrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitajIgrace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUcitajIgrace.Location = new System.Drawing.Point(925, 57);
            this.btnUcitajIgrace.Name = "btnUcitajIgrace";
            this.btnUcitajIgrace.Size = new System.Drawing.Size(247, 44);
            this.btnUcitajIgrace.TabIndex = 47;
            this.btnUcitajIgrace.Text = "Učitaj igrače";
            this.btnUcitajIgrace.UseVisualStyleBackColor = true;
            this.btnUcitajIgrace.Click += new System.EventHandler(this.btnUcitajIgrace_Click);
            // 
            // btnSacuvajUtakmicu
            // 
            this.btnSacuvajUtakmicu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvajUtakmicu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSacuvajUtakmicu.BackgroundImage")));
            this.btnSacuvajUtakmicu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSacuvajUtakmicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajUtakmicu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSacuvajUtakmicu.Location = new System.Drawing.Point(148, 604);
            this.btnSacuvajUtakmicu.Name = "btnSacuvajUtakmicu";
            this.btnSacuvajUtakmicu.Size = new System.Drawing.Size(365, 44);
            this.btnSacuvajUtakmicu.TabIndex = 46;
            this.btnSacuvajUtakmicu.Text = "Sačuvaj utakmicu i statistiku";
            this.btnSacuvajUtakmicu.UseVisualStyleBackColor = true;
            this.btnSacuvajUtakmicu.Click += new System.EventHandler(this.btnSacuvajUtakmicu_Click);
            // 
            // txtBrojGledalaca
            // 
            this.txtBrojGledalaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojGledalaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojGledalaca.Location = new System.Drawing.Point(976, 127);
            this.txtBrojGledalaca.MaxLength = 5;
            this.txtBrojGledalaca.Multiline = true;
            this.txtBrojGledalaca.Name = "txtBrojGledalaca";
            this.txtBrojGledalaca.Size = new System.Drawing.Size(196, 27);
            this.txtBrojGledalaca.TabIndex = 49;
            this.txtBrojGledalaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.OrangeRed;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(803, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 20);
            this.label13.TabIndex = 48;
            this.label13.Text = "Broj gledalaca";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Controls.Add(this.txtAsistencijeDomacinIgrac);
            this.groupBox1.Controls.Add(this.txtSkokoviDomacinIgrac);
            this.groupBox1.Controls.Add(this.txtPoeniDomacinIgrac);
            this.groupBox1.Controls.Add(this.btnDodajStatistikuDomacin);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbIgracDomacina);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(148, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 332);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistika igrača domaćin";
            // 
            // txtAsistencijeDomacinIgrac
            // 
            this.txtAsistencijeDomacinIgrac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAsistencijeDomacinIgrac.Location = new System.Drawing.Point(150, 219);
            this.txtAsistencijeDomacinIgrac.MaxLength = 3;
            this.txtAsistencijeDomacinIgrac.Name = "txtAsistencijeDomacinIgrac";
            this.txtAsistencijeDomacinIgrac.Size = new System.Drawing.Size(53, 27);
            this.txtAsistencijeDomacinIgrac.TabIndex = 14;
            this.txtAsistencijeDomacinIgrac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSkokoviDomacinIgrac
            // 
            this.txtSkokoviDomacinIgrac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSkokoviDomacinIgrac.Location = new System.Drawing.Point(150, 176);
            this.txtSkokoviDomacinIgrac.MaxLength = 3;
            this.txtSkokoviDomacinIgrac.Name = "txtSkokoviDomacinIgrac";
            this.txtSkokoviDomacinIgrac.Size = new System.Drawing.Size(53, 27);
            this.txtSkokoviDomacinIgrac.TabIndex = 13;
            this.txtSkokoviDomacinIgrac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPoeniDomacinIgrac
            // 
            this.txtPoeniDomacinIgrac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPoeniDomacinIgrac.Location = new System.Drawing.Point(150, 125);
            this.txtPoeniDomacinIgrac.MaxLength = 3;
            this.txtPoeniDomacinIgrac.Name = "txtPoeniDomacinIgrac";
            this.txtPoeniDomacinIgrac.Size = new System.Drawing.Size(53, 27);
            this.txtPoeniDomacinIgrac.TabIndex = 12;
            this.txtPoeniDomacinIgrac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDodajStatistikuDomacin
            // 
            this.btnDodajStatistikuDomacin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajStatistikuDomacin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodajStatistikuDomacin.BackgroundImage")));
            this.btnDodajStatistikuDomacin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDodajStatistikuDomacin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajStatistikuDomacin.Location = new System.Drawing.Point(24, 272);
            this.btnDodajStatistikuDomacin.Name = "btnDodajStatistikuDomacin";
            this.btnDodajStatistikuDomacin.Size = new System.Drawing.Size(313, 44);
            this.btnDodajStatistikuDomacin.TabIndex = 11;
            this.btnDodajStatistikuDomacin.Text = "Dodaj statistiku igrača";
            this.btnDodajStatistikuDomacin.UseVisualStyleBackColor = true;
            this.btnDodajStatistikuDomacin.Click += new System.EventHandler(this.btnDodajStatistikuDomacin_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Asistencije";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Skokovi";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Poeni";
            // 
            // cbIgracDomacina
            // 
            this.cbIgracDomacina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbIgracDomacina.FormattingEnabled = true;
            this.cbIgracDomacina.Location = new System.Drawing.Point(22, 77);
            this.cbIgracDomacina.Name = "cbIgracDomacina";
            this.cbIgracDomacina.Size = new System.Drawing.Size(283, 28);
            this.cbIgracDomacina.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Igrač";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDatum.CustomFormat = "dd.MM.yyyy. HH:mm";
            this.dtpDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(363, 127);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(247, 27);
            this.dtpDatum.TabIndex = 43;
            this.dtpDatum.Value = new System.DateTime(2023, 1, 1, 20, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.OrangeRed;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Datum odigravanja";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OrangeRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = ":";
            // 
            // txtBrojPoenaGost
            // 
            this.txtBrojPoenaGost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojPoenaGost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojPoenaGost.Location = new System.Drawing.Point(532, 72);
            this.txtBrojPoenaGost.MaxLength = 3;
            this.txtBrojPoenaGost.Name = "txtBrojPoenaGost";
            this.txtBrojPoenaGost.Size = new System.Drawing.Size(53, 27);
            this.txtBrojPoenaGost.TabIndex = 38;
            this.txtBrojPoenaGost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBrojPoenaDomacin
            // 
            this.txtBrojPoenaDomacin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojPoenaDomacin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojPoenaDomacin.Location = new System.Drawing.Point(448, 72);
            this.txtBrojPoenaDomacin.MaxLength = 3;
            this.txtBrojPoenaDomacin.Name = "txtBrojPoenaDomacin";
            this.txtBrojPoenaDomacin.Size = new System.Drawing.Size(53, 27);
            this.txtBrojPoenaDomacin.TabIndex = 37;
            this.txtBrojPoenaDomacin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(831, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Gost";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Domaćin";
            // 
            // txtTim1
            // 
            this.txtTim1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTim1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim1.Location = new System.Drawing.Point(147, 72);
            this.txtTim1.MaxLength = 5;
            this.txtTim1.Multiline = true;
            this.txtTim1.Name = "txtTim1";
            this.txtTim1.ReadOnly = true;
            this.txtTim1.Size = new System.Drawing.Size(229, 27);
            this.txtTim1.TabIndex = 52;
            this.txtTim1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTim2
            // 
            this.txtTim2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTim2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim2.Location = new System.Drawing.Point(651, 72);
            this.txtTim2.MaxLength = 5;
            this.txtTim2.Multiline = true;
            this.txtTim2.Name = "txtTim2";
            this.txtTim2.ReadOnly = true;
            this.txtTim2.Size = new System.Drawing.Size(229, 27);
            this.txtTim2.TabIndex = 53;
            this.txtTim2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmPlejofUtakmica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1317, 788);
            this.Controls.Add(this.txtTim2);
            this.Controls.Add(this.txtTim1);
            this.Controls.Add(this.nudRunda);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnUcitajIgrace);
            this.Controls.Add(this.btnSacuvajUtakmicu);
            this.Controls.Add(this.txtBrojGledalaca);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBrojPoenaGost);
            this.Controls.Add(this.txtBrojPoenaDomacin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPlejofUtakmica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj utakmicu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUtakmica_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nudRunda)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudRunda;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAsistencijeGostIgrac;
        private System.Windows.Forms.TextBox txtSkokoviGostIgrac;
        private System.Windows.Forms.TextBox txtPoeniGostIgrac;
        private System.Windows.Forms.Button btnDodajStatistikuGost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbIgracGosta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUcitajIgrace;
        private System.Windows.Forms.Button btnSacuvajUtakmicu;
        private System.Windows.Forms.TextBox txtBrojGledalaca;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAsistencijeDomacinIgrac;
        private System.Windows.Forms.TextBox txtSkokoviDomacinIgrac;
        private System.Windows.Forms.TextBox txtPoeniDomacinIgrac;
        private System.Windows.Forms.Button btnDodajStatistikuDomacin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbIgracDomacina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrojPoenaGost;
        private System.Windows.Forms.TextBox txtBrojPoenaDomacin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TextBox txtTim1;
        private TextBox txtTim2;

        public NumericUpDown NudRunda { get => nudRunda; set => nudRunda = value; }
        public Label Label14 { get => label14; set => label14 = value; }
        public GroupBox GroupBox2 { get => groupBox2; set => groupBox2 = value; }
        public TextBox TxtAsistencijeGostIgrac { get => txtAsistencijeGostIgrac; set => txtAsistencijeGostIgrac = value; }
        public TextBox TxtSkokoviGostIgrac { get => txtSkokoviGostIgrac; set => txtSkokoviGostIgrac = value; }
        public TextBox TxtPoeniGostIgrac { get => txtPoeniGostIgrac; set => txtPoeniGostIgrac = value; }
        public Button BtnDodajStatistikuGost { get => btnDodajStatistikuGost; set => btnDodajStatistikuGost = value; }
        public Label Label9 { get => label9; set => label9 = value; }
        public Label Label10 { get => label10; set => label10 = value; }
        public Label Label11 { get => label11; set => label11 = value; }
        public ComboBox CbIgracGosta { get => cbIgracGosta; set => cbIgracGosta = value; }
        public Label Label12 { get => label12; set => label12 = value; }
        public Button BtnUcitajIgrace { get => btnUcitajIgrace; set => btnUcitajIgrace = value; }
        public Button BtnSacuvajUtakmicu { get => btnSacuvajUtakmicu; set => btnSacuvajUtakmicu = value; }
        public TextBox TxtBrojGledalaca { get => txtBrojGledalaca; set => txtBrojGledalaca = value; }
        public Label Label13 { get => label13; set => label13 = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public TextBox TxtAsistencijeDomacinIgrac { get => txtAsistencijeDomacinIgrac; set => txtAsistencijeDomacinIgrac = value; }
        public TextBox TxtSkokoviDomacinIgrac { get => txtSkokoviDomacinIgrac; set => txtSkokoviDomacinIgrac = value; }
        public TextBox TxtPoeniDomacinIgrac { get => txtPoeniDomacinIgrac; set => txtPoeniDomacinIgrac = value; }
        public Button BtnDodajStatistikuDomacin { get => btnDodajStatistikuDomacin; set => btnDodajStatistikuDomacin = value; }
        public Label Label8 { get => label8; set => label8 = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public ComboBox CbIgracDomacina { get => cbIgracDomacina; set => cbIgracDomacina = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public DateTimePicker DtpDatum { get => dtpDatum; set => dtpDatum = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        
        public Label Label3 { get => label3; set => label3 = value; }
        public TextBox TxtBrojPoenaGost { get => txtBrojPoenaGost; set => txtBrojPoenaGost = value; }
        public TextBox TxtBrojPoenaDomacin { get => txtBrojPoenaDomacin; set => txtBrojPoenaDomacin = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtTim1 { get => txtTim1; set => txtTim1 = value; }
        public TextBox TxtTim2 { get => txtTim2; set => txtTim2 = value; }
    }
}