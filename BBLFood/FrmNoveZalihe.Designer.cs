namespace Projekt_forme
{
    partial class FrmNoveZalihe
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblMjernaJedinica = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.rbKom = new System.Windows.Forms.RadioButton();
            this.rbKg = new System.Windows.Forms.RadioButton();
            this.rbL = new System.Windows.Forms.RadioButton();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(52, 44);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblMjernaJedinica
            // 
            this.lblMjernaJedinica.AutoSize = true;
            this.lblMjernaJedinica.Location = new System.Drawing.Point(52, 119);
            this.lblMjernaJedinica.Name = "lblMjernaJedinica";
            this.lblMjernaJedinica.Size = new System.Drawing.Size(81, 13);
            this.lblMjernaJedinica.TabIndex = 1;
            this.lblMjernaJedinica.Text = "Mjerna jedinica:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(75, 170);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(129, 41);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(280, 170);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(129, 41);
            this.btnOdustani.TabIndex = 3;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(198, 41);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(211, 20);
            this.txtNaziv.TabIndex = 4;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(198, 77);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 20);
            this.txtKolicina.TabIndex = 5;
            // 
            // rbKom
            // 
            this.rbKom.AutoSize = true;
            this.rbKom.Location = new System.Drawing.Point(198, 115);
            this.rbKom.Name = "rbKom";
            this.rbKom.Size = new System.Drawing.Size(45, 17);
            this.rbKom.TabIndex = 6;
            this.rbKom.TabStop = true;
            this.rbKom.Text = "kom";
            this.rbKom.UseVisualStyleBackColor = true;
            // 
            // rbKg
            // 
            this.rbKg.AutoSize = true;
            this.rbKg.Location = new System.Drawing.Point(268, 115);
            this.rbKg.Name = "rbKg";
            this.rbKg.Size = new System.Drawing.Size(37, 17);
            this.rbKg.TabIndex = 7;
            this.rbKg.TabStop = true;
            this.rbKg.Text = "kg";
            this.rbKg.UseVisualStyleBackColor = true;
            // 
            // rbL
            // 
            this.rbL.AutoSize = true;
            this.rbL.Location = new System.Drawing.Point(334, 115);
            this.rbL.Name = "rbL";
            this.rbL.Size = new System.Drawing.Size(31, 17);
            this.rbL.TabIndex = 8;
            this.rbL.TabStop = true;
            this.rbL.Text = "L";
            this.rbL.UseVisualStyleBackColor = true;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(52, 84);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(44, 13);
            this.lblKolicina.TabIndex = 9;
            this.lblKolicina.Text = "Količina";
            // 
            // FrmNoveZalihe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 242);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.rbL);
            this.Controls.Add(this.rbKg);
            this.Controls.Add(this.rbKom);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblMjernaJedinica);
            this.Controls.Add(this.lblNaziv);
            this.Name = "FrmNoveZalihe";
            this.Text = "Nove zalihe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblMjernaJedinica;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.RadioButton rbKom;
        private System.Windows.Forms.RadioButton rbKg;
        private System.Windows.Forms.RadioButton rbL;
        private System.Windows.Forms.Label lblKolicina;
    }
}