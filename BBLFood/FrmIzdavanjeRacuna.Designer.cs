namespace Projekt_forme
{
    partial class FrmIzdavanjeRacuna
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
            this.cmbStavka = new System.Windows.Forms.ComboBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblStavka = new System.Windows.Forms.Label();
            this.btnUnos = new System.Windows.Forms.Button();
            this.lblIspis = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.dgvRacun = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStavka
            // 
            this.cmbStavka.FormattingEnabled = true;
            this.cmbStavka.Location = new System.Drawing.Point(103, 47);
            this.cmbStavka.Name = "cmbStavka";
            this.cmbStavka.Size = new System.Drawing.Size(226, 21);
            this.cmbStavka.TabIndex = 0;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(439, 48);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(56, 20);
            this.txtKolicina.TabIndex = 2;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(361, 51);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(47, 13);
            this.lblKolicina.TabIndex = 3;
            this.lblKolicina.Text = "Količina:";
            // 
            // lblStavka
            // 
            this.lblStavka.AutoSize = true;
            this.lblStavka.Location = new System.Drawing.Point(40, 51);
            this.lblStavka.Name = "lblStavka";
            this.lblStavka.Size = new System.Drawing.Size(44, 13);
            this.lblStavka.TabIndex = 4;
            this.lblStavka.Text = "Stavka:";
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(414, 98);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(99, 31);
            this.btnUnos.TabIndex = 5;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            // 
            // lblIspis
            // 
            this.lblIspis.Location = new System.Drawing.Point(78, 325);
            this.lblIspis.Name = "lblIspis";
            this.lblIspis.Size = new System.Drawing.Size(214, 82);
            this.lblIspis.TabIndex = 6;
            this.lblIspis.Text = "Ispis";
            this.lblIspis.UseVisualStyleBackColor = true;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(425, 384);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(88, 23);
            this.btnPovratak.TabIndex = 7;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(414, 267);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(99, 31);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // dgvRacun
            // 
            this.dgvRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacun.Location = new System.Drawing.Point(32, 98);
            this.dgvRacun.Name = "dgvRacun";
            this.dgvRacun.Size = new System.Drawing.Size(326, 200);
            this.dgvRacun.TabIndex = 9;
            // 
            // FrmIzdavanjeRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 419);
            this.Controls.Add(this.dgvRacun);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.lblIspis);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.lblStavka);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.cmbStavka);
            this.Name = "FrmIzdavanjeRacuna";
            this.Text = "Izdavanje računa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStavka;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblStavka;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button lblIspis;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridView dgvRacun;
    }
}