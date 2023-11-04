
using System.Windows.Forms;

namespace Client.Forms.Dialogs.Igrac
{
    partial class FrmStatistikaIgraca
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStatistikaIgraca));
            this.lblIgrac = new System.Windows.Forms.Label();
            this.dgvStatistika = new System.Windows.Forms.DataGridView();
            this.utakmicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skokoviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asistencijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statistikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistikaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIgrac
            // 
            this.lblIgrac.AutoSize = true;
            this.lblIgrac.BackColor = System.Drawing.Color.OrangeRed;
            this.lblIgrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgrac.Location = new System.Drawing.Point(56, 41);
            this.lblIgrac.Name = "lblIgrac";
            this.lblIgrac.Size = new System.Drawing.Size(0, 32);
            this.lblIgrac.TabIndex = 0;
            // 
            // dgvStatistika
            // 
            this.dgvStatistika.AllowUserToAddRows = false;
            this.dgvStatistika.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvStatistika.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStatistika.AutoGenerateColumns = false;
            this.dgvStatistika.BackgroundColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatistika.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStatistika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.utakmicaDataGridViewTextBoxColumn,
            this.poeniDataGridViewTextBoxColumn,
            this.skokoviDataGridViewTextBoxColumn,
            this.asistencijeDataGridViewTextBoxColumn});
            this.dgvStatistika.DataSource = this.statistikaBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatistika.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStatistika.Location = new System.Drawing.Point(49, 127);
            this.dgvStatistika.Name = "dgvStatistika";
            this.dgvStatistika.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatistika.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStatistika.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvStatistika.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvStatistika.RowTemplate.Height = 24;
            this.dgvStatistika.Size = new System.Drawing.Size(939, 288);
            this.dgvStatistika.TabIndex = 1;
            // 
            // utakmicaDataGridViewTextBoxColumn
            // 
            this.utakmicaDataGridViewTextBoxColumn.DataPropertyName = "Utakmica";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.utakmicaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.utakmicaDataGridViewTextBoxColumn.HeaderText = "Utakmica";
            this.utakmicaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.utakmicaDataGridViewTextBoxColumn.Name = "utakmicaDataGridViewTextBoxColumn";
            this.utakmicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.utakmicaDataGridViewTextBoxColumn.Width = 300;
            // 
            // poeniDataGridViewTextBoxColumn
            // 
            this.poeniDataGridViewTextBoxColumn.DataPropertyName = "Poeni";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.poeniDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.poeniDataGridViewTextBoxColumn.HeaderText = "Poeni";
            this.poeniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.poeniDataGridViewTextBoxColumn.Name = "poeniDataGridViewTextBoxColumn";
            this.poeniDataGridViewTextBoxColumn.ReadOnly = true;
            this.poeniDataGridViewTextBoxColumn.Width = 75;
            // 
            // skokoviDataGridViewTextBoxColumn
            // 
            this.skokoviDataGridViewTextBoxColumn.DataPropertyName = "Skokovi";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.skokoviDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.skokoviDataGridViewTextBoxColumn.HeaderText = "Skokovi";
            this.skokoviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.skokoviDataGridViewTextBoxColumn.Name = "skokoviDataGridViewTextBoxColumn";
            this.skokoviDataGridViewTextBoxColumn.ReadOnly = true;
            this.skokoviDataGridViewTextBoxColumn.Width = 75;
            // 
            // asistencijeDataGridViewTextBoxColumn
            // 
            this.asistencijeDataGridViewTextBoxColumn.DataPropertyName = "Asistencije";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.asistencijeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.asistencijeDataGridViewTextBoxColumn.HeaderText = "Asistencije";
            this.asistencijeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.asistencijeDataGridViewTextBoxColumn.Name = "asistencijeDataGridViewTextBoxColumn";
            this.asistencijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.asistencijeDataGridViewTextBoxColumn.Width = 75;
            // 
            // statistikaBindingSource
            // 
            this.statistikaBindingSource.DataSource = typeof(Common.Domain.Statistika);
            // 
            // FrmStatistikaIgraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1102, 450);
            this.Controls.Add(this.dgvStatistika);
            this.Controls.Add(this.lblIgrac);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStatistikaIgraca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistika igrača";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStatistikaIgraca_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistikaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIgrac;
        private System.Windows.Forms.DataGridView dgvStatistika;
        private BindingSource statistikaBindingSource;
        private DataGridViewTextBoxColumn utakmicaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn poeniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn skokoviDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn asistencijeDataGridViewTextBoxColumn;

        public Label LblIgrac { get => lblIgrac; set => lblIgrac = value; }
        public DataGridView DgvStatistika { get => dgvStatistika; set => dgvStatistika = value; }
    }
}