
namespace Client.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dvoranaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajDvoranuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajTimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nadjiTimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igracToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajIgračaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaIgračaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniIgračaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takmicenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularniDeoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plejofToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utakmicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUtakmicuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniUtakmicuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniUtakmicuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.najboljiStrelciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.najboljiSkakačiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.najboljiAsistentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dvoranaToolStripMenuItem,
            this.timToolStripMenuItem,
            this.igracToolStripMenuItem,
            this.takmicenjeToolStripMenuItem,
            this.utakmicaToolStripMenuItem,
            this.tabelaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dvoranaToolStripMenuItem
            // 
            this.dvoranaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajDvoranuToolStripMenuItem});
            this.dvoranaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dvoranaToolStripMenuItem.Image")));
            this.dvoranaToolStripMenuItem.Name = "dvoranaToolStripMenuItem";
            this.dvoranaToolStripMenuItem.Size = new System.Drawing.Size(126, 32);
            this.dvoranaToolStripMenuItem.Text = "Dvorana";
            // 
            // dodajDvoranuToolStripMenuItem
            // 
            this.dodajDvoranuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dodajDvoranuToolStripMenuItem.Image")));
            this.dodajDvoranuToolStripMenuItem.Name = "dodajDvoranuToolStripMenuItem";
            this.dodajDvoranuToolStripMenuItem.Size = new System.Drawing.Size(238, 32);
            this.dodajDvoranuToolStripMenuItem.Text = "Dodaj dvoranu";
            this.dodajDvoranuToolStripMenuItem.Click += new System.EventHandler(this.dodajDvoranuToolStripMenuItem_Click);
            // 
            // timToolStripMenuItem
            // 
            this.timToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajTimToolStripMenuItem,
            this.nadjiTimToolStripMenuItem});
            this.timToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("timToolStripMenuItem.Image")));
            this.timToolStripMenuItem.Name = "timToolStripMenuItem";
            this.timToolStripMenuItem.Size = new System.Drawing.Size(82, 32);
            this.timToolStripMenuItem.Text = "Tim";
            // 
            // dodajTimToolStripMenuItem
            // 
            this.dodajTimToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dodajTimToolStripMenuItem.Image")));
            this.dodajTimToolStripMenuItem.Name = "dodajTimToolStripMenuItem";
            this.dodajTimToolStripMenuItem.Size = new System.Drawing.Size(251, 32);
            this.dodajTimToolStripMenuItem.Text = "Dodaj tim";
            this.dodajTimToolStripMenuItem.Click += new System.EventHandler(this.dodajTimToolStripMenuItem_Click);
            // 
            // nadjiTimToolStripMenuItem
            // 
            this.nadjiTimToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nadjiTimToolStripMenuItem.Image")));
            this.nadjiTimToolStripMenuItem.Name = "nadjiTimToolStripMenuItem";
            this.nadjiTimToolStripMenuItem.Size = new System.Drawing.Size(251, 32);
            this.nadjiTimToolStripMenuItem.Text = "Pretraga timova";
            this.nadjiTimToolStripMenuItem.Click += new System.EventHandler(this.nadjiTimToolStripMenuItem_Click);
            // 
            // igracToolStripMenuItem
            // 
            this.igracToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajIgračaToolStripMenuItem,
            this.pretragaIgračaToolStripMenuItem,
            this.izmeniIgračaToolStripMenuItem});
            this.igracToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("igracToolStripMenuItem.Image")));
            this.igracToolStripMenuItem.Name = "igracToolStripMenuItem";
            this.igracToolStripMenuItem.Size = new System.Drawing.Size(93, 32);
            this.igracToolStripMenuItem.Text = "Igrač";
            // 
            // dodajIgračaToolStripMenuItem
            // 
            this.dodajIgračaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dodajIgračaToolStripMenuItem.Image")));
            this.dodajIgračaToolStripMenuItem.Name = "dodajIgračaToolStripMenuItem";
            this.dodajIgračaToolStripMenuItem.Size = new System.Drawing.Size(243, 32);
            this.dodajIgračaToolStripMenuItem.Text = "Dodaj igrača";
            this.dodajIgračaToolStripMenuItem.Click += new System.EventHandler(this.dodajIgračaToolStripMenuItem_Click);
            // 
            // pretragaIgračaToolStripMenuItem
            // 
            this.pretragaIgračaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pretragaIgračaToolStripMenuItem.Image")));
            this.pretragaIgračaToolStripMenuItem.Name = "pretragaIgračaToolStripMenuItem";
            this.pretragaIgračaToolStripMenuItem.Size = new System.Drawing.Size(243, 32);
            this.pretragaIgračaToolStripMenuItem.Text = "Pretraga igrača";
            this.pretragaIgračaToolStripMenuItem.Click += new System.EventHandler(this.pretragaIgračaToolStripMenuItem_Click);
            // 
            // izmeniIgračaToolStripMenuItem
            // 
            this.izmeniIgračaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("izmeniIgračaToolStripMenuItem.Image")));
            this.izmeniIgračaToolStripMenuItem.Name = "izmeniIgračaToolStripMenuItem";
            this.izmeniIgračaToolStripMenuItem.Size = new System.Drawing.Size(243, 32);
            this.izmeniIgračaToolStripMenuItem.Text = "Izmeni igrača";
            this.izmeniIgračaToolStripMenuItem.Click += new System.EventHandler(this.izmeniIgračaToolStripMenuItem_Click);
            // 
            // takmicenjeToolStripMenuItem
            // 
            this.takmicenjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regularniDeoToolStripMenuItem,
            this.plejofToolStripMenuItem});
            this.takmicenjeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("takmicenjeToolStripMenuItem.Image")));
            this.takmicenjeToolStripMenuItem.Name = "takmicenjeToolStripMenuItem";
            this.takmicenjeToolStripMenuItem.Size = new System.Drawing.Size(113, 32);
            this.takmicenjeToolStripMenuItem.Text = "Sezona";
            // 
            // regularniDeoToolStripMenuItem
            // 
            this.regularniDeoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("regularniDeoToolStripMenuItem.Image")));
            this.regularniDeoToolStripMenuItem.Name = "regularniDeoToolStripMenuItem";
            this.regularniDeoToolStripMenuItem.Size = new System.Drawing.Size(230, 32);
            this.regularniDeoToolStripMenuItem.Text = "Regularni deo";
            this.regularniDeoToolStripMenuItem.Click += new System.EventHandler(this.regularniDeoToolStripMenuItem_Click);
            // 
            // plejofToolStripMenuItem
            // 
            this.plejofToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("plejofToolStripMenuItem.Image")));
            this.plejofToolStripMenuItem.Name = "plejofToolStripMenuItem";
            this.plejofToolStripMenuItem.Size = new System.Drawing.Size(230, 32);
            this.plejofToolStripMenuItem.Text = "Plejof";
            this.plejofToolStripMenuItem.Click += new System.EventHandler(this.plejofToolStripMenuItem_Click);
            // 
            // utakmicaToolStripMenuItem
            // 
            this.utakmicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajUtakmicuToolStripMenuItem,
            this.izmeniUtakmicuToolStripMenuItem,
            this.izmeniUtakmicuToolStripMenuItem1});
            this.utakmicaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("utakmicaToolStripMenuItem.Image")));
            this.utakmicaToolStripMenuItem.Name = "utakmicaToolStripMenuItem";
            this.utakmicaToolStripMenuItem.Size = new System.Drawing.Size(135, 32);
            this.utakmicaToolStripMenuItem.Text = "Utakmica";
            // 
            // dodajUtakmicuToolStripMenuItem
            // 
            this.dodajUtakmicuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dodajUtakmicuToolStripMenuItem.Image")));
            this.dodajUtakmicuToolStripMenuItem.Name = "dodajUtakmicuToolStripMenuItem";
            this.dodajUtakmicuToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.dodajUtakmicuToolStripMenuItem.Text = "Dodaj utakmicu";
            this.dodajUtakmicuToolStripMenuItem.Click += new System.EventHandler(this.dodajUtakmicuToolStripMenuItem_Click);
            // 
            // izmeniUtakmicuToolStripMenuItem
            // 
            this.izmeniUtakmicuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("izmeniUtakmicuToolStripMenuItem.Image")));
            this.izmeniUtakmicuToolStripMenuItem.Name = "izmeniUtakmicuToolStripMenuItem";
            this.izmeniUtakmicuToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.izmeniUtakmicuToolStripMenuItem.Text = "Pretraga utakmica";
            this.izmeniUtakmicuToolStripMenuItem.Click += new System.EventHandler(this.izmeniUtakmicuToolStripMenuItem_Click);
            // 
            // izmeniUtakmicuToolStripMenuItem1
            // 
            this.izmeniUtakmicuToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("izmeniUtakmicuToolStripMenuItem1.Image")));
            this.izmeniUtakmicuToolStripMenuItem1.Name = "izmeniUtakmicuToolStripMenuItem1";
            this.izmeniUtakmicuToolStripMenuItem1.Size = new System.Drawing.Size(272, 32);
            this.izmeniUtakmicuToolStripMenuItem1.Text = "Izmeni utakmicu";
            this.izmeniUtakmicuToolStripMenuItem1.Click += new System.EventHandler(this.izmeniUtakmicuToolStripMenuItem1_Click);
            // 
            // tabelaToolStripMenuItem
            // 
            this.tabelaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timoviToolStripMenuItem,
            this.najboljiStrelciToolStripMenuItem,
            this.najboljiSkakačiToolStripMenuItem,
            this.najboljiAsistentiToolStripMenuItem});
            this.tabelaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tabelaToolStripMenuItem.Image")));
            this.tabelaToolStripMenuItem.Name = "tabelaToolStripMenuItem";
            this.tabelaToolStripMenuItem.Size = new System.Drawing.Size(107, 32);
            this.tabelaToolStripMenuItem.Text = "Tabela";
            // 
            // timoviToolStripMenuItem
            // 
            this.timoviToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("timoviToolStripMenuItem.Image")));
            this.timoviToolStripMenuItem.Name = "timoviToolStripMenuItem";
            this.timoviToolStripMenuItem.Size = new System.Drawing.Size(259, 32);
            this.timoviToolStripMenuItem.Text = "Timovi";
            this.timoviToolStripMenuItem.Click += new System.EventHandler(this.timoviToolStripMenuItem_Click);
            // 
            // najboljiStrelciToolStripMenuItem
            // 
            this.najboljiStrelciToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("najboljiStrelciToolStripMenuItem.Image")));
            this.najboljiStrelciToolStripMenuItem.Name = "najboljiStrelciToolStripMenuItem";
            this.najboljiStrelciToolStripMenuItem.Size = new System.Drawing.Size(259, 32);
            this.najboljiStrelciToolStripMenuItem.Text = "Najbolji strelci";
            this.najboljiStrelciToolStripMenuItem.Click += new System.EventHandler(this.najboljiStrelciToolStripMenuItem_Click);
            // 
            // najboljiSkakačiToolStripMenuItem
            // 
            this.najboljiSkakačiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("najboljiSkakačiToolStripMenuItem.Image")));
            this.najboljiSkakačiToolStripMenuItem.Name = "najboljiSkakačiToolStripMenuItem";
            this.najboljiSkakačiToolStripMenuItem.Size = new System.Drawing.Size(259, 32);
            this.najboljiSkakačiToolStripMenuItem.Text = "Najbolji skakači";
            this.najboljiSkakačiToolStripMenuItem.Click += new System.EventHandler(this.najboljiSkakačiToolStripMenuItem_Click);
            // 
            // najboljiAsistentiToolStripMenuItem
            // 
            this.najboljiAsistentiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("najboljiAsistentiToolStripMenuItem.Image")));
            this.najboljiAsistentiToolStripMenuItem.Name = "najboljiAsistentiToolStripMenuItem";
            this.najboljiAsistentiToolStripMenuItem.Size = new System.Drawing.Size(259, 32);
            this.najboljiAsistentiToolStripMenuItem.Text = "Najbolji asistenti";
            this.najboljiAsistentiToolStripMenuItem.Click += new System.EventHandler(this.najboljiAsistentiToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 36);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(807, 520);
            this.pnlMain.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(807, 520);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 556);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Košarka";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dvoranaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajDvoranuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajTimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igracToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajIgračaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utakmicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUtakmicuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniUtakmicuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniUtakmicuToolStripMenuItem1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem nadjiTimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniIgračaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaIgračaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takmicenjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularniDeoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plejofToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem najboljiStrelciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem najboljiSkakačiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem najboljiAsistentiToolStripMenuItem;
    }
}