namespace BBLFood
{
    partial class FrmJelovnici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJelovnici));
            this.dgvJelovnici = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jelovnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.cmbPredjelo = new System.Windows.Forms.ComboBox();
            this.lblPredjelo = new System.Windows.Forms.Label();
            this.lblGlavnoJelo = new System.Windows.Forms.Label();
            this.lblDesert = new System.Windows.Forms.Label();
            this.cmbGlavnoJelo = new System.Windows.Forms.ComboBox();
            this.cmbDesert = new System.Windows.Forms.ComboBox();
            this.btnDodajPredjelo = new System.Windows.Forms.Button();
            this.btnDodajGlavnoJelo = new System.Windows.Forms.Button();
            this.btnDodajDesert = new System.Windows.Forms.Button();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJelovnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jelovnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJelovnici
            // 
            this.dgvJelovnici.AllowUserToAddRows = false;
            this.dgvJelovnici.AllowUserToDeleteRows = false;
            this.dgvJelovnici.AutoGenerateColumns = false;
            this.dgvJelovnici.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvJelovnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJelovnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn});
            this.dgvJelovnici.DataSource = this.jelovnikBindingSource;
            this.dgvJelovnici.Location = new System.Drawing.Point(198, 34);
            this.dgvJelovnici.Name = "dgvJelovnici";
            this.dgvJelovnici.ReadOnly = true;
            this.dgvJelovnici.RowHeadersVisible = false;
            this.dgvJelovnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJelovnici.Size = new System.Drawing.Size(324, 137);
            this.dgvJelovnici.TabIndex = 29;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Šifra";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jelovnikBindingSource
            // 
            this.jelovnikBindingSource.DataSource = typeof(BBLFood.jelovnik);
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.Transparent;
            this.btnPovratak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPovratak.BackgroundImage")));
            this.btnPovratak.Location = new System.Drawing.Point(35, 34);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(43, 41);
            this.btnPovratak.TabIndex = 30;
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(35, 193);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(70, 40);
            this.btnDodaj.TabIndex = 31;
            this.btnDodaj.Text = "Dodaj jelovnik";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(109, 256);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(203, 20);
            this.txtNaziv.TabIndex = 33;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(39, 256);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 32;
            this.lblNaziv.Text = "Naziv:";
            // 
            // cmbPredjelo
            // 
            this.cmbPredjelo.FormattingEnabled = true;
            this.cmbPredjelo.Location = new System.Drawing.Point(495, 217);
            this.cmbPredjelo.Name = "cmbPredjelo";
            this.cmbPredjelo.Size = new System.Drawing.Size(182, 21);
            this.cmbPredjelo.TabIndex = 34;
            // 
            // lblPredjelo
            // 
            this.lblPredjelo.AutoSize = true;
            this.lblPredjelo.Location = new System.Drawing.Point(401, 220);
            this.lblPredjelo.Name = "lblPredjelo";
            this.lblPredjelo.Size = new System.Drawing.Size(48, 13);
            this.lblPredjelo.TabIndex = 35;
            this.lblPredjelo.Text = "Predjelo:";
            // 
            // lblGlavnoJelo
            // 
            this.lblGlavnoJelo.AutoSize = true;
            this.lblGlavnoJelo.Location = new System.Drawing.Point(401, 258);
            this.lblGlavnoJelo.Name = "lblGlavnoJelo";
            this.lblGlavnoJelo.Size = new System.Drawing.Size(63, 13);
            this.lblGlavnoJelo.TabIndex = 36;
            this.lblGlavnoJelo.Text = "Glavno jelo:";
            // 
            // lblDesert
            // 
            this.lblDesert.AutoSize = true;
            this.lblDesert.Location = new System.Drawing.Point(401, 295);
            this.lblDesert.Name = "lblDesert";
            this.lblDesert.Size = new System.Drawing.Size(41, 13);
            this.lblDesert.TabIndex = 37;
            this.lblDesert.Text = "Desert:";
            // 
            // cmbGlavnoJelo
            // 
            this.cmbGlavnoJelo.FormattingEnabled = true;
            this.cmbGlavnoJelo.Location = new System.Drawing.Point(495, 255);
            this.cmbGlavnoJelo.Name = "cmbGlavnoJelo";
            this.cmbGlavnoJelo.Size = new System.Drawing.Size(182, 21);
            this.cmbGlavnoJelo.TabIndex = 38;
            // 
            // cmbDesert
            // 
            this.cmbDesert.FormattingEnabled = true;
            this.cmbDesert.Location = new System.Drawing.Point(495, 292);
            this.cmbDesert.Name = "cmbDesert";
            this.cmbDesert.Size = new System.Drawing.Size(182, 21);
            this.cmbDesert.TabIndex = 39;
            // 
            // btnDodajPredjelo
            // 
            this.btnDodajPredjelo.Location = new System.Drawing.Point(711, 217);
            this.btnDodajPredjelo.Name = "btnDodajPredjelo";
            this.btnDodajPredjelo.Size = new System.Drawing.Size(75, 23);
            this.btnDodajPredjelo.TabIndex = 40;
            this.btnDodajPredjelo.Text = "Dodaj";
            this.btnDodajPredjelo.UseVisualStyleBackColor = true;
            this.btnDodajPredjelo.Click += new System.EventHandler(this.btnDodajPredjelo_Click);
            // 
            // btnDodajGlavnoJelo
            // 
            this.btnDodajGlavnoJelo.Location = new System.Drawing.Point(711, 253);
            this.btnDodajGlavnoJelo.Name = "btnDodajGlavnoJelo";
            this.btnDodajGlavnoJelo.Size = new System.Drawing.Size(75, 23);
            this.btnDodajGlavnoJelo.TabIndex = 41;
            this.btnDodajGlavnoJelo.Text = "Dodaj";
            this.btnDodajGlavnoJelo.UseVisualStyleBackColor = true;
            this.btnDodajGlavnoJelo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDodajDesert
            // 
            this.btnDodajDesert.Location = new System.Drawing.Point(711, 290);
            this.btnDodajDesert.Name = "btnDodajDesert";
            this.btnDodajDesert.Size = new System.Drawing.Size(75, 23);
            this.btnDodajDesert.TabIndex = 42;
            this.btnDodajDesert.Text = "Dodaj";
            this.btnDodajDesert.UseVisualStyleBackColor = true;
            this.btnDodajDesert.Click += new System.EventHandler(this.btnDodajDesert_Click);
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(109, 297);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(70, 20);
            this.txtCijena.TabIndex = 44;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(39, 300);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(39, 13);
            this.lblCijena.TabIndex = 43;
            this.lblCijena.Text = "Cijena:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(109, 338);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(70, 28);
            this.btnSpremi.TabIndex = 45;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // FrmJelovnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(835, 404);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.btnDodajDesert);
            this.Controls.Add(this.btnDodajGlavnoJelo);
            this.Controls.Add(this.btnDodajPredjelo);
            this.Controls.Add(this.cmbDesert);
            this.Controls.Add(this.cmbGlavnoJelo);
            this.Controls.Add(this.lblDesert);
            this.Controls.Add(this.lblGlavnoJelo);
            this.Controls.Add(this.lblPredjelo);
            this.Controls.Add(this.cmbPredjelo);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.dgvJelovnici);
            this.Name = "FrmJelovnici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jelovnici";
            this.Load += new System.EventHandler(this.FrmJelovnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJelovnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jelovnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJelovnici;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeloesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource jelovnikBindingSource;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.ComboBox cmbPredjelo;
        private System.Windows.Forms.Label lblPredjelo;
        private System.Windows.Forms.Label lblGlavnoJelo;
        private System.Windows.Forms.Label lblDesert;
        private System.Windows.Forms.ComboBox cmbGlavnoJelo;
        private System.Windows.Forms.ComboBox cmbDesert;
        private System.Windows.Forms.Button btnDodajPredjelo;
        private System.Windows.Forms.Button btnDodajGlavnoJelo;
        private System.Windows.Forms.Button btnDodajDesert;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Button btnSpremi;
    }
}