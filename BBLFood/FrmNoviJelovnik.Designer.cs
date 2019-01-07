namespace Projekt_forme
{
    partial class FrmNoviJelovnik
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
            this.lblNazivJelovnika = new System.Windows.Forms.Label();
            this.lblPredjelo = new System.Windows.Forms.Label();
            this.lblGlavnoJelo = new System.Windows.Forms.Label();
            this.lblDesert = new System.Windows.Forms.Label();
            this.txtNazivJelovnika = new System.Windows.Forms.TextBox();
            this.cmbPredjelo = new System.Windows.Forms.ComboBox();
            this.cmbGlavnoJelo = new System.Windows.Forms.ComboBox();
            this.cmbDesert = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNazivJelovnika
            // 
            this.lblNazivJelovnika.AutoSize = true;
            this.lblNazivJelovnika.Location = new System.Drawing.Point(47, 68);
            this.lblNazivJelovnika.Name = "lblNazivJelovnika";
            this.lblNazivJelovnika.Size = new System.Drawing.Size(82, 13);
            this.lblNazivJelovnika.TabIndex = 0;
            this.lblNazivJelovnika.Text = "Naziv jelovnika:";
            // 
            // lblPredjelo
            // 
            this.lblPredjelo.AutoSize = true;
            this.lblPredjelo.Location = new System.Drawing.Point(47, 109);
            this.lblPredjelo.Name = "lblPredjelo";
            this.lblPredjelo.Size = new System.Drawing.Size(48, 13);
            this.lblPredjelo.TabIndex = 1;
            this.lblPredjelo.Text = "Predjelo:";
            // 
            // lblGlavnoJelo
            // 
            this.lblGlavnoJelo.AutoSize = true;
            this.lblGlavnoJelo.Location = new System.Drawing.Point(47, 146);
            this.lblGlavnoJelo.Name = "lblGlavnoJelo";
            this.lblGlavnoJelo.Size = new System.Drawing.Size(63, 13);
            this.lblGlavnoJelo.TabIndex = 2;
            this.lblGlavnoJelo.Text = "Glavno jelo:";
            // 
            // lblDesert
            // 
            this.lblDesert.AutoSize = true;
            this.lblDesert.Location = new System.Drawing.Point(47, 180);
            this.lblDesert.Name = "lblDesert";
            this.lblDesert.Size = new System.Drawing.Size(41, 13);
            this.lblDesert.TabIndex = 3;
            this.lblDesert.Text = "Desert:";
            // 
            // txtNazivJelovnika
            // 
            this.txtNazivJelovnika.Location = new System.Drawing.Point(161, 60);
            this.txtNazivJelovnika.Name = "txtNazivJelovnika";
            this.txtNazivJelovnika.Size = new System.Drawing.Size(100, 20);
            this.txtNazivJelovnika.TabIndex = 4;
            // 
            // cmbPredjelo
            // 
            this.cmbPredjelo.FormattingEnabled = true;
            this.cmbPredjelo.Location = new System.Drawing.Point(161, 106);
            this.cmbPredjelo.Name = "cmbPredjelo";
            this.cmbPredjelo.Size = new System.Drawing.Size(121, 21);
            this.cmbPredjelo.TabIndex = 5;
            // 
            // cmbGlavnoJelo
            // 
            this.cmbGlavnoJelo.FormattingEnabled = true;
            this.cmbGlavnoJelo.Location = new System.Drawing.Point(161, 143);
            this.cmbGlavnoJelo.Name = "cmbGlavnoJelo";
            this.cmbGlavnoJelo.Size = new System.Drawing.Size(121, 21);
            this.cmbGlavnoJelo.TabIndex = 6;
            // 
            // cmbDesert
            // 
            this.cmbDesert.FormattingEnabled = true;
            this.cmbDesert.Location = new System.Drawing.Point(161, 177);
            this.cmbDesert.Name = "cmbDesert";
            this.cmbDesert.Size = new System.Drawing.Size(121, 21);
            this.cmbDesert.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(50, 247);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(108, 38);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(227, 247);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(109, 38);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmNoviJelovnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 323);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbDesert);
            this.Controls.Add(this.cmbGlavnoJelo);
            this.Controls.Add(this.cmbPredjelo);
            this.Controls.Add(this.txtNazivJelovnika);
            this.Controls.Add(this.lblDesert);
            this.Controls.Add(this.lblGlavnoJelo);
            this.Controls.Add(this.lblPredjelo);
            this.Controls.Add(this.lblNazivJelovnika);
            this.Name = "FrmNoviJelovnik";
            this.Text = "Novi jelovnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazivJelovnika;
        private System.Windows.Forms.Label lblPredjelo;
        private System.Windows.Forms.Label lblGlavnoJelo;
        private System.Windows.Forms.Label lblDesert;
        private System.Windows.Forms.TextBox txtNazivJelovnika;
        private System.Windows.Forms.ComboBox cmbPredjelo;
        private System.Windows.Forms.ComboBox cmbGlavnoJelo;
        private System.Windows.Forms.ComboBox cmbDesert;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
    }
}