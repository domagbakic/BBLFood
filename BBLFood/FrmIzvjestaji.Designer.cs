namespace BBLFood
{
    partial class FrmIzvjestaji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIzvjestaji));
            this.btnStanjeZaliha = new System.Windows.Forms.Button();
            this.btnIzdaniRacuni = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStanjeZaliha
            // 
            this.btnStanjeZaliha.Location = new System.Drawing.Point(67, 102);
            this.btnStanjeZaliha.Name = "btnStanjeZaliha";
            this.btnStanjeZaliha.Size = new System.Drawing.Size(285, 65);
            this.btnStanjeZaliha.TabIndex = 0;
            this.btnStanjeZaliha.Text = "Stanje zaliha";
            this.btnStanjeZaliha.UseVisualStyleBackColor = true;
            this.btnStanjeZaliha.Click += new System.EventHandler(this.btnStanjeZaliha_Click);
            // 
            // btnIzdaniRacuni
            // 
            this.btnIzdaniRacuni.Location = new System.Drawing.Point(67, 196);
            this.btnIzdaniRacuni.Name = "btnIzdaniRacuni";
            this.btnIzdaniRacuni.Size = new System.Drawing.Size(285, 65);
            this.btnIzdaniRacuni.TabIndex = 1;
            this.btnIzdaniRacuni.Text = "Izdani računi";
            this.btnIzdaniRacuni.UseVisualStyleBackColor = true;
            this.btnIzdaniRacuni.Click += new System.EventHandler(this.btnIzdaniRacuni_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.Transparent;
            this.btnPovratak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPovratak.BackgroundImage")));
            this.btnPovratak.Location = new System.Drawing.Point(12, 12);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(43, 41);
            this.btnPovratak.TabIndex = 32;
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // FrmIzvjestaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(413, 331);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnIzdaniRacuni);
            this.Controls.Add(this.btnStanjeZaliha);
            this.Name = "FrmIzvjestaji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izvještaji";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStanjeZaliha;
        private System.Windows.Forms.Button btnIzdaniRacuni;
        private System.Windows.Forms.Button btnPovratak;
    }
}