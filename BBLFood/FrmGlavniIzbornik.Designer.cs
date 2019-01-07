namespace BBLFood
{
    partial class FrmGlavniIzbornik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGlavniIzbornik));
            this.btnZalihe = new System.Windows.Forms.Button();
            this.btnZaposlenici = new System.Windows.Forms.Button();
            this.btnJela = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.btnJelovnici = new System.Windows.Forms.Button();
            this.btnIzvjestaji = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZalihe
            // 
            this.btnZalihe.BackColor = System.Drawing.SystemColors.Info;
            this.btnZalihe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZalihe.Location = new System.Drawing.Point(462, 256);
            this.btnZalihe.Name = "btnZalihe";
            this.btnZalihe.Size = new System.Drawing.Size(110, 45);
            this.btnZalihe.TabIndex = 1;
            this.btnZalihe.Text = "Zalihe";
            this.btnZalihe.UseVisualStyleBackColor = false;
            this.btnZalihe.Click += new System.EventHandler(this.btnZalihe_Click);
            // 
            // btnZaposlenici
            // 
            this.btnZaposlenici.BackColor = System.Drawing.SystemColors.Info;
            this.btnZaposlenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaposlenici.Location = new System.Drawing.Point(59, 256);
            this.btnZaposlenici.Name = "btnZaposlenici";
            this.btnZaposlenici.Size = new System.Drawing.Size(110, 45);
            this.btnZaposlenici.TabIndex = 2;
            this.btnZaposlenici.Text = "Zaposlenici";
            this.btnZaposlenici.UseVisualStyleBackColor = false;
            this.btnZaposlenici.Click += new System.EventHandler(this.btnZaposlenici_Click);
            // 
            // btnJela
            // 
            this.btnJela.BackColor = System.Drawing.SystemColors.Info;
            this.btnJela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJela.Location = new System.Drawing.Point(187, 256);
            this.btnJela.Name = "btnJela";
            this.btnJela.Size = new System.Drawing.Size(110, 45);
            this.btnJela.TabIndex = 3;
            this.btnJela.Text = "Jela";
            this.btnJela.UseVisualStyleBackColor = false;
            this.btnJela.Click += new System.EventHandler(this.btnJela_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(322, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Izdavanje računa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.BackColor = System.Drawing.SystemColors.Info;
            this.btnRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRezervacije.Location = new System.Drawing.Point(125, 316);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(110, 45);
            this.btnRezervacije.TabIndex = 5;
            this.btnRezervacije.Text = "Rezervacije";
            this.btnRezervacije.UseVisualStyleBackColor = false;
            this.btnRezervacije.Click += new System.EventHandler(this.btnRezervacije_Click);
            // 
            // btnJelovnici
            // 
            this.btnJelovnici.BackColor = System.Drawing.SystemColors.Info;
            this.btnJelovnici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJelovnici.Location = new System.Drawing.Point(260, 316);
            this.btnJelovnici.Name = "btnJelovnici";
            this.btnJelovnici.Size = new System.Drawing.Size(110, 45);
            this.btnJelovnici.TabIndex = 6;
            this.btnJelovnici.Text = "Jelovnici";
            this.btnJelovnici.UseVisualStyleBackColor = false;
            this.btnJelovnici.Click += new System.EventHandler(this.btnJelovnici_Click);
            // 
            // btnIzvjestaji
            // 
            this.btnIzvjestaji.BackColor = System.Drawing.SystemColors.Info;
            this.btnIzvjestaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzvjestaji.Location = new System.Drawing.Point(396, 316);
            this.btnIzvjestaji.Name = "btnIzvjestaji";
            this.btnIzvjestaji.Size = new System.Drawing.Size(110, 45);
            this.btnIzvjestaji.TabIndex = 7;
            this.btnIzvjestaji.Text = "Izvještaji";
            this.btnIzvjestaji.UseVisualStyleBackColor = false;
            this.btnIzvjestaji.Click += new System.EventHandler(this.btnIzvještaji_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(12, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 53);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Location = new System.Drawing.Point(556, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 53);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmGlavniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(620, 407);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIzvjestaji);
            this.Controls.Add(this.btnJelovnici);
            this.Controls.Add(this.btnRezervacije);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnJela);
            this.Controls.Add(this.btnZaposlenici);
            this.Controls.Add(this.btnZalihe);
            this.Name = "FrmGlavniIzbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavni Izbornik";
            this.Load += new System.EventHandler(this.FrmGlavniIzbornik_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZalihe;
        private System.Windows.Forms.Button btnZaposlenici;
        private System.Windows.Forms.Button btnJela;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRezervacije;
        private System.Windows.Forms.Button btnJelovnici;
        private System.Windows.Forms.Button btnIzvjestaji;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

