namespace Projekt_forme
{
    partial class FrmNovoJelo
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
            this.lblNazivJela = new System.Windows.Forms.Label();
            this.txtNazivJela = new System.Windows.Forms.TextBox();
            this.lblSastojak = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.txtSastojak = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNazivJela
            // 
            this.lblNazivJela.AutoSize = true;
            this.lblNazivJela.Location = new System.Drawing.Point(30, 53);
            this.lblNazivJela.Name = "lblNazivJela";
            this.lblNazivJela.Size = new System.Drawing.Size(59, 13);
            this.lblNazivJela.TabIndex = 0;
            this.lblNazivJela.Text = "Naziv jela: ";
            // 
            // txtNazivJela
            // 
            this.txtNazivJela.Location = new System.Drawing.Point(121, 50);
            this.txtNazivJela.Name = "txtNazivJela";
            this.txtNazivJela.Size = new System.Drawing.Size(196, 20);
            this.txtNazivJela.TabIndex = 1;
            // 
            // lblSastojak
            // 
            this.lblSastojak.AutoSize = true;
            this.lblSastojak.Location = new System.Drawing.Point(33, 124);
            this.lblSastojak.Name = "lblSastojak";
            this.lblSastojak.Size = new System.Drawing.Size(51, 13);
            this.lblSastojak.TabIndex = 2;
            this.lblSastojak.Text = "Sastojak:";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(33, 170);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(47, 13);
            this.lblKolicina.TabIndex = 3;
            this.lblKolicina.Text = "Kolicina:";
            // 
            // txtSastojak
            // 
            this.txtSastojak.Location = new System.Drawing.Point(121, 121);
            this.txtSastojak.Name = "txtSastojak";
            this.txtSastojak.Size = new System.Drawing.Size(196, 20);
            this.txtSastojak.TabIndex = 4;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(121, 167);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(67, 20);
            this.txtKolicina.TabIndex = 5;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(36, 228);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(112, 38);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(231, 228);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(114, 38);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmNovoJelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 337);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtSastojak);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblSastojak);
            this.Controls.Add(this.txtNazivJela);
            this.Controls.Add(this.lblNazivJela);
            this.Name = "FrmNovoJelo";
            this.Text = "Novo jelo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazivJela;
        private System.Windows.Forms.TextBox txtNazivJela;
        private System.Windows.Forms.Label lblSastojak;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.TextBox txtSastojak;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
    }
}