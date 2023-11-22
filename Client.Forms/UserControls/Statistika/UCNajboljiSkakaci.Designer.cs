﻿
using System.Windows.Forms;

namespace Client.Forms.UserControls.Statistika
{
    partial class UCNajboljiSkakaci
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
            this.dgvIgraci = new System.Windows.Forms.DataGridView();
            this.imeIgracaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeIgracaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prosekSkokoviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvIgraci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgraci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeIgracaDataGridViewTextBoxColumn,
            this.prezimeIgracaDataGridViewTextBoxColumn,
            this.timDataGridViewTextBoxColumn,
            this.prosekSkokoviDataGridViewTextBoxColumn});
            this.dgvIgraci.DataSource = this.igracBindingSource;
            this.dgvIgraci.Location = new System.Drawing.Point(40, 45);
            this.dgvIgraci.Name = "dgvIgraci";
            this.dgvIgraci.ReadOnly = true;
            this.dgvIgraci.RowHeadersWidth = 51;
            this.dgvIgraci.RowTemplate.Height = 24;
            this.dgvIgraci.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvIgraci.Size = new System.Drawing.Size(751, 445);
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
            // prosekSkokoviDataGridViewTextBoxColumn
            // 
            this.prosekSkokoviDataGridViewTextBoxColumn.DataPropertyName = "ProsekSkokovi";
            this.prosekSkokoviDataGridViewTextBoxColumn.HeaderText = "Prosek skokova";
            this.prosekSkokoviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prosekSkokoviDataGridViewTextBoxColumn.Name = "prosekSkokoviDataGridViewTextBoxColumn";
            this.prosekSkokoviDataGridViewTextBoxColumn.ReadOnly = true;
            this.prosekSkokoviDataGridViewTextBoxColumn.Width = 125;
            // 
            // igracBindingSource
            // 
            this.igracBindingSource.DataSource = typeof(Common.Domain.Igrac);
            // 
            // UCNajboljiSkakaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvIgraci);
            this.Name = "UCNajboljiSkakaci";
            this.Size = new System.Drawing.Size(841, 582);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igracBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIgraci;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeIgracaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeIgracaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prosekSkokoviDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource igracBindingSource;

        public DataGridView DgvIgraci { get => dgvIgraci; set => dgvIgraci = value; }
    }
}
