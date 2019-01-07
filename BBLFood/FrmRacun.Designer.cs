namespace BBLFood
{
    partial class FrmRacun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRacun));
            this.btnNoviRacun = new System.Windows.Forms.Button();
            this.btnDodajJelo = new System.Windows.Forms.Button();
            this.txtKolicinaJelo = new System.Windows.Forms.TextBox();
            this.lblKolicinaJelo = new System.Windows.Forms.Label();
            this.lblJelo = new System.Windows.Forms.Label();
            this.cmbJelo = new System.Windows.Forms.ComboBox();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.cmbZaposlenik = new System.Windows.Forms.ComboBox();
            this.dgvRacun = new System.Windows.Forms.DataGridView();
            this.rTxtStavke = new System.Windows.Forms.RichTextBox();
            this.btnIzdaj = new System.Windows.Forms.Button();
            this.txtZaPlatiti = new System.Windows.Forms.TextBox();
            this.lblZaPlatiti = new System.Windows.Forms.Label();
            this.lblKuna = new System.Windows.Forms.Label();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.lblJelovnik = new System.Windows.Forms.Label();
            this.cmbJelovnik = new System.Windows.Forms.ComboBox();
            this.btnDodajJelovnik = new System.Windows.Forms.Button();
            this.txtKolicinaJelovnik = new System.Windows.Forms.TextBox();
            this.lblKolicinaJelovnik = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumvrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idzaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunjeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNoviRacun
            // 
            this.btnNoviRacun.Location = new System.Drawing.Point(370, 77);
            this.btnNoviRacun.Name = "btnNoviRacun";
            this.btnNoviRacun.Size = new System.Drawing.Size(92, 35);
            this.btnNoviRacun.TabIndex = 31;
            this.btnNoviRacun.Text = "Novi Račun";
            this.btnNoviRacun.UseVisualStyleBackColor = true;
            this.btnNoviRacun.Click += new System.EventHandler(this.btnNoviRacun_Click);
            // 
            // btnDodajJelo
            // 
            this.btnDodajJelo.Location = new System.Drawing.Point(466, 158);
            this.btnDodajJelo.Name = "btnDodajJelo";
            this.btnDodajJelo.Size = new System.Drawing.Size(83, 24);
            this.btnDodajJelo.TabIndex = 30;
            this.btnDodajJelo.Text = "Dodaj";
            this.btnDodajJelo.UseVisualStyleBackColor = true;
            this.btnDodajJelo.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtKolicinaJelo
            // 
            this.txtKolicinaJelo.Location = new System.Drawing.Point(384, 161);
            this.txtKolicinaJelo.Name = "txtKolicinaJelo";
            this.txtKolicinaJelo.Size = new System.Drawing.Size(59, 20);
            this.txtKolicinaJelo.TabIndex = 29;
            // 
            // lblKolicinaJelo
            // 
            this.lblKolicinaJelo.AutoSize = true;
            this.lblKolicinaJelo.Location = new System.Drawing.Point(321, 164);
            this.lblKolicinaJelo.Name = "lblKolicinaJelo";
            this.lblKolicinaJelo.Size = new System.Drawing.Size(47, 13);
            this.lblKolicinaJelo.TabIndex = 28;
            this.lblKolicinaJelo.Text = "Količina:";
            // 
            // lblJelo
            // 
            this.lblJelo.AutoSize = true;
            this.lblJelo.Location = new System.Drawing.Point(25, 161);
            this.lblJelo.Name = "lblJelo";
            this.lblJelo.Size = new System.Drawing.Size(29, 13);
            this.lblJelo.TabIndex = 27;
            this.lblJelo.Text = "Jelo:";
            // 
            // cmbJelo
            // 
            this.cmbJelo.DisplayMember = "naziv";
            this.cmbJelo.FormattingEnabled = true;
            this.cmbJelo.Location = new System.Drawing.Point(113, 161);
            this.cmbJelo.Name = "cmbJelo";
            this.cmbJelo.Size = new System.Drawing.Size(191, 21);
            this.cmbJelo.TabIndex = 26;
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Location = new System.Drawing.Point(25, 88);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(62, 13);
            this.lblZaposlenik.TabIndex = 25;
            this.lblZaposlenik.Text = "Zaposlenik:";
            // 
            // cmbZaposlenik
            // 
            this.cmbZaposlenik.FormattingEnabled = true;
            this.cmbZaposlenik.Location = new System.Drawing.Point(113, 85);
            this.cmbZaposlenik.Name = "cmbZaposlenik";
            this.cmbZaposlenik.Size = new System.Drawing.Size(191, 21);
            this.cmbZaposlenik.TabIndex = 24;
            // 
            // dgvRacun
            // 
            this.dgvRacun.AllowUserToAddRows = false;
            this.dgvRacun.AllowUserToDeleteRows = false;
            this.dgvRacun.AutoGenerateColumns = false;
            this.dgvRacun.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.datumvrijemeDataGridViewTextBoxColumn,
            this.iznosDataGridViewTextBoxColumn,
            this.idzaposlenikDataGridViewTextBoxColumn,
            this.racunjeloDataGridViewTextBoxColumn,
            this.zaposlenikDataGridViewTextBoxColumn});
            this.dgvRacun.DataSource = this.racunBindingSource;
            this.dgvRacun.Location = new System.Drawing.Point(74, 260);
            this.dgvRacun.Name = "dgvRacun";
            this.dgvRacun.ReadOnly = true;
            this.dgvRacun.RowHeadersVisible = false;
            this.dgvRacun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacun.Size = new System.Drawing.Size(203, 52);
            this.dgvRacun.TabIndex = 32;
            // 
            // rTxtStavke
            // 
            this.rTxtStavke.Location = new System.Drawing.Point(320, 241);
            this.rTxtStavke.Name = "rTxtStavke";
            this.rTxtStavke.Size = new System.Drawing.Size(229, 209);
            this.rTxtStavke.TabIndex = 33;
            this.rTxtStavke.Text = "";
            // 
            // btnIzdaj
            // 
            this.btnIzdaj.Location = new System.Drawing.Point(457, 468);
            this.btnIzdaj.Name = "btnIzdaj";
            this.btnIzdaj.Size = new System.Drawing.Size(92, 35);
            this.btnIzdaj.TabIndex = 34;
            this.btnIzdaj.Text = "Izdaj račun";
            this.btnIzdaj.UseVisualStyleBackColor = true;
            this.btnIzdaj.Click += new System.EventHandler(this.btnIzdaj_Click);
            // 
            // txtZaPlatiti
            // 
            this.txtZaPlatiti.Location = new System.Drawing.Point(358, 476);
            this.txtZaPlatiti.Name = "txtZaPlatiti";
            this.txtZaPlatiti.ReadOnly = true;
            this.txtZaPlatiti.Size = new System.Drawing.Size(59, 20);
            this.txtZaPlatiti.TabIndex = 36;
            // 
            // lblZaPlatiti
            // 
            this.lblZaPlatiti.AutoSize = true;
            this.lblZaPlatiti.Location = new System.Drawing.Point(295, 479);
            this.lblZaPlatiti.Name = "lblZaPlatiti";
            this.lblZaPlatiti.Size = new System.Drawing.Size(50, 13);
            this.lblZaPlatiti.TabIndex = 35;
            this.lblZaPlatiti.Text = "Za platiti:";
            // 
            // lblKuna
            // 
            this.lblKuna.AutoSize = true;
            this.lblKuna.Location = new System.Drawing.Point(424, 478);
            this.lblKuna.Name = "lblKuna";
            this.lblKuna.Size = new System.Drawing.Size(19, 13);
            this.lblKuna.TabIndex = 37;
            this.lblKuna.Text = "kn";
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.Transparent;
            this.btnPovratak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPovratak.BackgroundImage")));
            this.btnPovratak.Location = new System.Drawing.Point(26, 12);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(43, 41);
            this.btnPovratak.TabIndex = 38;
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // lblJelovnik
            // 
            this.lblJelovnik.AutoSize = true;
            this.lblJelovnik.Location = new System.Drawing.Point(25, 201);
            this.lblJelovnik.Name = "lblJelovnik";
            this.lblJelovnik.Size = new System.Drawing.Size(49, 13);
            this.lblJelovnik.TabIndex = 40;
            this.lblJelovnik.Text = "Jelovnik:";
            // 
            // cmbJelovnik
            // 
            this.cmbJelovnik.DisplayMember = "naziv";
            this.cmbJelovnik.FormattingEnabled = true;
            this.cmbJelovnik.Location = new System.Drawing.Point(113, 198);
            this.cmbJelovnik.Name = "cmbJelovnik";
            this.cmbJelovnik.Size = new System.Drawing.Size(191, 21);
            this.cmbJelovnik.TabIndex = 39;
            // 
            // btnDodajJelovnik
            // 
            this.btnDodajJelovnik.Location = new System.Drawing.Point(466, 198);
            this.btnDodajJelovnik.Name = "btnDodajJelovnik";
            this.btnDodajJelovnik.Size = new System.Drawing.Size(83, 24);
            this.btnDodajJelovnik.TabIndex = 43;
            this.btnDodajJelovnik.Text = "Dodaj";
            this.btnDodajJelovnik.UseVisualStyleBackColor = true;
            this.btnDodajJelovnik.Click += new System.EventHandler(this.btnDodajJelovnik_Click);
            // 
            // txtKolicinaJelovnik
            // 
            this.txtKolicinaJelovnik.Location = new System.Drawing.Point(384, 198);
            this.txtKolicinaJelovnik.Name = "txtKolicinaJelovnik";
            this.txtKolicinaJelovnik.Size = new System.Drawing.Size(59, 20);
            this.txtKolicinaJelovnik.TabIndex = 42;
            // 
            // lblKolicinaJelovnik
            // 
            this.lblKolicinaJelovnik.AutoSize = true;
            this.lblKolicinaJelovnik.Location = new System.Drawing.Point(321, 201);
            this.lblKolicinaJelovnik.Name = "lblKolicinaJelovnik";
            this.lblKolicinaJelovnik.Size = new System.Drawing.Size(47, 13);
            this.lblKolicinaJelovnik.TabIndex = 41;
            this.lblKolicinaJelovnik.Text = "Količina:";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Šifra";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumvrijemeDataGridViewTextBoxColumn
            // 
            this.datumvrijemeDataGridViewTextBoxColumn.DataPropertyName = "datum_vrijeme";
            this.datumvrijemeDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumvrijemeDataGridViewTextBoxColumn.Name = "datumvrijemeDataGridViewTextBoxColumn";
            this.datumvrijemeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iznosDataGridViewTextBoxColumn
            // 
            this.iznosDataGridViewTextBoxColumn.DataPropertyName = "iznos";
            this.iznosDataGridViewTextBoxColumn.HeaderText = "iznos";
            this.iznosDataGridViewTextBoxColumn.Name = "iznosDataGridViewTextBoxColumn";
            this.iznosDataGridViewTextBoxColumn.ReadOnly = true;
            this.iznosDataGridViewTextBoxColumn.Visible = false;
            // 
            // idzaposlenikDataGridViewTextBoxColumn
            // 
            this.idzaposlenikDataGridViewTextBoxColumn.DataPropertyName = "id_zaposlenik";
            this.idzaposlenikDataGridViewTextBoxColumn.HeaderText = "id_zaposlenik";
            this.idzaposlenikDataGridViewTextBoxColumn.Name = "idzaposlenikDataGridViewTextBoxColumn";
            this.idzaposlenikDataGridViewTextBoxColumn.ReadOnly = true;
            this.idzaposlenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // racunjeloDataGridViewTextBoxColumn
            // 
            this.racunjeloDataGridViewTextBoxColumn.DataPropertyName = "racun_jelo";
            this.racunjeloDataGridViewTextBoxColumn.HeaderText = "racun_jelo";
            this.racunjeloDataGridViewTextBoxColumn.Name = "racunjeloDataGridViewTextBoxColumn";
            this.racunjeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.racunjeloDataGridViewTextBoxColumn.Visible = false;
            // 
            // zaposlenikDataGridViewTextBoxColumn
            // 
            this.zaposlenikDataGridViewTextBoxColumn.DataPropertyName = "zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.HeaderText = "zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.Name = "zaposlenikDataGridViewTextBoxColumn";
            this.zaposlenikDataGridViewTextBoxColumn.ReadOnly = true;
            this.zaposlenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataSource = typeof(BBLFood.racun);
            // 
            // FrmRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(581, 551);
            this.Controls.Add(this.btnDodajJelovnik);
            this.Controls.Add(this.txtKolicinaJelovnik);
            this.Controls.Add(this.lblKolicinaJelovnik);
            this.Controls.Add(this.lblJelovnik);
            this.Controls.Add(this.cmbJelovnik);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.lblKuna);
            this.Controls.Add(this.txtZaPlatiti);
            this.Controls.Add(this.lblZaPlatiti);
            this.Controls.Add(this.btnIzdaj);
            this.Controls.Add(this.rTxtStavke);
            this.Controls.Add(this.dgvRacun);
            this.Controls.Add(this.btnNoviRacun);
            this.Controls.Add(this.btnDodajJelo);
            this.Controls.Add(this.txtKolicinaJelo);
            this.Controls.Add(this.lblKolicinaJelo);
            this.Controls.Add(this.lblJelo);
            this.Controls.Add(this.cmbJelo);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.cmbZaposlenik);
            this.Name = "FrmRacun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi račun";
            this.Load += new System.EventHandler(this.FrmRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNoviRacun;
        private System.Windows.Forms.Button btnDodajJelo;
        private System.Windows.Forms.TextBox txtKolicinaJelo;
        private System.Windows.Forms.Label lblKolicinaJelo;
        private System.Windows.Forms.Label lblJelo;
        private System.Windows.Forms.ComboBox cmbJelo;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.ComboBox cmbZaposlenik;
        private System.Windows.Forms.DataGridView dgvRacun;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumvrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racunjeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private System.Windows.Forms.RichTextBox rTxtStavke;
        private System.Windows.Forms.Button btnIzdaj;
        private System.Windows.Forms.TextBox txtZaPlatiti;
        private System.Windows.Forms.Label lblZaPlatiti;
        private System.Windows.Forms.Label lblKuna;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Label lblJelovnik;
        private System.Windows.Forms.ComboBox cmbJelovnik;
        private System.Windows.Forms.Button btnDodajJelovnik;
        private System.Windows.Forms.TextBox txtKolicinaJelovnik;
        private System.Windows.Forms.Label lblKolicinaJelovnik;
    }
}