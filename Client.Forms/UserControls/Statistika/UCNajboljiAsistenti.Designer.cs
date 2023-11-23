
using System.Windows.Forms;

namespace Client.Forms.UserControls.Statistika
{
    partial class UCNajboljiAsistenti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNajboljiAsistenti));
            this.dgvIgraci = new System.Windows.Forms.DataGridView();
            this.imeIgracaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeIgracaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prosekAsistencijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igracBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIgraci
            // 
            this.dgvIgraci.AllowUserToAddRows = false;
            this.dgvIgraci.AllowUserToDeleteRows = false;
            this.dgvIgraci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvIgraci.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIgraci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIgraci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgraci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeIgracaDataGridViewTextBoxColumn,
            this.prezimeIgracaDataGridViewTextBoxColumn,
            this.timDataGridViewTextBoxColumn,
            this.prosekAsistencijeDataGridViewTextBoxColumn});
            this.dgvIgraci.DataSource = this.igracBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIgraci.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIgraci.Location = new System.Drawing.Point(161, 84);
            this.dgvIgraci.Name = "dgvIgraci";
            this.dgvIgraci.ReadOnly = true;
            this.dgvIgraci.RowHeadersWidth = 51;
            this.dgvIgraci.RowTemplate.Height = 24;
            this.dgvIgraci.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvIgraci.Size = new System.Drawing.Size(751, 565);
            this.dgvIgraci.TabIndex = 0;
            // 
            // imeIgracaDataGridViewTextBoxColumn
            // 
            this.imeIgracaDataGridViewTextBoxColumn.DataPropertyName = "ImeIgraca";
            this.imeIgracaDataGridViewTextBoxColumn.HeaderText = "Ime igrača";
            this.imeIgracaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imeIgracaDataGridViewTextBoxColumn.Name = "imeIgracaDataGridViewTextBoxColumn";
            this.imeIgracaDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeIgracaDataGridViewTextBoxColumn.Width = 125;
            // 
            // prezimeIgracaDataGridViewTextBoxColumn
            // 
            this.prezimeIgracaDataGridViewTextBoxColumn.DataPropertyName = "PrezimeIgraca";
            this.prezimeIgracaDataGridViewTextBoxColumn.HeaderText = "Prezime igrača";
            this.prezimeIgracaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prezimeIgracaDataGridViewTextBoxColumn.Name = "prezimeIgracaDataGridViewTextBoxColumn";
            this.prezimeIgracaDataGridViewTextBoxColumn.ReadOnly = true;
            this.prezimeIgracaDataGridViewTextBoxColumn.Width = 125;
            // 
            // timDataGridViewTextBoxColumn
            // 
            this.timDataGridViewTextBoxColumn.DataPropertyName = "Tim";
            this.timDataGridViewTextBoxColumn.HeaderText = "Tim";
            this.timDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timDataGridViewTextBoxColumn.Name = "timDataGridViewTextBoxColumn";
            this.timDataGridViewTextBoxColumn.ReadOnly = true;
            this.timDataGridViewTextBoxColumn.Width = 125;
            // 
            // prosekAsistencijeDataGridViewTextBoxColumn
            // 
            this.prosekAsistencijeDataGridViewTextBoxColumn.DataPropertyName = "ProsekAsistencije";
            this.prosekAsistencijeDataGridViewTextBoxColumn.HeaderText = "Prosek asistencija";
            this.prosekAsistencijeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prosekAsistencijeDataGridViewTextBoxColumn.Name = "prosekAsistencijeDataGridViewTextBoxColumn";
            this.prosekAsistencijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prosekAsistencijeDataGridViewTextBoxColumn.Width = 125;
            // 
            // igracBindingSource
            // 
            this.igracBindingSource.DataSource = typeof(Common.Domain.Igrac);
            // 
            // UCNajboljiAsistenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dgvIgraci);
            this.DoubleBuffered = true;
            this.Name = "UCNajboljiAsistenti";
            this.Size = new System.Drawing.Size(1058, 634);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igracBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIgraci;
        private System.Windows.Forms.BindingSource igracBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeIgracaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeIgracaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prosekAsistencijeDataGridViewTextBoxColumn;

        public DataGridView DgvIgraci { get => dgvIgraci; set => dgvIgraci = value; }
    }
}
