
using System.Windows.Forms;

namespace Client.Forms.UserControls.Utakmica
{
    partial class UCDodajUtakmicu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDodajUtakmicu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojPoenaDomacin = new System.Windows.Forms.TextBox();
            this.txtBrojPoenaGost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDomacin = new System.Windows.Forms.ComboBox();
            this.cbGost = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
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
            this.btnSacuvajUtakmicu = new System.Windows.Forms.Button();
            this.btnUcitajIgrace = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domacin";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gost";
            // 
            // txtBrojPoenaDomacin
            // 
            this.txtBrojPoenaDomacin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojPoenaDomacin.Location = new System.Drawing.Point(243, 87);
            this.txtBrojPoenaDomacin.Name = "txtBrojPoenaDomacin";
            this.txtBrojPoenaDomacin.Size = new System.Drawing.Size(53, 22);
            this.txtBrojPoenaDomacin.TabIndex = 2;
            // 
            // txtBrojPoenaGost
            // 
            this.txtBrojPoenaGost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojPoenaGost.Location = new System.Drawing.Point(354, 87);
            this.txtBrojPoenaGost.Name = "txtBrojPoenaGost";
            this.txtBrojPoenaGost.Size = new System.Drawing.Size(53, 22);
            this.txtBrojPoenaGost.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // cbDomacin
            // 
            this.cbDomacin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDomacin.FormattingEnabled = true;
            this.cbDomacin.Location = new System.Drawing.Point(42, 85);
            this.cbDomacin.Name = "cbDomacin";
            this.cbDomacin.Size = new System.Drawing.Size(181, 24);
            this.cbDomacin.TabIndex = 5;
            // 
            // cbGost
            // 
            this.cbGost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbGost.FormattingEnabled = true;
            this.cbGost.Location = new System.Drawing.Point(437, 85);
            this.cbGost.Name = "cbGost";
            this.cbGost.Size = new System.Drawing.Size(181, 24);
            this.cbGost.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datum odigravanja";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDatum.CustomFormat = "dd.MM.yyyy. HH:mm";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(191, 143);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(216, 22);
            this.dtpDatum.TabIndex = 10;
            this.dtpDatum.Value = new System.DateTime(2023, 8, 4, 20, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtAsistencijeDomacinIgrac);
            this.groupBox1.Controls.Add(this.txtSkokoviDomacinIgrac);
            this.groupBox1.Controls.Add(this.txtPoeniDomacinIgrac);
            this.groupBox1.Controls.Add(this.btnDodajStatistikuDomacin);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbIgracDomacina);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(42, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 332);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistika igraca domacin";
            // 
            // txtAsistencijeDomacinIgrac
            // 
            this.txtAsistencijeDomacinIgrac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAsistencijeDomacinIgrac.Location = new System.Drawing.Point(128, 226);
            this.txtAsistencijeDomacinIgrac.Name = "txtAsistencijeDomacinIgrac";
            this.txtAsistencijeDomacinIgrac.Size = new System.Drawing.Size(53, 22);
            this.txtAsistencijeDomacinIgrac.TabIndex = 14;
            // 
            // txtSkokoviDomacinIgrac
            // 
            this.txtSkokoviDomacinIgrac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSkokoviDomacinIgrac.Location = new System.Drawing.Point(128, 178);
            this.txtSkokoviDomacinIgrac.Name = "txtSkokoviDomacinIgrac";
            this.txtSkokoviDomacinIgrac.Size = new System.Drawing.Size(53, 22);
            this.txtSkokoviDomacinIgrac.TabIndex = 13;
            // 
            // txtPoeniDomacinIgrac
            // 
            this.txtPoeniDomacinIgrac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPoeniDomacinIgrac.Location = new System.Drawing.Point(128, 127);
            this.txtPoeniDomacinIgrac.Name = "txtPoeniDomacinIgrac";
            this.txtPoeniDomacinIgrac.Size = new System.Drawing.Size(53, 22);
            this.txtPoeniDomacinIgrac.TabIndex = 12;
            // 
            // btnDodajStatistikuDomacin
            // 
            this.btnDodajStatistikuDomacin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajStatistikuDomacin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodajStatistikuDomacin.BackgroundImage")));
            this.btnDodajStatistikuDomacin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDodajStatistikuDomacin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajStatistikuDomacin.Location = new System.Drawing.Point(24, 272);
            this.btnDodajStatistikuDomacin.Name = "btnDodajStatistikuDomacin";
            this.btnDodajStatistikuDomacin.Size = new System.Drawing.Size(230, 44);
            this.btnDodajStatistikuDomacin.TabIndex = 11;
            this.btnDodajStatistikuDomacin.Text = "Dodaj statistiku igraca";
            this.btnDodajStatistikuDomacin.UseVisualStyleBackColor = true;
            this.btnDodajStatistikuDomacin.Click += new System.EventHandler(this.btnDodajStatistikuDomacin_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Asistencije";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Skokovi";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Poeni";
            // 
            // cbIgracDomacina
            // 
            this.cbIgracDomacina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbIgracDomacina.FormattingEnabled = true;
            this.cbIgracDomacina.Location = new System.Drawing.Point(22, 77);
            this.cbIgracDomacina.Name = "cbIgracDomacina";
            this.cbIgracDomacina.Size = new System.Drawing.Size(181, 24);
            this.cbIgracDomacina.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Igrac";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txtAsistencijeGostIgrac);
            this.groupBox2.Controls.Add(this.txtSkokoviGostIgrac);
            this.groupBox2.Controls.Add(this.txtPoeniGostIgrac);
            this.groupBox2.Controls.Add(this.btnDodajStatistikuGost);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbIgracGosta);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(509, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 332);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistika igraca gost";
            // 
            // txtAsistencijeGostIgrac
            // 
            this.txtAsistencijeGostIgrac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAsistencijeGostIgrac.Location = new System.Drawing.Point(126, 226);
            this.txtAsistencijeGostIgrac.Name = "txtAsistencijeGostIgrac";
            this.txtAsistencijeGostIgrac.Size = new System.Drawing.Size(53, 22);
            this.txtAsistencijeGostIgrac.TabIndex = 23;
            // 
            // txtSkokoviGostIgrac
            // 
            this.txtSkokoviGostIgrac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSkokoviGostIgrac.Location = new System.Drawing.Point(126, 178);
            this.txtSkokoviGostIgrac.Name = "txtSkokoviGostIgrac";
            this.txtSkokoviGostIgrac.Size = new System.Drawing.Size(53, 22);
            this.txtSkokoviGostIgrac.TabIndex = 22;
            // 
            // txtPoeniGostIgrac
            // 
            this.txtPoeniGostIgrac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPoeniGostIgrac.Location = new System.Drawing.Point(126, 127);
            this.txtPoeniGostIgrac.Name = "txtPoeniGostIgrac";
            this.txtPoeniGostIgrac.Size = new System.Drawing.Size(53, 22);
            this.txtPoeniGostIgrac.TabIndex = 21;
            // 
            // btnDodajStatistikuGost
            // 
            this.btnDodajStatistikuGost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajStatistikuGost.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodajStatistikuGost.BackgroundImage")));
            this.btnDodajStatistikuGost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDodajStatistikuGost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajStatistikuGost.Location = new System.Drawing.Point(22, 272);
            this.btnDodajStatistikuGost.Name = "btnDodajStatistikuGost";
            this.btnDodajStatistikuGost.Size = new System.Drawing.Size(230, 44);
            this.btnDodajStatistikuGost.TabIndex = 20;
            this.btnDodajStatistikuGost.Text = "Dodaj statistiku igraca";
            this.btnDodajStatistikuGost.UseVisualStyleBackColor = true;
            this.btnDodajStatistikuGost.Click += new System.EventHandler(this.btnDodajStatistikuGost_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Asistencije";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Skokovi";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Poeni";
            // 
            // cbIgracGosta
            // 
            this.cbIgracGosta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbIgracGosta.FormattingEnabled = true;
            this.cbIgracGosta.Location = new System.Drawing.Point(20, 77);
            this.cbIgracGosta.Name = "cbIgracGosta";
            this.cbIgracGosta.Size = new System.Drawing.Size(181, 24);
            this.cbIgracGosta.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Igrac";
            // 
            // btnSacuvajUtakmicu
            // 
            this.btnSacuvajUtakmicu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvajUtakmicu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSacuvajUtakmicu.BackgroundImage")));
            this.btnSacuvajUtakmicu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSacuvajUtakmicu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSacuvajUtakmicu.Location = new System.Drawing.Point(66, 600);
            this.btnSacuvajUtakmicu.Name = "btnSacuvajUtakmicu";
            this.btnSacuvajUtakmicu.Size = new System.Drawing.Size(270, 44);
            this.btnSacuvajUtakmicu.TabIndex = 13;
            this.btnSacuvajUtakmicu.Text = "Sacuvaj utakmicu i statistiku";
            this.btnSacuvajUtakmicu.UseVisualStyleBackColor = true;
            this.btnSacuvajUtakmicu.Click += new System.EventHandler(this.btnSacuvajUtakmicu_Click);
            // 
            // btnUcitajIgrace
            // 
            this.btnUcitajIgrace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUcitajIgrace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUcitajIgrace.BackgroundImage")));
            this.btnUcitajIgrace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUcitajIgrace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUcitajIgrace.Location = new System.Drawing.Point(635, 65);
            this.btnUcitajIgrace.Name = "btnUcitajIgrace";
            this.btnUcitajIgrace.Size = new System.Drawing.Size(230, 44);
            this.btnUcitajIgrace.TabIndex = 14;
            this.btnUcitajIgrace.Text = "Ucitaj igrace";
            this.btnUcitajIgrace.UseVisualStyleBackColor = true;
            this.btnUcitajIgrace.Click += new System.EventHandler(this.btnUcitajIgrace_Click);
            // 
            // UCDodajUtakmicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUcitajIgrace);
            this.Controls.Add(this.btnSacuvajUtakmicu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbGost);
            this.Controls.Add(this.cbDomacin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBrojPoenaGost);
            this.Controls.Add(this.txtBrojPoenaDomacin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCDodajUtakmicu";
            this.Size = new System.Drawing.Size(908, 741);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojPoenaDomacin;
        private System.Windows.Forms.TextBox txtBrojPoenaGost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDomacin;
        private System.Windows.Forms.ComboBox cbGost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDatum;
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
        private System.Windows.Forms.Button btnSacuvajUtakmicu;
        private Button btnUcitajIgrace;

        public TextBox TxtBrojPoenaDomacin { get => txtBrojPoenaDomacin; set => txtBrojPoenaDomacin = value; }
        public TextBox TxtBrojPoenaGost { get => txtBrojPoenaGost; set => txtBrojPoenaGost = value; }
        public ComboBox CbDomacin { get => cbDomacin; set => cbDomacin = value; }
        public ComboBox CbGost { get => cbGost; set => cbGost = value; }
        public DateTimePicker DtpDatum { get => dtpDatum; set => dtpDatum = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public TextBox TxtAsistencijeDomacinIgrac { get => txtAsistencijeDomacinIgrac; set => txtAsistencijeDomacinIgrac = value; }
        public TextBox TxtSkokoviDomacinIgrac { get => txtSkokoviDomacinIgrac; set => txtSkokoviDomacinIgrac = value; }
        public TextBox TxtPoeniDomacinIgrac { get => txtPoeniDomacinIgrac; set => txtPoeniDomacinIgrac = value; }
        public Button BtnDodajStatistikuDomacin { get => btnDodajStatistikuDomacin; set => btnDodajStatistikuDomacin = value; }
        public ComboBox CbIgracDomacina { get => cbIgracDomacina; set => cbIgracDomacina = value; }
        public GroupBox GroupBox2 { get => groupBox2; set => groupBox2 = value; }
        public TextBox TxtAsistencijeGostIgrac { get => txtAsistencijeGostIgrac; set => txtAsistencijeGostIgrac = value; }
        public TextBox TxtSkokoviGostIgrac { get => txtSkokoviGostIgrac; set => txtSkokoviGostIgrac = value; }
        public TextBox TxtPoeniGostIgrac { get => txtPoeniGostIgrac; set => txtPoeniGostIgrac = value; }
        public Button BtnDodajStatistikuGost { get => btnDodajStatistikuGost; set => btnDodajStatistikuGost = value; }
        public ComboBox CbIgracGosta { get => cbIgracGosta; set => cbIgracGosta = value; }
        public Button BtnSacuvajUtakmicu { get => btnSacuvajUtakmicu; set => btnSacuvajUtakmicu = value; }
        public Button BtnUcitajIgrace { get => btnUcitajIgrace; set => btnUcitajIgrace = value; }
    }
}
