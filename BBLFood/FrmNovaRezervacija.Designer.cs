namespace BBLFood
{
    partial class FrmNovaRezervacija
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
            this.txtKontaktBroj = new System.Windows.Forms.TextBox();
            this.lblKontaktBroj = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.cmbZaposlenik = new System.Windows.Forms.ComboBox();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.txtPrezimeKlijenta = new System.Windows.Forms.TextBox();
            this.lblPrezimeKlijenta = new System.Windows.Forms.Label();
            this.txtImeKlijenta = new System.Windows.Forms.TextBox();
            this.lblImeKlijenta = new System.Windows.Forms.Label();
            this.cmbObjed = new System.Windows.Forms.ComboBox();
            this.lblObjed = new System.Windows.Forms.Label();
            this.cmbStol = new System.Windows.Forms.ComboBox();
            this.lblStol = new System.Windows.Forms.Label();
            this.datumRezervacije = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.cmbBrojOsoba = new System.Windows.Forms.ComboBox();
            this.lblBrojOsoba = new System.Windows.Forms.Label();
            this.cmbVrijeme = new System.Windows.Forms.ComboBox();
            this.lblVrijeme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKontaktBroj
            // 
            this.txtKontaktBroj.Location = new System.Drawing.Point(115, 75);
            this.txtKontaktBroj.Name = "txtKontaktBroj";
            this.txtKontaktBroj.Size = new System.Drawing.Size(183, 20);
            this.txtKontaktBroj.TabIndex = 19;
            // 
            // lblKontaktBroj
            // 
            this.lblKontaktBroj.AutoSize = true;
            this.lblKontaktBroj.Location = new System.Drawing.Point(42, 78);
            this.lblKontaktBroj.Name = "lblKontaktBroj";
            this.lblKontaktBroj.Size = new System.Drawing.Size(67, 13);
            this.lblKontaktBroj.TabIndex = 18;
            this.lblKontaktBroj.Text = "Kontakt broj:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(197, 304);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(117, 40);
            this.btnOdustani.TabIndex = 17;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(12, 304);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(117, 40);
            this.btnRezerviraj.TabIndex = 16;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // cmbZaposlenik
            // 
            this.cmbZaposlenik.FormattingEnabled = true;
            this.cmbZaposlenik.Location = new System.Drawing.Point(115, 250);
            this.cmbZaposlenik.Name = "cmbZaposlenik";
            this.cmbZaposlenik.Size = new System.Drawing.Size(183, 21);
            this.cmbZaposlenik.TabIndex = 15;
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Location = new System.Drawing.Point(49, 253);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(62, 13);
            this.lblZaposlenik.TabIndex = 14;
            this.lblZaposlenik.Text = "Zaposlenik:";
            // 
            // txtPrezimeKlijenta
            // 
            this.txtPrezimeKlijenta.Location = new System.Drawing.Point(115, 45);
            this.txtPrezimeKlijenta.Name = "txtPrezimeKlijenta";
            this.txtPrezimeKlijenta.Size = new System.Drawing.Size(183, 20);
            this.txtPrezimeKlijenta.TabIndex = 13;
            // 
            // lblPrezimeKlijenta
            // 
            this.lblPrezimeKlijenta.AutoSize = true;
            this.lblPrezimeKlijenta.Location = new System.Drawing.Point(26, 48);
            this.lblPrezimeKlijenta.Name = "lblPrezimeKlijenta";
            this.lblPrezimeKlijenta.Size = new System.Drawing.Size(83, 13);
            this.lblPrezimeKlijenta.TabIndex = 12;
            this.lblPrezimeKlijenta.Text = "Prezime klijenta:";
            // 
            // txtImeKlijenta
            // 
            this.txtImeKlijenta.Location = new System.Drawing.Point(115, 12);
            this.txtImeKlijenta.Name = "txtImeKlijenta";
            this.txtImeKlijenta.Size = new System.Drawing.Size(183, 20);
            this.txtImeKlijenta.TabIndex = 11;
            // 
            // lblImeKlijenta
            // 
            this.lblImeKlijenta.AutoSize = true;
            this.lblImeKlijenta.Location = new System.Drawing.Point(43, 15);
            this.lblImeKlijenta.Name = "lblImeKlijenta";
            this.lblImeKlijenta.Size = new System.Drawing.Size(66, 13);
            this.lblImeKlijenta.TabIndex = 10;
            this.lblImeKlijenta.Text = "Ime klijenta: ";
            // 
            // cmbObjed
            // 
            this.cmbObjed.FormattingEnabled = true;
            this.cmbObjed.Location = new System.Drawing.Point(115, 164);
            this.cmbObjed.Name = "cmbObjed";
            this.cmbObjed.Size = new System.Drawing.Size(183, 21);
            this.cmbObjed.TabIndex = 21;
            this.cmbObjed.SelectedValueChanged += new System.EventHandler(this.cmbObjed_SelectedValueChanged);
            // 
            // lblObjed
            // 
            this.lblObjed.AutoSize = true;
            this.lblObjed.Location = new System.Drawing.Point(71, 167);
            this.lblObjed.Name = "lblObjed";
            this.lblObjed.Size = new System.Drawing.Size(38, 13);
            this.lblObjed.TabIndex = 20;
            this.lblObjed.Text = "Objed:";
            // 
            // cmbStol
            // 
            this.cmbStol.FormattingEnabled = true;
            this.cmbStol.Location = new System.Drawing.Point(115, 104);
            this.cmbStol.Name = "cmbStol";
            this.cmbStol.Size = new System.Drawing.Size(183, 21);
            this.cmbStol.TabIndex = 23;
            // 
            // lblStol
            // 
            this.lblStol.AutoSize = true;
            this.lblStol.Location = new System.Drawing.Point(81, 107);
            this.lblStol.Name = "lblStol";
            this.lblStol.Size = new System.Drawing.Size(28, 13);
            this.lblStol.TabIndex = 22;
            this.lblStol.Text = "Stol:";
            // 
            // datumRezervacije
            // 
            this.datumRezervacije.Location = new System.Drawing.Point(115, 194);
            this.datumRezervacije.Name = "datumRezervacije";
            this.datumRezervacije.Size = new System.Drawing.Size(183, 20);
            this.datumRezervacije.TabIndex = 24;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(68, 200);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(41, 13);
            this.lblDatum.TabIndex = 25;
            this.lblDatum.Text = "Datum:";
            // 
            // cmbBrojOsoba
            // 
            this.cmbBrojOsoba.FormattingEnabled = true;
            this.cmbBrojOsoba.Location = new System.Drawing.Point(115, 134);
            this.cmbBrojOsoba.Name = "cmbBrojOsoba";
            this.cmbBrojOsoba.Size = new System.Drawing.Size(183, 21);
            this.cmbBrojOsoba.TabIndex = 26;
            // 
            // lblBrojOsoba
            // 
            this.lblBrojOsoba.AutoSize = true;
            this.lblBrojOsoba.Location = new System.Drawing.Point(49, 137);
            this.lblBrojOsoba.Name = "lblBrojOsoba";
            this.lblBrojOsoba.Size = new System.Drawing.Size(60, 13);
            this.lblBrojOsoba.TabIndex = 27;
            this.lblBrojOsoba.Text = "Broj osoba:";
            // 
            // cmbVrijeme
            // 
            this.cmbVrijeme.FormattingEnabled = true;
            this.cmbVrijeme.Location = new System.Drawing.Point(115, 223);
            this.cmbVrijeme.Name = "cmbVrijeme";
            this.cmbVrijeme.Size = new System.Drawing.Size(183, 21);
            this.cmbVrijeme.TabIndex = 28;
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.AutoSize = true;
            this.lblVrijeme.Location = new System.Drawing.Point(65, 226);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(44, 13);
            this.lblVrijeme.TabIndex = 29;
            this.lblVrijeme.Text = "Vrijeme:";
            // 
            // FrmNovaRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(326, 356);
            this.Controls.Add(this.lblVrijeme);
            this.Controls.Add(this.cmbVrijeme);
            this.Controls.Add(this.lblBrojOsoba);
            this.Controls.Add(this.cmbBrojOsoba);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.datumRezervacije);
            this.Controls.Add(this.cmbStol);
            this.Controls.Add(this.lblStol);
            this.Controls.Add(this.cmbObjed);
            this.Controls.Add(this.lblObjed);
            this.Controls.Add(this.txtKontaktBroj);
            this.Controls.Add(this.lblKontaktBroj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.cmbZaposlenik);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.txtPrezimeKlijenta);
            this.Controls.Add(this.lblPrezimeKlijenta);
            this.Controls.Add(this.txtImeKlijenta);
            this.Controls.Add(this.lblImeKlijenta);
            this.Name = "FrmNovaRezervacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervacija";
            this.Load += new System.EventHandler(this.FrmNovaRezervacija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKontaktBroj;
        private System.Windows.Forms.Label lblKontaktBroj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.ComboBox cmbZaposlenik;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.TextBox txtPrezimeKlijenta;
        private System.Windows.Forms.Label lblPrezimeKlijenta;
        private System.Windows.Forms.TextBox txtImeKlijenta;
        private System.Windows.Forms.Label lblImeKlijenta;
        private System.Windows.Forms.ComboBox cmbObjed;
        private System.Windows.Forms.Label lblObjed;
        private System.Windows.Forms.ComboBox cmbStol;
        private System.Windows.Forms.Label lblStol;
        private System.Windows.Forms.DateTimePicker datumRezervacije;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.ComboBox cmbBrojOsoba;
        private System.Windows.Forms.Label lblBrojOsoba;
        private System.Windows.Forms.ComboBox cmbVrijeme;
        private System.Windows.Forms.Label lblVrijeme;
    }
}