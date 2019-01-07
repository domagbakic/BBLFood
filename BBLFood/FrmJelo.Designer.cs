namespace BBLFood
{
    partial class FrmJelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJelo));
            this.btnSpremi = new System.Windows.Forms.Button();
            this.rbDesert = new System.Windows.Forms.RadioButton();
            this.rbGlavnoJelo = new System.Windows.Forms.RadioButton();
            this.rbPredjelo = new System.Windows.Forms.RadioButton();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.lblVrsta = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.dgvJela = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunjeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sastojaksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvSastojci = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjernajedinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idjeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sastojakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodajSastojak = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnDodajJelo = new System.Windows.Forms.Button();
            this.gbDodajJelo = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastojci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sastojakBindingSource)).BeginInit();
            this.gbDodajJelo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(220, 210);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(82, 54);
            this.btnSpremi.TabIndex = 27;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // rbDesert
            // 
            this.rbDesert.AutoSize = true;
            this.rbDesert.Location = new System.Drawing.Point(99, 206);
            this.rbDesert.Name = "rbDesert";
            this.rbDesert.Size = new System.Drawing.Size(56, 17);
            this.rbDesert.TabIndex = 26;
            this.rbDesert.TabStop = true;
            this.rbDesert.Text = "Desert";
            this.rbDesert.UseVisualStyleBackColor = true;
            // 
            // rbGlavnoJelo
            // 
            this.rbGlavnoJelo.AutoSize = true;
            this.rbGlavnoJelo.Location = new System.Drawing.Point(99, 173);
            this.rbGlavnoJelo.Name = "rbGlavnoJelo";
            this.rbGlavnoJelo.Size = new System.Drawing.Size(78, 17);
            this.rbGlavnoJelo.TabIndex = 25;
            this.rbGlavnoJelo.TabStop = true;
            this.rbGlavnoJelo.Text = "GlavnoJelo";
            this.rbGlavnoJelo.UseVisualStyleBackColor = true;
            // 
            // rbPredjelo
            // 
            this.rbPredjelo.AutoSize = true;
            this.rbPredjelo.Location = new System.Drawing.Point(99, 138);
            this.rbPredjelo.Name = "rbPredjelo";
            this.rbPredjelo.Size = new System.Drawing.Size(63, 17);
            this.rbPredjelo.TabIndex = 24;
            this.rbPredjelo.TabStop = true;
            this.rbPredjelo.Text = "Predjelo";
            this.rbPredjelo.UseVisualStyleBackColor = true;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(99, 244);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(66, 20);
            this.txtCijena.TabIndex = 23;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(99, 99);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(203, 20);
            this.txtNaziv.TabIndex = 22;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(27, 247);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(36, 13);
            this.lblCijena.TabIndex = 21;
            this.lblCijena.Text = "Cijena";
            // 
            // lblVrsta
            // 
            this.lblVrsta.AutoSize = true;
            this.lblVrsta.Location = new System.Drawing.Point(27, 138);
            this.lblVrsta.Name = "lblVrsta";
            this.lblVrsta.Size = new System.Drawing.Size(31, 13);
            this.lblVrsta.TabIndex = 20;
            this.lblVrsta.Text = "Vrsta";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(27, 99);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 19;
            this.lblNaziv.Text = "Naziv";
            // 
            // dgvJela
            // 
            this.dgvJela.AllowUserToAddRows = false;
            this.dgvJela.AllowUserToDeleteRows = false;
            this.dgvJela.AutoGenerateColumns = false;
            this.dgvJela.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvJela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.vrstaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.racunjeloDataGridViewTextBoxColumn,
            this.sastojaksDataGridViewTextBoxColumn});
            this.dgvJela.DataSource = this.jeloBindingSource;
            this.dgvJela.Location = new System.Drawing.Point(377, 87);
            this.dgvJela.Name = "dgvJela";
            this.dgvJela.ReadOnly = true;
            this.dgvJela.RowHeadersVisible = false;
            this.dgvJela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJela.Size = new System.Drawing.Size(431, 180);
            this.dgvJela.TabIndex = 28;
            this.dgvJela.SelectionChanged += new System.EventHandler(this.dgvJela_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrstaDataGridViewTextBoxColumn
            // 
            this.vrstaDataGridViewTextBoxColumn.DataPropertyName = "vrsta";
            this.vrstaDataGridViewTextBoxColumn.HeaderText = "Vrsta";
            this.vrstaDataGridViewTextBoxColumn.Name = "vrstaDataGridViewTextBoxColumn";
            this.vrstaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // racunjeloDataGridViewTextBoxColumn
            // 
            this.racunjeloDataGridViewTextBoxColumn.DataPropertyName = "racun_jelo";
            this.racunjeloDataGridViewTextBoxColumn.HeaderText = "racun_jelo";
            this.racunjeloDataGridViewTextBoxColumn.Name = "racunjeloDataGridViewTextBoxColumn";
            this.racunjeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.racunjeloDataGridViewTextBoxColumn.Visible = false;
            // 
            // sastojaksDataGridViewTextBoxColumn
            // 
            this.sastojaksDataGridViewTextBoxColumn.DataPropertyName = "sastojaks";
            this.sastojaksDataGridViewTextBoxColumn.HeaderText = "sastojaks";
            this.sastojaksDataGridViewTextBoxColumn.Name = "sastojaksDataGridViewTextBoxColumn";
            this.sastojaksDataGridViewTextBoxColumn.ReadOnly = true;
            this.sastojaksDataGridViewTextBoxColumn.Visible = false;
            // 
            // jeloBindingSource
            // 
            this.jeloBindingSource.DataSource = typeof(BBLFood.jelo);
            // 
            // dgvSastojci
            // 
            this.dgvSastojci.AllowUserToAddRows = false;
            this.dgvSastojci.AllowUserToDeleteRows = false;
            this.dgvSastojci.AutoGenerateColumns = false;
            this.dgvSastojci.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvSastojci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSastojci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn1,
            this.kolicinaDataGridViewTextBoxColumn,
            this.mjernajedinicaDataGridViewTextBoxColumn,
            this.idjeloDataGridViewTextBoxColumn,
            this.jeloDataGridViewTextBoxColumn});
            this.dgvSastojci.DataSource = this.sastojakBindingSource;
            this.dgvSastojci.Location = new System.Drawing.Point(377, 336);
            this.dgvSastojci.Name = "dgvSastojci";
            this.dgvSastojci.ReadOnly = true;
            this.dgvSastojci.RowHeadersVisible = false;
            this.dgvSastojci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSastojci.Size = new System.Drawing.Size(431, 201);
            this.dgvSastojci.TabIndex = 29;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            this.nazivDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mjernajedinicaDataGridViewTextBoxColumn
            // 
            this.mjernajedinicaDataGridViewTextBoxColumn.DataPropertyName = "mjerna_jedinica";
            this.mjernajedinicaDataGridViewTextBoxColumn.HeaderText = "Mjerna jedinica";
            this.mjernajedinicaDataGridViewTextBoxColumn.Name = "mjernajedinicaDataGridViewTextBoxColumn";
            this.mjernajedinicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idjeloDataGridViewTextBoxColumn
            // 
            this.idjeloDataGridViewTextBoxColumn.DataPropertyName = "id_jelo";
            this.idjeloDataGridViewTextBoxColumn.HeaderText = "id_jelo";
            this.idjeloDataGridViewTextBoxColumn.Name = "idjeloDataGridViewTextBoxColumn";
            this.idjeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.idjeloDataGridViewTextBoxColumn.Visible = false;
            // 
            // jeloDataGridViewTextBoxColumn
            // 
            this.jeloDataGridViewTextBoxColumn.DataPropertyName = "jelo";
            this.jeloDataGridViewTextBoxColumn.HeaderText = "jelo";
            this.jeloDataGridViewTextBoxColumn.Name = "jeloDataGridViewTextBoxColumn";
            this.jeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.jeloDataGridViewTextBoxColumn.Visible = false;
            // 
            // sastojakBindingSource
            // 
            this.sastojakBindingSource.DataSource = typeof(BBLFood.sastojak);
            // 
            // btnDodajSastojak
            // 
            this.btnDodajSastojak.Location = new System.Drawing.Point(243, 399);
            this.btnDodajSastojak.Name = "btnDodajSastojak";
            this.btnDodajSastojak.Size = new System.Drawing.Size(82, 54);
            this.btnDodajSastojak.TabIndex = 30;
            this.btnDodajSastojak.Text = "Dodaj sastojak";
            this.btnDodajSastojak.UseVisualStyleBackColor = true;
            this.btnDodajSastojak.Click += new System.EventHandler(this.btnDodajSastojak_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.Transparent;
            this.btnPovratak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPovratak.BackgroundImage")));
            this.btnPovratak.Location = new System.Drawing.Point(12, 12);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(43, 41);
            this.btnPovratak.TabIndex = 31;
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnDodajJelo
            // 
            this.btnDodajJelo.Location = new System.Drawing.Point(30, 35);
            this.btnDodajJelo.Name = "btnDodajJelo";
            this.btnDodajJelo.Size = new System.Drawing.Size(147, 39);
            this.btnDodajJelo.TabIndex = 32;
            this.btnDodajJelo.Text = "Dodaj Jelo";
            this.btnDodajJelo.UseVisualStyleBackColor = true;
            this.btnDodajJelo.Click += new System.EventHandler(this.btnDodajJelo_Click);
            // 
            // gbDodajJelo
            // 
            this.gbDodajJelo.Controls.Add(this.btnSpremi);
            this.gbDodajJelo.Controls.Add(this.btnDodajJelo);
            this.gbDodajJelo.Controls.Add(this.lblNaziv);
            this.gbDodajJelo.Controls.Add(this.lblVrsta);
            this.gbDodajJelo.Controls.Add(this.lblCijena);
            this.gbDodajJelo.Controls.Add(this.txtNaziv);
            this.gbDodajJelo.Controls.Add(this.txtCijena);
            this.gbDodajJelo.Controls.Add(this.rbPredjelo);
            this.gbDodajJelo.Controls.Add(this.rbDesert);
            this.gbDodajJelo.Controls.Add(this.rbGlavnoJelo);
            this.gbDodajJelo.Location = new System.Drawing.Point(17, 77);
            this.gbDodajJelo.Name = "gbDodajJelo";
            this.gbDodajJelo.Size = new System.Drawing.Size(308, 295);
            this.gbDodajJelo.TabIndex = 33;
            this.gbDodajJelo.TabStop = false;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(243, 469);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(82, 54);
            this.btnObrisi.TabIndex = 34;
            this.btnObrisi.Text = "Briši sastojak";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // FrmJelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(843, 565);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.gbDodajJelo);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnDodajSastojak);
            this.Controls.Add(this.dgvSastojci);
            this.Controls.Add(this.dgvJela);
            this.Name = "FrmJelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upravljanje jelima";
            this.Load += new System.EventHandler(this.FrmJelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastojci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sastojakBindingSource)).EndInit();
            this.gbDodajJelo.ResumeLayout(false);
            this.gbDodajJelo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.RadioButton rbDesert;
        private System.Windows.Forms.RadioButton rbGlavnoJelo;
        private System.Windows.Forms.RadioButton rbPredjelo;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Label lblVrsta;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.DataGridView dgvJela;
        private System.Windows.Forms.DataGridView dgvSastojci;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racunjeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sastojaksDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource jeloBindingSource;
        private System.Windows.Forms.Button btnDodajSastojak;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjernajedinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idjeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sastojakBindingSource;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnDodajJelo;
        private System.Windows.Forms.GroupBox gbDodajJelo;
        private System.Windows.Forms.Button btnObrisi;
    }
}