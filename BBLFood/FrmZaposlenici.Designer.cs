namespace BBLFood
{
    partial class FrmZaposlenici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmZaposlenici));
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idradnomjestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.radnomjestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnomjestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rezervacijasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodajZaposlenika = new System.Windows.Forms.Button();
            this.btnRadnaMjesta = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnomjestoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AllowUserToAddRows = false;
            this.dgvZaposlenici.AllowUserToDeleteRows = false;
            this.dgvZaposlenici.AutoGenerateColumns = false;
            this.dgvZaposlenici.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.idradnomjestoDataGridViewTextBoxColumn,
            this.racunsDataGridViewTextBoxColumn,
            this.radnomjestoDataGridViewTextBoxColumn,
            this.rezervacijasDataGridViewTextBoxColumn});
            this.dgvZaposlenici.DataSource = this.zaposlenikBindingSource;
            this.dgvZaposlenici.Location = new System.Drawing.Point(34, 164);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.ReadOnly = true;
            this.dgvZaposlenici.RowHeadersVisible = false;
            this.dgvZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenici.Size = new System.Drawing.Size(204, 155);
            this.dgvZaposlenici.TabIndex = 0;
            this.dgvZaposlenici.SelectionChanged += new System.EventHandler(this.dgvZaposlenici_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
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
            // idradnomjestoDataGridViewTextBoxColumn
            // 
            this.idradnomjestoDataGridViewTextBoxColumn.DataPropertyName = "id_radno_mjesto";
            this.idradnomjestoDataGridViewTextBoxColumn.DataSource = this.radnomjestoBindingSource;
            this.idradnomjestoDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.idradnomjestoDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idradnomjestoDataGridViewTextBoxColumn.HeaderText = "Radno mjesto";
            this.idradnomjestoDataGridViewTextBoxColumn.Name = "idradnomjestoDataGridViewTextBoxColumn";
            this.idradnomjestoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idradnomjestoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idradnomjestoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idradnomjestoDataGridViewTextBoxColumn.ValueMember = "id";
            this.idradnomjestoDataGridViewTextBoxColumn.Visible = false;
            // 
            // radnomjestoBindingSource
            // 
            this.radnomjestoBindingSource.DataSource = typeof(BBLFood.radno_mjesto);
            // 
            // racunsDataGridViewTextBoxColumn
            // 
            this.racunsDataGridViewTextBoxColumn.DataPropertyName = "racuns";
            this.racunsDataGridViewTextBoxColumn.HeaderText = "racuns";
            this.racunsDataGridViewTextBoxColumn.Name = "racunsDataGridViewTextBoxColumn";
            this.racunsDataGridViewTextBoxColumn.ReadOnly = true;
            this.racunsDataGridViewTextBoxColumn.Visible = false;
            // 
            // radnomjestoDataGridViewTextBoxColumn
            // 
            this.radnomjestoDataGridViewTextBoxColumn.DataPropertyName = "radno_mjesto";
            this.radnomjestoDataGridViewTextBoxColumn.DataSource = this.radnomjestoBindingSource;
            this.radnomjestoDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.radnomjestoDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.radnomjestoDataGridViewTextBoxColumn.HeaderText = "Radno mjesto";
            this.radnomjestoDataGridViewTextBoxColumn.Name = "radnomjestoDataGridViewTextBoxColumn";
            this.radnomjestoDataGridViewTextBoxColumn.ReadOnly = true;
            this.radnomjestoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.radnomjestoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.radnomjestoDataGridViewTextBoxColumn.ValueMember = "id";
            this.radnomjestoDataGridViewTextBoxColumn.Visible = false;
            // 
            // rezervacijasDataGridViewTextBoxColumn
            // 
            this.rezervacijasDataGridViewTextBoxColumn.DataPropertyName = "rezervacijas";
            this.rezervacijasDataGridViewTextBoxColumn.HeaderText = "rezervacijas";
            this.rezervacijasDataGridViewTextBoxColumn.Name = "rezervacijasDataGridViewTextBoxColumn";
            this.rezervacijasDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezervacijasDataGridViewTextBoxColumn.Visible = false;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(BBLFood.zaposlenik);
            // 
            // btnDodajZaposlenika
            // 
            this.btnDodajZaposlenika.Location = new System.Drawing.Point(34, 108);
            this.btnDodajZaposlenika.Name = "btnDodajZaposlenika";
            this.btnDodajZaposlenika.Size = new System.Drawing.Size(94, 35);
            this.btnDodajZaposlenika.TabIndex = 1;
            this.btnDodajZaposlenika.Text = "Dodaj zaposlenika";
            this.btnDodajZaposlenika.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenika.Click += new System.EventHandler(this.btnDodajZaposlenika_Click);
            // 
            // btnRadnaMjesta
            // 
            this.btnRadnaMjesta.Location = new System.Drawing.Point(163, 108);
            this.btnRadnaMjesta.Name = "btnRadnaMjesta";
            this.btnRadnaMjesta.Size = new System.Drawing.Size(75, 35);
            this.btnRadnaMjesta.TabIndex = 3;
            this.btnRadnaMjesta.Text = "Radna mjesta";
            this.btnRadnaMjesta.UseVisualStyleBackColor = true;
            this.btnRadnaMjesta.Click += new System.EventHandler(this.btnRadnaMjesta_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.Transparent;
            this.btnPovratak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPovratak.BackgroundImage")));
            this.btnPovratak.Location = new System.Drawing.Point(34, 24);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(43, 41);
            this.btnPovratak.TabIndex = 4;
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // FrmZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(282, 338);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnRadnaMjesta);
            this.Controls.Add(this.btnDodajZaposlenika);
            this.Controls.Add(this.dgvZaposlenici);
            this.Name = "FrmZaposlenici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upravljanje zaposlenicima";
            this.Load += new System.EventHandler(this.FrmZaposlenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnomjestoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.BindingSource radnomjestoBindingSource;
        private System.Windows.Forms.Button btnDodajZaposlenika;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idradnomjestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racunsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn radnomjestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRadnaMjesta;
        private System.Windows.Forms.Button btnPovratak;
    }
}