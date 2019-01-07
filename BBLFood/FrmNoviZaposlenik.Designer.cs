namespace BBLFood
{
    partial class FrmNoviZaposlenik
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
            this.cmbRadnoMjesto = new System.Windows.Forms.ComboBox();
            this.lblRadnoMjesto = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.radnomjestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radnomjestoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(33, 175);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 13;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // cmbRadnoMjesto
            // 
            this.cmbRadnoMjesto.DataSource = this.radnomjestoBindingSource;
            this.cmbRadnoMjesto.DisplayMember = "naziv";
            this.cmbRadnoMjesto.FormattingEnabled = true;
            this.cmbRadnoMjesto.Location = new System.Drawing.Point(109, 117);
            this.cmbRadnoMjesto.Name = "cmbRadnoMjesto";
            this.cmbRadnoMjesto.Size = new System.Drawing.Size(142, 21);
            this.cmbRadnoMjesto.TabIndex = 12;
            this.cmbRadnoMjesto.ValueMember = "id";
            // 
            // lblRadnoMjesto
            // 
            this.lblRadnoMjesto.AutoSize = true;
            this.lblRadnoMjesto.Location = new System.Drawing.Point(27, 120);
            this.lblRadnoMjesto.Name = "lblRadnoMjesto";
            this.lblRadnoMjesto.Size = new System.Drawing.Size(76, 13);
            this.lblRadnoMjesto.TabIndex = 11;
            this.lblRadnoMjesto.Text = "Radno Mjesto:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(109, 79);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(142, 20);
            this.txtPrezime.TabIndex = 10;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(27, 79);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 9;
            this.lblPrezime.Text = "Prezime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(109, 36);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(142, 20);
            this.txtIme.TabIndex = 8;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(27, 39);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 7;
            this.lblIme.Text = "Ime:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(176, 175);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 14;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // radnomjestoBindingSource
            // 
            this.radnomjestoBindingSource.DataSource = typeof(BBLFood.radno_mjesto);
            // 
            // FrmNoviZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(283, 237);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.cmbRadnoMjesto);
            this.Controls.Add(this.lblRadnoMjesto);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblIme);
            this.Name = "FrmNoviZaposlenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi zaposlenik";
            this.Load += new System.EventHandler(this.FrmNoviZaposlenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radnomjestoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ComboBox cmbRadnoMjesto;
        private System.Windows.Forms.Label lblRadnoMjesto;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.BindingSource radnomjestoBindingSource;
    }
}