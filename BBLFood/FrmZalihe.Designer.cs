namespace BBLFood
{
    partial class FrmZalihe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmZalihe));
            this.rbKomad = new System.Windows.Forms.RadioButton();
            this.rbLitra = new System.Windows.Forms.RadioButton();
            this.rbKilogram = new System.Windows.Forms.RadioButton();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblMjernaJedinica = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.dgvZalihe = new System.Windows.Forms.DataGridView();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtKolicinaNadopuni = new System.Windows.Forms.TextBox();
            this.lblKolicinaNadopuni = new System.Windows.Forms.Label();
            this.btnSpremiNadopuni = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnSpremiUmanjiti = new System.Windows.Forms.Button();
            this.txtKolicinaUmanjiti = new System.Windows.Forms.TextBox();
            this.lblKolicinaUmanjiti = new System.Windows.Forms.Label();
            this.gbNadopuni = new System.Windows.Forms.GroupBox();
            this.gbUmanji = new System.Windows.Forms.GroupBox();
            this.gbDodajZalihe = new System.Windows.Forms.GroupBox();
            this.lblKriticnaKolicina = new System.Windows.Forms.Label();
            this.txtKriticnaKolicina = new System.Windows.Forms.TextBox();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjernaJedinicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaliheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZalihe)).BeginInit();
            this.gbNadopuni.SuspendLayout();
            this.gbUmanji.SuspendLayout();
            this.gbDodajZalihe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaliheBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rbKomad
            // 
            this.rbKomad.AutoSize = true;
            this.rbKomad.Location = new System.Drawing.Point(120, 171);
            this.rbKomad.Name = "rbKomad";
            this.rbKomad.Size = new System.Drawing.Size(58, 17);
            this.rbKomad.TabIndex = 16;
            this.rbKomad.TabStop = true;
            this.rbKomad.Text = "Komad";
            this.rbKomad.UseVisualStyleBackColor = true;
            // 
            // rbLitra
            // 
            this.rbLitra.AutoSize = true;
            this.rbLitra.Location = new System.Drawing.Point(121, 148);
            this.rbLitra.Name = "rbLitra";
            this.rbLitra.Size = new System.Drawing.Size(45, 17);
            this.rbLitra.TabIndex = 15;
            this.rbLitra.TabStop = true;
            this.rbLitra.Text = "Litra";
            this.rbLitra.UseVisualStyleBackColor = true;
            // 
            // rbKilogram
            // 
            this.rbKilogram.AutoSize = true;
            this.rbKilogram.Location = new System.Drawing.Point(121, 125);
            this.rbKilogram.Name = "rbKilogram";
            this.rbKilogram.Size = new System.Drawing.Size(65, 17);
            this.rbKilogram.TabIndex = 14;
            this.rbKilogram.TabStop = true;
            this.rbKilogram.Text = "Kilogram";
            this.rbKilogram.UseVisualStyleBackColor = true;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(121, 58);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(84, 20);
            this.txtKolicina.TabIndex = 13;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(121, 25);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(215, 20);
            this.txtNaziv.TabIndex = 12;
            // 
            // lblMjernaJedinica
            // 
            this.lblMjernaJedinica.AutoSize = true;
            this.lblMjernaJedinica.Location = new System.Drawing.Point(30, 125);
            this.lblMjernaJedinica.Name = "lblMjernaJedinica";
            this.lblMjernaJedinica.Size = new System.Drawing.Size(81, 13);
            this.lblMjernaJedinica.TabIndex = 11;
            this.lblMjernaJedinica.Text = "Mjerna jedinica:";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(30, 61);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(47, 13);
            this.lblKolicina.TabIndex = 10;
            this.lblKolicina.Text = "Količina:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(30, 28);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 9;
            this.lblNaziv.Text = "Naziv:";
            // 
            // dgvZalihe
            // 
            this.dgvZalihe.AllowUserToAddRows = false;
            this.dgvZalihe.AllowUserToDeleteRows = false;
            this.dgvZalihe.AutoGenerateColumns = false;
            this.dgvZalihe.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvZalihe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZalihe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.mjernaJedinicaDataGridViewTextBoxColumn});
            this.dgvZalihe.DataSource = this.zaliheBindingSource;
            this.dgvZalihe.Location = new System.Drawing.Point(146, 324);
            this.dgvZalihe.Name = "dgvZalihe";
            this.dgvZalihe.ReadOnly = true;
            this.dgvZalihe.RowHeadersVisible = false;
            this.dgvZalihe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZalihe.Size = new System.Drawing.Size(366, 224);
            this.dgvZalihe.TabIndex = 29;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(33, 212);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(100, 32);
            this.btnSpremi.TabIndex = 30;
            this.btnSpremi.Text = "Dodaj zalihe";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtKolicinaNadopuni
            // 
            this.txtKolicinaNadopuni.Location = new System.Drawing.Point(105, 37);
            this.txtKolicinaNadopuni.Name = "txtKolicinaNadopuni";
            this.txtKolicinaNadopuni.Size = new System.Drawing.Size(69, 20);
            this.txtKolicinaNadopuni.TabIndex = 33;
            // 
            // lblKolicinaNadopuni
            // 
            this.lblKolicinaNadopuni.AutoSize = true;
            this.lblKolicinaNadopuni.Location = new System.Drawing.Point(26, 40);
            this.lblKolicinaNadopuni.Name = "lblKolicinaNadopuni";
            this.lblKolicinaNadopuni.Size = new System.Drawing.Size(47, 13);
            this.lblKolicinaNadopuni.TabIndex = 32;
            this.lblKolicinaNadopuni.Text = "Količina:";
            // 
            // btnSpremiNadopuni
            // 
            this.btnSpremiNadopuni.Location = new System.Drawing.Point(29, 75);
            this.btnSpremiNadopuni.Name = "btnSpremiNadopuni";
            this.btnSpremiNadopuni.Size = new System.Drawing.Size(145, 32);
            this.btnSpremiNadopuni.TabIndex = 34;
            this.btnSpremiNadopuni.Text = "Nadopuni zalihe";
            this.btnSpremiNadopuni.UseVisualStyleBackColor = true;
            this.btnSpremiNadopuni.Click += new System.EventHandler(this.btnSpremiNadopuni_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.Transparent;
            this.btnPovratak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPovratak.BackgroundImage")));
            this.btnPovratak.Location = new System.Drawing.Point(41, 33);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(43, 41);
            this.btnPovratak.TabIndex = 35;
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnSpremiUmanjiti
            // 
            this.btnSpremiUmanjiti.Location = new System.Drawing.Point(29, 64);
            this.btnSpremiUmanjiti.Name = "btnSpremiUmanjiti";
            this.btnSpremiUmanjiti.Size = new System.Drawing.Size(145, 32);
            this.btnSpremiUmanjiti.TabIndex = 39;
            this.btnSpremiUmanjiti.Text = "Umanji zalihe";
            this.btnSpremiUmanjiti.UseVisualStyleBackColor = true;
            this.btnSpremiUmanjiti.Click += new System.EventHandler(this.btnSpremiUmanjiti_Click);
            // 
            // txtKolicinaUmanjiti
            // 
            this.txtKolicinaUmanjiti.Location = new System.Drawing.Point(105, 31);
            this.txtKolicinaUmanjiti.Name = "txtKolicinaUmanjiti";
            this.txtKolicinaUmanjiti.Size = new System.Drawing.Size(69, 20);
            this.txtKolicinaUmanjiti.TabIndex = 38;
            // 
            // lblKolicinaUmanjiti
            // 
            this.lblKolicinaUmanjiti.AutoSize = true;
            this.lblKolicinaUmanjiti.Location = new System.Drawing.Point(26, 34);
            this.lblKolicinaUmanjiti.Name = "lblKolicinaUmanjiti";
            this.lblKolicinaUmanjiti.Size = new System.Drawing.Size(47, 13);
            this.lblKolicinaUmanjiti.TabIndex = 37;
            this.lblKolicinaUmanjiti.Text = "Količina:";
            // 
            // gbNadopuni
            // 
            this.gbNadopuni.Controls.Add(this.lblKolicinaNadopuni);
            this.gbNadopuni.Controls.Add(this.txtKolicinaNadopuni);
            this.gbNadopuni.Controls.Add(this.btnSpremiNadopuni);
            this.gbNadopuni.Location = new System.Drawing.Point(547, 33);
            this.gbNadopuni.Name = "gbNadopuni";
            this.gbNadopuni.Size = new System.Drawing.Size(200, 129);
            this.gbNadopuni.TabIndex = 40;
            this.gbNadopuni.TabStop = false;
            // 
            // gbUmanji
            // 
            this.gbUmanji.Controls.Add(this.btnSpremiUmanjiti);
            this.gbUmanji.Controls.Add(this.txtKolicinaUmanjiti);
            this.gbUmanji.Controls.Add(this.lblKolicinaUmanjiti);
            this.gbUmanji.Location = new System.Drawing.Point(547, 181);
            this.gbUmanji.Name = "gbUmanji";
            this.gbUmanji.Size = new System.Drawing.Size(200, 123);
            this.gbUmanji.TabIndex = 41;
            this.gbUmanji.TabStop = false;
            this.gbUmanji.Enter += new System.EventHandler(this.gbUmanji_Enter);
            // 
            // gbDodajZalihe
            // 
            this.gbDodajZalihe.Controls.Add(this.lblKriticnaKolicina);
            this.gbDodajZalihe.Controls.Add(this.txtKriticnaKolicina);
            this.gbDodajZalihe.Controls.Add(this.btnSpremi);
            this.gbDodajZalihe.Controls.Add(this.lblNaziv);
            this.gbDodajZalihe.Controls.Add(this.lblKolicina);
            this.gbDodajZalihe.Controls.Add(this.lblMjernaJedinica);
            this.gbDodajZalihe.Controls.Add(this.txtNaziv);
            this.gbDodajZalihe.Controls.Add(this.txtKolicina);
            this.gbDodajZalihe.Controls.Add(this.rbKilogram);
            this.gbDodajZalihe.Controls.Add(this.rbKomad);
            this.gbDodajZalihe.Controls.Add(this.rbLitra);
            this.gbDodajZalihe.Location = new System.Drawing.Point(146, 33);
            this.gbDodajZalihe.Name = "gbDodajZalihe";
            this.gbDodajZalihe.Size = new System.Drawing.Size(366, 271);
            this.gbDodajZalihe.TabIndex = 42;
            this.gbDodajZalihe.TabStop = false;
            // 
            // lblKriticnaKolicina
            // 
            this.lblKriticnaKolicina.AutoSize = true;
            this.lblKriticnaKolicina.Location = new System.Drawing.Point(30, 94);
            this.lblKriticnaKolicina.Name = "lblKriticnaKolicina";
            this.lblKriticnaKolicina.Size = new System.Drawing.Size(84, 13);
            this.lblKriticnaKolicina.TabIndex = 31;
            this.lblKriticnaKolicina.Text = "Kritična količina:";
            // 
            // txtKriticnaKolicina
            // 
            this.txtKriticnaKolicina.Location = new System.Drawing.Point(121, 91);
            this.txtKriticnaKolicina.Name = "txtKriticnaKolicina";
            this.txtKriticnaKolicina.Size = new System.Drawing.Size(84, 20);
            this.txtKriticnaKolicina.TabIndex = 32;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(595, 321);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(152, 20);
            this.txtPretraga.TabIndex = 43;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(544, 324);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(33, 13);
            this.lblPretraga.TabIndex = 40;
            this.lblPretraga.Text = "Traži:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(547, 364);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 32);
            this.btnObrisi.TabIndex = 31;
            this.btnObrisi.Text = "Briši zalihe";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click_1);
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
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mjernaJedinicaDataGridViewTextBoxColumn
            // 
            this.mjernaJedinicaDataGridViewTextBoxColumn.DataPropertyName = "mjernaJedinica";
            this.mjernaJedinicaDataGridViewTextBoxColumn.HeaderText = "Mjerna jedinica";
            this.mjernaJedinicaDataGridViewTextBoxColumn.Name = "mjernaJedinicaDataGridViewTextBoxColumn";
            this.mjernaJedinicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zaliheBindingSource
            // 
            this.zaliheBindingSource.DataSource = typeof(BBLFood.zalihe);
            // 
            // FrmZalihe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(804, 562);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.gbDodajZalihe);
            this.Controls.Add(this.gbUmanji);
            this.Controls.Add(this.gbNadopuni);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.dgvZalihe);
            this.Name = "FrmZalihe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zalihe";
            this.Load += new System.EventHandler(this.FrmZalihe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZalihe)).EndInit();
            this.gbNadopuni.ResumeLayout(false);
            this.gbNadopuni.PerformLayout();
            this.gbUmanji.ResumeLayout(false);
            this.gbUmanji.PerformLayout();
            this.gbDodajZalihe.ResumeLayout(false);
            this.gbDodajZalihe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaliheBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbKomad;
        private System.Windows.Forms.RadioButton rbLitra;
        private System.Windows.Forms.RadioButton rbKilogram;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblMjernaJedinica;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.DataGridView dgvZalihe;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjernaJedinicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zaliheBindingSource;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtKolicinaNadopuni;
        private System.Windows.Forms.Label lblKolicinaNadopuni;
        private System.Windows.Forms.Button btnSpremiNadopuni;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnSpremiUmanjiti;
        private System.Windows.Forms.TextBox txtKolicinaUmanjiti;
        private System.Windows.Forms.Label lblKolicinaUmanjiti;
        private System.Windows.Forms.GroupBox gbNadopuni;
        private System.Windows.Forms.GroupBox gbUmanji;
        private System.Windows.Forms.GroupBox gbDodajZalihe;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblKriticnaKolicina;
        private System.Windows.Forms.TextBox txtKriticnaKolicina;
    }
}