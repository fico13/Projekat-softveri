
using System.Windows.Forms;

namespace Client.Forms.UserControls.Statistika
{
    partial class UCNajboljiStrelci
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNajboljiStrelci));
            this.dgvIgraci = new System.Windows.Forms.DataGridView();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeIgracaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeIgracaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drzavaIgracaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prosekPoeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvIgraci.BackgroundColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIgraci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIgraci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgraci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rankDataGridViewTextBoxColumn,
            this.imeIgracaDataGridViewTextBoxColumn,
            this.prezimeIgracaDataGridViewTextBoxColumn,
            this.drzavaIgracaDataGridViewTextBoxColumn,
            this.timDataGridViewTextBoxColumn,
            this.prosekPoeniDataGridViewTextBoxColumn});
            this.dgvIgraci.DataSource = this.igracBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIgraci.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIgraci.Location = new System.Drawing.Point(210, 35);
            this.dgvIgraci.Name = "dgvIgraci";
            this.dgvIgraci.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIgraci.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIgraci.RowHeadersVisible = false;
            this.dgvIgraci.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvIgraci.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIgraci.RowTemplate.Height = 24;
            this.dgvIgraci.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvIgraci.Size = new System.Drawing.Size(1025, 565);
            this.dgvIgraci.TabIndex = 0;
            // 
            // rankDataGridViewTextBoxColumn
            // 
            this.rankDataGridViewTextBoxColumn.DataPropertyName = "Rank";
            this.rankDataGridViewTextBoxColumn.HeaderText = "Rank";
            this.rankDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rankDataGridViewTextBoxColumn.Name = "rankDataGridViewTextBoxColumn";
            this.rankDataGridViewTextBoxColumn.ReadOnly = true;
            this.rankDataGridViewTextBoxColumn.Width = 125;
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
            // drzavaIgracaDataGridViewTextBoxColumn
            // 
            this.drzavaIgracaDataGridViewTextBoxColumn.DataPropertyName = "DrzavaIgraca";
            this.drzavaIgracaDataGridViewTextBoxColumn.HeaderText = "Država ";
            this.drzavaIgracaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.drzavaIgracaDataGridViewTextBoxColumn.Name = "drzavaIgracaDataGridViewTextBoxColumn";
            this.drzavaIgracaDataGridViewTextBoxColumn.ReadOnly = true;
            this.drzavaIgracaDataGridViewTextBoxColumn.Width = 125;
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
            // prosekPoeniDataGridViewTextBoxColumn
            // 
            this.prosekPoeniDataGridViewTextBoxColumn.DataPropertyName = "ProsekPoeni";
            this.prosekPoeniDataGridViewTextBoxColumn.HeaderText = "Prosek poena";
            this.prosekPoeniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prosekPoeniDataGridViewTextBoxColumn.Name = "prosekPoeniDataGridViewTextBoxColumn";
            this.prosekPoeniDataGridViewTextBoxColumn.ReadOnly = true;
            this.prosekPoeniDataGridViewTextBoxColumn.Width = 125;
            // 
            // igracBindingSource
            // 
            this.igracBindingSource.DataSource = typeof(Common.Domain.Igrac);
            // 
            // UCNajboljiStrelci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dgvIgraci);
            this.DoubleBuffered = true;
            this.Name = "UCNajboljiStrelci";
            this.Size = new System.Drawing.Size(1433, 634);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igracBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIgraci;
        private DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imeIgracaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prezimeIgracaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn drzavaIgracaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prosekPoeniDataGridViewTextBoxColumn;
        private BindingSource igracBindingSource;

        public DataGridView DgvIgraci { get => dgvIgraci; set => dgvIgraci = value; }
    }
}
