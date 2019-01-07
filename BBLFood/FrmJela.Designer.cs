namespace Projekt_forme
{
    partial class FrmJela
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
            this.dgvJela = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJela)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJela
            // 
            this.dgvJela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJela.Location = new System.Drawing.Point(65, 51);
            this.dgvJela.Name = "dgvJela";
            this.dgvJela.Size = new System.Drawing.Size(414, 161);
            this.dgvJela.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(65, 255);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(128, 48);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj jelo";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(351, 255);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(128, 48);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši jelo";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(405, 349);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(74, 39);
            this.btnPovratak.TabIndex = 3;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // FrmJela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 400);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvJela);
            this.Name = "FrmJela";
            this.Text = "Jela";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJela;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPovratak;
    }
}