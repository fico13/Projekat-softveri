
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
            this.nađiIgračaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utakmicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUtakmicuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniUtakmicuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniUtakmicuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dvoranaToolStripMenuItem,
            this.timToolStripMenuItem,
            this.igracToolStripMenuItem,
            this.utakmicaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dvoranaToolStripMenuItem
            // 
            this.dvoranaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajDvoranuToolStripMenuItem});
            this.dvoranaToolStripMenuItem.Name = "dvoranaToolStripMenuItem";
            this.dvoranaToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.dvoranaToolStripMenuItem.Text = "Dvorana";
            // 
            // dodajDvoranuToolStripMenuItem
            // 
            this.dodajDvoranuToolStripMenuItem.Name = "dodajDvoranuToolStripMenuItem";
            this.dodajDvoranuToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.dodajDvoranuToolStripMenuItem.Text = "Dodaj dvoranu";
            this.dodajDvoranuToolStripMenuItem.Click += new System.EventHandler(this.dodajDvoranuToolStripMenuItem_Click);
            // 
            // timToolStripMenuItem
            // 
            this.timToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajTimToolStripMenuItem,
            this.nadjiTimToolStripMenuItem});
            this.timToolStripMenuItem.Name = "timToolStripMenuItem";
            this.timToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.timToolStripMenuItem.Text = "Tim";
            // 
            // dodajTimToolStripMenuItem
            // 
            this.dodajTimToolStripMenuItem.Name = "dodajTimToolStripMenuItem";
            this.dodajTimToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.dodajTimToolStripMenuItem.Text = "Dodaj tim";
            this.dodajTimToolStripMenuItem.Click += new System.EventHandler(this.dodajTimToolStripMenuItem_Click);
            // 
            // nadjiTimToolStripMenuItem
            // 
            this.nadjiTimToolStripMenuItem.Name = "nadjiTimToolStripMenuItem";
            this.nadjiTimToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nadjiTimToolStripMenuItem.Text = "Pretraga timova";
            this.nadjiTimToolStripMenuItem.Click += new System.EventHandler(this.nadjiTimToolStripMenuItem_Click);
            // 
            // igracToolStripMenuItem
            // 
            this.igracToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajIgračaToolStripMenuItem,
            this.nađiIgračaToolStripMenuItem});
            this.igracToolStripMenuItem.Name = "igracToolStripMenuItem";
            this.igracToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.igracToolStripMenuItem.Text = "Igrač";
            // 
            // dodajIgračaToolStripMenuItem
            // 
            this.dodajIgračaToolStripMenuItem.Name = "dodajIgračaToolStripMenuItem";
            this.dodajIgračaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dodajIgračaToolStripMenuItem.Text = "Dodaj igrača";
            this.dodajIgračaToolStripMenuItem.Click += new System.EventHandler(this.dodajIgračaToolStripMenuItem_Click);
            // 
            // nađiIgračaToolStripMenuItem
            // 
            this.nađiIgračaToolStripMenuItem.Name = "nađiIgračaToolStripMenuItem";
            this.nađiIgračaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nađiIgračaToolStripMenuItem.Text = "Izmeni igrača";
            this.nađiIgračaToolStripMenuItem.Click += new System.EventHandler(this.nađiIgračaToolStripMenuItem_Click);
            // 
            // utakmicaToolStripMenuItem
            // 
            this.utakmicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajUtakmicuToolStripMenuItem,
            this.izmeniUtakmicuToolStripMenuItem,
            this.izmeniUtakmicuToolStripMenuItem1});
            this.utakmicaToolStripMenuItem.Name = "utakmicaToolStripMenuItem";
            this.utakmicaToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.utakmicaToolStripMenuItem.Text = "Utakmica";
            // 
            // dodajUtakmicuToolStripMenuItem
            // 
            this.dodajUtakmicuToolStripMenuItem.Name = "dodajUtakmicuToolStripMenuItem";
            this.dodajUtakmicuToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.dodajUtakmicuToolStripMenuItem.Text = "Dodaj utakmicu";
            // 
            // izmeniUtakmicuToolStripMenuItem
            // 
            this.izmeniUtakmicuToolStripMenuItem.Name = "izmeniUtakmicuToolStripMenuItem";
            this.izmeniUtakmicuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izmeniUtakmicuToolStripMenuItem.Text = "Pretraga utakmica";
            // 
            // izmeniUtakmicuToolStripMenuItem1
            // 
            this.izmeniUtakmicuToolStripMenuItem1.Name = "izmeniUtakmicuToolStripMenuItem1";
            this.izmeniUtakmicuToolStripMenuItem1.Size = new System.Drawing.Size(200, 26);
            this.izmeniUtakmicuToolStripMenuItem1.Text = "Izmeni utakmicu";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 28);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(807, 528);
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
            this.pictureBox1.Size = new System.Drawing.Size(807, 528);
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
            this.Text = "Euroleague";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem nađiIgračaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utakmicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUtakmicuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniUtakmicuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniUtakmicuToolStripMenuItem1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem nadjiTimToolStripMenuItem;
    }
}