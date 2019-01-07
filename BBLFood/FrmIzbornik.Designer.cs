namespace Projekt_forme
{
    partial class FrmIzbornik
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
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.btnJelovnici = new System.Windows.Forms.Button();
            this.btnZaposlenici = new System.Windows.Forms.Button();
            this.btnIzdavanjeRacuna = new System.Windows.Forms.Button();
            this.btnZalihe = new System.Windows.Forms.Button();
            this.btnIzvjestaji = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.Location = new System.Drawing.Point(41, 43);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(198, 49);
            this.btnRezervacije.TabIndex = 0;
            this.btnRezervacije.Text = "Rezervacije";
            this.btnRezervacije.UseVisualStyleBackColor = true;
            this.btnRezervacije.Click += new System.EventHandler(this.btnRezervacije_Click);
            // 
            // btnJelovnici
            // 
            this.btnJelovnici.Location = new System.Drawing.Point(310, 43);
            this.btnJelovnici.Name = "btnJelovnici";
            this.btnJelovnici.Size = new System.Drawing.Size(198, 49);
            this.btnJelovnici.TabIndex = 1;
            this.btnJelovnici.Text = "Jelovnici";
            this.btnJelovnici.UseVisualStyleBackColor = true;
            this.btnJelovnici.Click += new System.EventHandler(this.btnJelovnici_Click);
            // 
            // btnZaposlenici
            // 
            this.btnZaposlenici.Location = new System.Drawing.Point(41, 125);
            this.btnZaposlenici.Name = "btnZaposlenici";
            this.btnZaposlenici.Size = new System.Drawing.Size(198, 49);
            this.btnZaposlenici.TabIndex = 2;
            this.btnZaposlenici.Text = "Zaposlenici";
            this.btnZaposlenici.UseVisualStyleBackColor = true;
            this.btnZaposlenici.Click += new System.EventHandler(this.btnZaposlenici_Click);
            // 
            // btnIzdavanjeRacuna
            // 
            this.btnIzdavanjeRacuna.Location = new System.Drawing.Point(310, 125);
            this.btnIzdavanjeRacuna.Name = "btnIzdavanjeRacuna";
            this.btnIzdavanjeRacuna.Size = new System.Drawing.Size(198, 49);
            this.btnIzdavanjeRacuna.TabIndex = 3;
            this.btnIzdavanjeRacuna.Text = "Izdavanje računa";
            this.btnIzdavanjeRacuna.UseVisualStyleBackColor = true;
            this.btnIzdavanjeRacuna.Click += new System.EventHandler(this.btnIzdavanjeRacuna_Click);
            // 
            // btnZalihe
            // 
            this.btnZalihe.Location = new System.Drawing.Point(41, 204);
            this.btnZalihe.Name = "btnZalihe";
            this.btnZalihe.Size = new System.Drawing.Size(198, 49);
            this.btnZalihe.TabIndex = 4;
            this.btnZalihe.Text = "Zalihe";
            this.btnZalihe.UseVisualStyleBackColor = true;
            this.btnZalihe.Click += new System.EventHandler(this.btnZalihe_Click);
            // 
            // btnIzvjestaji
            // 
            this.btnIzvjestaji.Location = new System.Drawing.Point(310, 204);
            this.btnIzvjestaji.Name = "btnIzvjestaji";
            this.btnIzvjestaji.Size = new System.Drawing.Size(198, 49);
            this.btnIzvjestaji.TabIndex = 5;
            this.btnIzvjestaji.Text = "Izvještaji";
            this.btnIzvjestaji.UseVisualStyleBackColor = true;
            this.btnIzvjestaji.Click += new System.EventHandler(this.btnIzvjestaji_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(41, 320);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(113, 49);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(395, 320);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(113, 49);
            this.btnIzlaz.TabIndex = 7;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // FrmIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 409);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnIzvjestaji);
            this.Controls.Add(this.btnZalihe);
            this.Controls.Add(this.btnIzdavanjeRacuna);
            this.Controls.Add(this.btnZaposlenici);
            this.Controls.Add(this.btnJelovnici);
            this.Controls.Add(this.btnRezervacije);
            this.Name = "FrmIzbornik";
            this.Text = "Glavni izbornik [BBL Food]";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRezervacije;
        private System.Windows.Forms.Button btnJelovnici;
        private System.Windows.Forms.Button btnZaposlenici;
        private System.Windows.Forms.Button btnIzdavanjeRacuna;
        private System.Windows.Forms.Button btnZalihe;
        private System.Windows.Forms.Button btnIzvjestaji;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnIzlaz;
    }
}

