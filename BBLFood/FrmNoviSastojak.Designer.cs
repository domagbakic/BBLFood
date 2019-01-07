namespace BBLFood
{
    partial class FrmNoviSastojak
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
            this.btnSpremi = new System.Windows.Forms.Button();
            this.rbKomad = new System.Windows.Forms.RadioButton();
            this.rbLitra = new System.Windows.Forms.RadioButton();
            this.rbKilogram = new System.Windows.Forms.RadioButton();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblMjernaJedinica = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.cmbNaziv = new System.Windows.Forms.ComboBox();
            this.zaliheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zaliheBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(51, 252);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(103, 46);
            this.btnSpremi.TabIndex = 35;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // rbKomad
            // 
            this.rbKomad.AutoSize = true;
            this.rbKomad.Location = new System.Drawing.Point(132, 191);
            this.rbKomad.Name = "rbKomad";
            this.rbKomad.Size = new System.Drawing.Size(58, 17);
            this.rbKomad.TabIndex = 34;
            this.rbKomad.TabStop = true;
            this.rbKomad.Text = "Komad";
            this.rbKomad.UseVisualStyleBackColor = true;
            // 
            // rbLitra
            // 
            this.rbLitra.AutoSize = true;
            this.rbLitra.Location = new System.Drawing.Point(132, 158);
            this.rbLitra.Name = "rbLitra";
            this.rbLitra.Size = new System.Drawing.Size(45, 17);
            this.rbLitra.TabIndex = 33;
            this.rbLitra.TabStop = true;
            this.rbLitra.Text = "Litra";
            this.rbLitra.UseVisualStyleBackColor = true;
            // 
            // rbKilogram
            // 
            this.rbKilogram.AutoSize = true;
            this.rbKilogram.Location = new System.Drawing.Point(132, 123);
            this.rbKilogram.Name = "rbKilogram";
            this.rbKilogram.Size = new System.Drawing.Size(65, 17);
            this.rbKilogram.TabIndex = 32;
            this.rbKilogram.TabStop = true;
            this.rbKilogram.Text = "Kilogram";
            this.rbKilogram.UseVisualStyleBackColor = true;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(132, 81);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(85, 20);
            this.txtKolicina.TabIndex = 31;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(48, 84);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(44, 13);
            this.lblKolicina.TabIndex = 29;
            this.lblKolicina.Text = "Količina";
            // 
            // lblMjernaJedinica
            // 
            this.lblMjernaJedinica.AutoSize = true;
            this.lblMjernaJedinica.Location = new System.Drawing.Point(48, 123);
            this.lblMjernaJedinica.Name = "lblMjernaJedinica";
            this.lblMjernaJedinica.Size = new System.Drawing.Size(78, 13);
            this.lblMjernaJedinica.TabIndex = 28;
            this.lblMjernaJedinica.Text = "Mjerna jedinica";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(48, 42);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 27;
            this.lblNaziv.Text = "Naziv";
            // 
            // cmbNaziv
            // 
            this.cmbNaziv.DataSource = this.zaliheBindingSource;
            this.cmbNaziv.DisplayMember = "naziv";
            this.cmbNaziv.FormattingEnabled = true;
            this.cmbNaziv.Location = new System.Drawing.Point(132, 39);
            this.cmbNaziv.Name = "cmbNaziv";
            this.cmbNaziv.Size = new System.Drawing.Size(205, 21);
            this.cmbNaziv.TabIndex = 36;
            // 
            // zaliheBindingSource
            // 
            this.zaliheBindingSource.DataSource = typeof(BBLFood.zalihe);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(234, 252);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(103, 46);
            this.btnOdustani.TabIndex = 37;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmNoviSastojak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(403, 347);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.cmbNaziv);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.rbKomad);
            this.Controls.Add(this.rbLitra);
            this.Controls.Add(this.rbKilogram);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblMjernaJedinica);
            this.Controls.Add(this.lblNaziv);
            this.Name = "FrmNoviSastojak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi sastojak";
            this.Load += new System.EventHandler(this.FrmNoviSastojak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zaliheBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.RadioButton rbKomad;
        private System.Windows.Forms.RadioButton rbLitra;
        private System.Windows.Forms.RadioButton rbKilogram;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblMjernaJedinica;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.ComboBox cmbNaziv;
        private System.Windows.Forms.BindingSource zaliheBindingSource;
        private System.Windows.Forms.Button btnOdustani;
    }
}