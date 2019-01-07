namespace BBLFood
{
    partial class FrmRadnoMjesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRadnoMjesto));
            this.dgvRadnaMjesta = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposleniksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnomjestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnPovratak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnaMjesta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnomjestoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRadnaMjesta
            // 
            this.dgvRadnaMjesta.AllowUserToAddRows = false;
            this.dgvRadnaMjesta.AllowUserToDeleteRows = false;
            this.dgvRadnaMjesta.AutoGenerateColumns = false;
            this.dgvRadnaMjesta.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvRadnaMjesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRadnaMjesta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.zaposleniksDataGridViewTextBoxColumn});
            this.dgvRadnaMjesta.DataSource = this.radnomjestoBindingSource;
            this.dgvRadnaMjesta.Location = new System.Drawing.Point(31, 85);
            this.dgvRadnaMjesta.Name = "dgvRadnaMjesta";
            this.dgvRadnaMjesta.ReadOnly = true;
            this.dgvRadnaMjesta.RowHeadersVisible = false;
            this.dgvRadnaMjesta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRadnaMjesta.Size = new System.Drawing.Size(108, 116);
            this.dgvRadnaMjesta.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zaposleniksDataGridViewTextBoxColumn
            // 
            this.zaposleniksDataGridViewTextBoxColumn.DataPropertyName = "zaposleniks";
            this.zaposleniksDataGridViewTextBoxColumn.HeaderText = "zaposleniks";
            this.zaposleniksDataGridViewTextBoxColumn.Name = "zaposleniksDataGridViewTextBoxColumn";
            this.zaposleniksDataGridViewTextBoxColumn.ReadOnly = true;
            this.zaposleniksDataGridViewTextBoxColumn.Visible = false;
            // 
            // radnomjestoBindingSource
            // 
            this.radnomjestoBindingSource.DataSource = typeof(BBLFood.radno_mjesto);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(208, 85);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(122, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj radno mjesto";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(205, 131);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(106, 13);
            this.lblNaziv.TabIndex = 4;
            this.lblNaziv.Text = "Naziv radnog mjesta:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(330, 128);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(168, 20);
            this.txtNaziv.TabIndex = 3;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(208, 178);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(122, 23);
            this.btnSpremi.TabIndex = 5;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.Transparent;
            this.btnPovratak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPovratak.BackgroundImage")));
            this.btnPovratak.Location = new System.Drawing.Point(31, 12);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(43, 41);
            this.btnPovratak.TabIndex = 7;
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // FrmRadnoMjesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(526, 261);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvRadnaMjesta);
            this.Name = "FrmRadnoMjesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upravljanje radnim mjestima";
            this.Load += new System.EventHandler(this.FrmRadnoMjesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnaMjesta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnomjestoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRadnaMjesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposleniksDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource radnomjestoBindingSource;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnPovratak;
    }
}