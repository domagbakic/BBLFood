namespace BBLFood
{
    partial class FrmIzvjestajiRacuni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIzvjestajiRacuni));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.racunBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.izvjestajiDataSet1 = new BBLFood.IzvjestajiDataSet();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.rptRacuniViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnIspis = new System.Windows.Forms.Button();
            this.btnKreirajPDF = new System.Windows.Forms.Button();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IzvjestajiDataSet = new BBLFood.IzvjestajiDataSet();
            this.racunTableAdapter = new BBLFood.IzvjestajiDataSetTableAdapters.racunTableAdapter();
            this.racunTableAdapter1 = new BBLFood.IzvjestajiDataSetTableAdapters.racunTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izvjestajiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IzvjestajiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // racunBindingSource1
            // 
            this.racunBindingSource1.DataMember = "racun";
            this.racunBindingSource1.DataSource = this.izvjestajiDataSet1;
            // 
            // izvjestajiDataSet1
            // 
            this.izvjestajiDataSet1.DataSetName = "IzvjestajiDataSet";
            this.izvjestajiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.Transparent;
            this.btnPovratak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPovratak.BackgroundImage")));
            this.btnPovratak.Location = new System.Drawing.Point(24, 24);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(43, 41);
            this.btnPovratak.TabIndex = 32;
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // rptRacuniViewer
            // 
            reportDataSource1.Name = "dsRacuni";
            reportDataSource1.Value = this.racunBindingSource1;
            this.rptRacuniViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.rptRacuniViewer.LocalReport.ReportEmbeddedResource = "BBLFood.rptRacuni.rdlc";
            this.rptRacuniViewer.Location = new System.Drawing.Point(24, 72);
            this.rptRacuniViewer.Name = "rptRacuniViewer";
            this.rptRacuniViewer.ShowContextMenu = false;
            this.rptRacuniViewer.ShowCredentialPrompts = false;
            this.rptRacuniViewer.ShowDocumentMapButton = false;
            this.rptRacuniViewer.ShowExportButton = false;
            this.rptRacuniViewer.ShowFindControls = false;
            this.rptRacuniViewer.ShowParameterPrompts = false;
            this.rptRacuniViewer.ShowPrintButton = false;
            this.rptRacuniViewer.ShowProgress = false;
            this.rptRacuniViewer.ShowPromptAreaButton = false;
            this.rptRacuniViewer.ShowRefreshButton = false;
            this.rptRacuniViewer.ShowStopButton = false;
            this.rptRacuniViewer.Size = new System.Drawing.Size(559, 335);
            this.rptRacuniViewer.TabIndex = 33;
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(24, 413);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(157, 40);
            this.btnIspis.TabIndex = 34;
            this.btnIspis.Text = "Ispis na pisač";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // btnKreirajPDF
            // 
            this.btnKreirajPDF.Location = new System.Drawing.Point(426, 413);
            this.btnKreirajPDF.Name = "btnKreirajPDF";
            this.btnKreirajPDF.Size = new System.Drawing.Size(157, 40);
            this.btnKreirajPDF.TabIndex = 35;
            this.btnKreirajPDF.Text = "Kreiraj PDF";
            this.btnKreirajPDF.UseVisualStyleBackColor = true;
            this.btnKreirajPDF.Click += new System.EventHandler(this.btnKreirajPDF_Click);
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "racun";
            this.racunBindingSource.DataSource = this.IzvjestajiDataSet;
            // 
            // IzvjestajiDataSet
            // 
            this.IzvjestajiDataSet.DataSetName = "IzvjestajiDataSet";
            this.IzvjestajiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // racunTableAdapter1
            // 
            this.racunTableAdapter1.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 38;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(96, 38);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(41, 13);
            this.lblDatum.TabIndex = 39;
            this.lblDatum.Text = "Datum:";
            // 
            // FrmIzvjestajiRacuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(595, 458);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnKreirajPDF);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.rptRacuniViewer);
            this.Controls.Add(this.btnPovratak);
            this.Name = "FrmIzvjestajiRacuni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izdani racuni";
            this.Load += new System.EventHandler(this.FrmIzvjestajiRacuni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izvjestajiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IzvjestajiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private Microsoft.Reporting.WinForms.ReportViewer rptRacuniViewer;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Button btnKreirajPDF;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private IzvjestajiDataSet IzvjestajiDataSet;
        private IzvjestajiDataSetTableAdapters.racunTableAdapter racunTableAdapter;
        private System.Windows.Forms.BindingSource racunBindingSource1;
        private IzvjestajiDataSet izvjestajiDataSet1;
        private IzvjestajiDataSetTableAdapters.racunTableAdapter racunTableAdapter1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDatum;
    }
}