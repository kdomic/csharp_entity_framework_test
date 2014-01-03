namespace PutniNalozi
{
    partial class Djelatnici_lista
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
            this.dgvOsobe = new System.Windows.Forms.DataGridView();
            this.idOsobeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodjenjedatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodjenjemjestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prebivalisteadresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prebivalistemjestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osobeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsobe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOsobe
            // 
            this.dgvOsobe.AllowUserToAddRows = false;
            this.dgvOsobe.AllowUserToDeleteRows = false;
            this.dgvOsobe.AutoGenerateColumns = false;
            this.dgvOsobe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOsobe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOsobeDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.oibDataGridViewTextBoxColumn,
            this.rodjenjedatumDataGridViewTextBoxColumn,
            this.rodjenjemjestoDataGridViewTextBoxColumn,
            this.prebivalisteadresaDataGridViewTextBoxColumn,
            this.prebivalistemjestoDataGridViewTextBoxColumn});
            this.dgvOsobe.DataSource = this.osobeBindingSource;
            this.dgvOsobe.Location = new System.Drawing.Point(0, 0);
            this.dgvOsobe.MultiSelect = false;
            this.dgvOsobe.Name = "dgvOsobe";
            this.dgvOsobe.ReadOnly = true;
            this.dgvOsobe.RowHeadersVisible = false;
            this.dgvOsobe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOsobe.Size = new System.Drawing.Size(564, 309);
            this.dgvOsobe.TabIndex = 0;
            this.dgvOsobe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOsobe_CellClick);
            // 
            // idOsobeDataGridViewTextBoxColumn
            // 
            this.idOsobeDataGridViewTextBoxColumn.DataPropertyName = "idOsobe";
            this.idOsobeDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idOsobeDataGridViewTextBoxColumn.Name = "idOsobeDataGridViewTextBoxColumn";
            this.idOsobeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOsobeDataGridViewTextBoxColumn.Width = 50;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oibDataGridViewTextBoxColumn
            // 
            this.oibDataGridViewTextBoxColumn.DataPropertyName = "oib";
            this.oibDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oibDataGridViewTextBoxColumn.Name = "oibDataGridViewTextBoxColumn";
            this.oibDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rodjenjedatumDataGridViewTextBoxColumn
            // 
            this.rodjenjedatumDataGridViewTextBoxColumn.DataPropertyName = "rodjenje_datum";
            this.rodjenjedatumDataGridViewTextBoxColumn.HeaderText = "Datum rođenja";
            this.rodjenjedatumDataGridViewTextBoxColumn.Name = "rodjenjedatumDataGridViewTextBoxColumn";
            this.rodjenjedatumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rodjenjemjestoDataGridViewTextBoxColumn
            // 
            this.rodjenjemjestoDataGridViewTextBoxColumn.DataPropertyName = "rodjenje_mjesto";
            this.rodjenjemjestoDataGridViewTextBoxColumn.HeaderText = "Mjesto rođenja";
            this.rodjenjemjestoDataGridViewTextBoxColumn.Name = "rodjenjemjestoDataGridViewTextBoxColumn";
            this.rodjenjemjestoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prebivalisteadresaDataGridViewTextBoxColumn
            // 
            this.prebivalisteadresaDataGridViewTextBoxColumn.DataPropertyName = "prebivaliste_adresa";
            this.prebivalisteadresaDataGridViewTextBoxColumn.HeaderText = "Adresa prebivališta";
            this.prebivalisteadresaDataGridViewTextBoxColumn.Name = "prebivalisteadresaDataGridViewTextBoxColumn";
            this.prebivalisteadresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prebivalistemjestoDataGridViewTextBoxColumn
            // 
            this.prebivalistemjestoDataGridViewTextBoxColumn.DataPropertyName = "prebivaliste_mjesto";
            this.prebivalistemjestoDataGridViewTextBoxColumn.HeaderText = "Mjesto prebivališta";
            this.prebivalistemjestoDataGridViewTextBoxColumn.Name = "prebivalistemjestoDataGridViewTextBoxColumn";
            this.prebivalistemjestoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // osobeBindingSource
            // 
            this.osobeBindingSource.DataSource = typeof(PutniNalozi.Osobe);
            // 
            // Djelatnici_lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 436);
            this.Controls.Add(this.dgvOsobe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Djelatnici_lista";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Popis djelatnika";
            this.Load += new System.EventHandler(this.Djelatnici_lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsobe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOsobe;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOsobeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodjenjedatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodjenjemjestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prebivalisteadresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prebivalistemjestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource osobeBindingSource;

    }
}