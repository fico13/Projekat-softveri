
using System.Windows.Forms;

namespace Client.Forms.UserControls.Statistika
{
    partial class UCTabelaTimova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTabelaTimova));
            this.dgvTabelaTimova = new System.Windows.Forms.DataGridView();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drzavaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojPobedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojPorazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodoviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kosRazlikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaTimova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabelaTimova
            // 
            this.dgvTabelaTimova.AllowUserToAddRows = false;
            this.dgvTabelaTimova.AllowUserToDeleteRows = false;
            this.dgvTabelaTimova.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTabelaTimova.AutoGenerateColumns = false;
            this.dgvTabelaTimova.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabelaTimova.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabelaTimova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelaTimova.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeDataGridViewTextBoxColumn,
            this.drzavaDataGridViewTextBoxColumn,
            this.brojPobedaDataGridViewTextBoxColumn,
            this.brojPorazaDataGridViewTextBoxColumn,
            this.bodoviDataGridViewTextBoxColumn,
            this.kosRazlikaDataGridViewTextBoxColumn});
            this.dgvTabelaTimova.DataSource = this.timBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTabelaTimova.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTabelaTimova.Location = new System.Drawing.Point(35, 33);
            this.dgvTabelaTimova.Name = "dgvTabelaTimova";
            this.dgvTabelaTimova.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabelaTimova.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTabelaTimova.RowHeadersVisible = false;
            this.dgvTabelaTimova.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvTabelaTimova.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTabelaTimova.RowTemplate.Height = 24;
            this.dgvTabelaTimova.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTabelaTimova.Size = new System.Drawing.Size(989, 565);
            this.dgvTabelaTimova.TabIndex = 0;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeDataGridViewTextBoxColumn.Width = 125;
            // 
            // drzavaDataGridViewTextBoxColumn
            // 
            this.drzavaDataGridViewTextBoxColumn.DataPropertyName = "Drzava";
            this.drzavaDataGridViewTextBoxColumn.HeaderText = "Drzava";
            this.drzavaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.drzavaDataGridViewTextBoxColumn.Name = "drzavaDataGridViewTextBoxColumn";
            this.drzavaDataGridViewTextBoxColumn.ReadOnly = true;
            this.drzavaDataGridViewTextBoxColumn.Width = 125;
            // 
            // brojPobedaDataGridViewTextBoxColumn
            // 
            this.brojPobedaDataGridViewTextBoxColumn.DataPropertyName = "BrojPobeda";
            this.brojPobedaDataGridViewTextBoxColumn.HeaderText = "Broj pobeda";
            this.brojPobedaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojPobedaDataGridViewTextBoxColumn.Name = "brojPobedaDataGridViewTextBoxColumn";
            this.brojPobedaDataGridViewTextBoxColumn.ReadOnly = true;
            this.brojPobedaDataGridViewTextBoxColumn.Width = 125;
            // 
            // brojPorazaDataGridViewTextBoxColumn
            // 
            this.brojPorazaDataGridViewTextBoxColumn.DataPropertyName = "BrojPoraza";
            this.brojPorazaDataGridViewTextBoxColumn.HeaderText = "Broj poraza";
            this.brojPorazaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojPorazaDataGridViewTextBoxColumn.Name = "brojPorazaDataGridViewTextBoxColumn";
            this.brojPorazaDataGridViewTextBoxColumn.ReadOnly = true;
            this.brojPorazaDataGridViewTextBoxColumn.Width = 125;
            // 
            // bodoviDataGridViewTextBoxColumn
            // 
            this.bodoviDataGridViewTextBoxColumn.DataPropertyName = "Bodovi";
            this.bodoviDataGridViewTextBoxColumn.HeaderText = "Bodovi";
            this.bodoviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bodoviDataGridViewTextBoxColumn.Name = "bodoviDataGridViewTextBoxColumn";
            this.bodoviDataGridViewTextBoxColumn.ReadOnly = true;
            this.bodoviDataGridViewTextBoxColumn.Width = 125;
            // 
            // kosRazlikaDataGridViewTextBoxColumn
            // 
            this.kosRazlikaDataGridViewTextBoxColumn.DataPropertyName = "KosRazlika";
            this.kosRazlikaDataGridViewTextBoxColumn.HeaderText = "Koš razlika";
            this.kosRazlikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kosRazlikaDataGridViewTextBoxColumn.Name = "kosRazlikaDataGridViewTextBoxColumn";
            this.kosRazlikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kosRazlikaDataGridViewTextBoxColumn.Width = 125;
            // 
            // timBindingSource
            // 
            this.timBindingSource.DataSource = typeof(Common.Domain.Tim);
            // 
            // UCTabelaTimova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dgvTabelaTimova);
            this.Name = "UCTabelaTimova";
            this.Size = new System.Drawing.Size(1058, 634);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaTimova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvTabelaTimova;
        private DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn drzavaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brojPobedaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brojPorazaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bodoviDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kosRazlikaDataGridViewTextBoxColumn;
        private BindingSource timBindingSource;

        public DataGridView DgvTabelaTimova { get => dgvTabelaTimova; set => dgvTabelaTimova = value; }
    }
}
