namespace BBLFood
{
    partial class FrmRezervacije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRezervacije));
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imenaruciteljDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimenaruciteljDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktbrojnaruciteljDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojstolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojosobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnObrisiRezervaciju = new System.Windows.Forms.Button();
            this.btnDodajRezervaciju = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AllowUserToAddRows = false;
            this.dgvRezervacije.AllowUserToDeleteRows = false;
            this.dgvRezervacije.AutoGenerateColumns = false;
            this.dgvRezervacije.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imenaruciteljDataGridViewTextBoxColumn,
            this.prezimenaruciteljDataGridViewTextBoxColumn,
            this.kontaktbrojnaruciteljDataGridViewTextBoxColumn,
            this.brojstolaDataGridViewTextBoxColumn,
            this.objedDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.brojosobaDataGridViewTextBoxColumn,
            this.terminDataGridViewTextBoxColumn});
            this.dgvRezervacije.DataSource = this.rezervacijaBindingSource;
            this.dgvRezervacije.Location = new System.Drawing.Point(64, 97);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.ReadOnly = true;
            this.dgvRezervacije.RowHeadersVisible = false;
            this.dgvRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacije.Size = new System.Drawing.Size(627, 180);
            this.dgvRezervacije.TabIndex = 29;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imenaruciteljDataGridViewTextBoxColumn
            // 
            this.imenaruciteljDataGridViewTextBoxColumn.DataPropertyName = "ime_narucitelj";
            this.imenaruciteljDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imenaruciteljDataGridViewTextBoxColumn.Name = "imenaruciteljDataGridViewTextBoxColumn";
            this.imenaruciteljDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimenaruciteljDataGridViewTextBoxColumn
            // 
            this.prezimenaruciteljDataGridViewTextBoxColumn.DataPropertyName = "prezime_narucitelj";
            this.prezimenaruciteljDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimenaruciteljDataGridViewTextBoxColumn.Name = "prezimenaruciteljDataGridViewTextBoxColumn";
            this.prezimenaruciteljDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kontaktbrojnaruciteljDataGridViewTextBoxColumn
            // 
            this.kontaktbrojnaruciteljDataGridViewTextBoxColumn.DataPropertyName = "kontakt_broj_narucitelj";
            this.kontaktbrojnaruciteljDataGridViewTextBoxColumn.HeaderText = "Kontakt";
            this.kontaktbrojnaruciteljDataGridViewTextBoxColumn.Name = "kontaktbrojnaruciteljDataGridViewTextBoxColumn";
            this.kontaktbrojnaruciteljDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brojstolaDataGridViewTextBoxColumn
            // 
            this.brojstolaDataGridViewTextBoxColumn.DataPropertyName = "broj_stola";
            this.brojstolaDataGridViewTextBoxColumn.HeaderText = "Stol";
            this.brojstolaDataGridViewTextBoxColumn.Name = "brojstolaDataGridViewTextBoxColumn";
            this.brojstolaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // objedDataGridViewTextBoxColumn
            // 
            this.objedDataGridViewTextBoxColumn.DataPropertyName = "objed";
            this.objedDataGridViewTextBoxColumn.HeaderText = "Objed";
            this.objedDataGridViewTextBoxColumn.Name = "objedDataGridViewTextBoxColumn";
            this.objedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "datum";
            this.dataGridViewTextBoxColumn1.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // brojosobaDataGridViewTextBoxColumn
            // 
            this.brojosobaDataGridViewTextBoxColumn.DataPropertyName = "broj_osoba";
            this.brojosobaDataGridViewTextBoxColumn.HeaderText = "Broj osoba";
            this.brojosobaDataGridViewTextBoxColumn.Name = "brojosobaDataGridViewTextBoxColumn";
            this.brojosobaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // terminDataGridViewTextBoxColumn
            // 
            this.terminDataGridViewTextBoxColumn.DataPropertyName = "termin";
            this.terminDataGridViewTextBoxColumn.HeaderText = "Vrijeme";
            this.terminDataGridViewTextBoxColumn.Name = "terminDataGridViewTextBoxColumn";
            this.terminDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rezervacijaBindingSource
            // 
            this.rezervacijaBindingSource.DataSource = typeof(BBLFood.rezervacija);
            // 
            // btnObrisiRezervaciju
            // 
            this.btnObrisiRezervaciju.Location = new System.Drawing.Point(586, 297);
            this.btnObrisiRezervaciju.Name = "btnObrisiRezervaciju";
            this.btnObrisiRezervaciju.Size = new System.Drawing.Size(105, 50);
            this.btnObrisiRezervaciju.TabIndex = 31;
            this.btnObrisiRezervaciju.Text = "Obriši rezervaciju";
            this.btnObrisiRezervaciju.UseVisualStyleBackColor = true;
            this.btnObrisiRezervaciju.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodajRezervaciju
            // 
            this.btnDodajRezervaciju.Location = new System.Drawing.Point(64, 297);
            this.btnDodajRezervaciju.Name = "btnDodajRezervaciju";
            this.btnDodajRezervaciju.Size = new System.Drawing.Size(106, 50);
            this.btnDodajRezervaciju.TabIndex = 30;
            this.btnDodajRezervaciju.Text = "Dodaj rezervaciju";
            this.btnDodajRezervaciju.UseVisualStyleBackColor = true;
            this.btnDodajRezervaciju.Click += new System.EventHandler(this.btnDodajRezervaciju_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPovratak.BackgroundImage")));
            this.btnPovratak.Location = new System.Drawing.Point(64, 26);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(43, 41);
            this.btnPovratak.TabIndex = 33;
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // FrmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(770, 389);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnObrisiRezervaciju);
            this.Controls.Add(this.btnDodajRezervaciju);
            this.Controls.Add(this.dgvRezervacije);
            this.Name = "FrmRezervacije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.FrmRezervacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.Button btnObrisiRezervaciju;
        private System.Windows.Forms.Button btnDodajRezervaciju;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imenaruciteljDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimenaruciteljDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktbrojnaruciteljDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojstolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojosobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rezervacijaBindingSource;
    }
}