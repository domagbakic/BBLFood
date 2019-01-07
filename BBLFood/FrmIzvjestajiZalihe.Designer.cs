namespace BBLFood
{
    partial class FrmIzvjestajiZalihe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIzvjestajiZalihe));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.zaliheBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.izvjestajiDataSet1 = new BBLFood.IzvjestajiDataSet();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.rptZaliheViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.zaliheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IzvjestajiDataSet = new BBLFood.IzvjestajiDataSet();
            this.lblDatum = new System.Windows.Forms.Label();
            this.btnKreirajPDF = new System.Windows.Forms.Button();
            this.zaliheTableAdapter = new BBLFood.IzvjestajiDataSetTableAdapters.zaliheTableAdapter();
            this.zaliheTableAdapter1 = new BBLFood.IzvjestajiDataSetTableAdapters.zaliheTableAdapter();
            this.btnIspis = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.zaliheBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izvjestajiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaliheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IzvjestajiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // zaliheBindingSource1
            // 
            this.zaliheBindingSource1.DataMember = "zalihe";
            this.zaliheBindingSource1.DataSource = this.izvjestajiDataSet1;
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
            this.btnPovratak.Location = new System.Drawing.Point(23, 21);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(43, 41);
            this.btnPovratak.TabIndex = 32;
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // rptZaliheViewer
            // 
            reportDataSource1.Name = "dsZalihe";
            reportDataSource1.Value = this.zaliheBindingSource1;
            this.rptZaliheViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.rptZaliheViewer.LocalReport.ReportEmbeddedResource = "BBLFood.rptZalihe.rdlc";
            this.rptZaliheViewer.Location = new System.Drawing.Point(23, 79);
            this.rptZaliheViewer.Name = "rptZaliheViewer";
            this.rptZaliheViewer.ShowContextMenu = false;
            this.rptZaliheViewer.ShowCredentialPrompts = false;
            this.rptZaliheViewer.ShowDocumentMapButton = false;
            this.rptZaliheViewer.ShowExportButton = false;
            this.rptZaliheViewer.ShowFindControls = false;
            this.rptZaliheViewer.ShowParameterPrompts = false;
            this.rptZaliheViewer.ShowPrintButton = false;
            this.rptZaliheViewer.ShowProgress = false;
            this.rptZaliheViewer.ShowPromptAreaButton = false;
            this.rptZaliheViewer.ShowRefreshButton = false;
            this.rptZaliheViewer.ShowStopButton = false;
            this.rptZaliheViewer.Size = new System.Drawing.Size(633, 331);
            this.rptZaliheViewer.TabIndex = 33;
            // 
            // zaliheBindingSource
            // 
            this.zaliheBindingSource.DataMember = "zalihe";
            this.zaliheBindingSource.DataSource = this.IzvjestajiDataSet;
            // 
            // IzvjestajiDataSet
            // 
            this.IzvjestajiDataSet.DataSetName = "IzvjestajiDataSet";
            this.IzvjestajiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(118, 35);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(41, 13);
            this.lblDatum.TabIndex = 35;
            this.lblDatum.Text = "Datum:";
            // 
            // btnKreirajPDF
            // 
            this.btnKreirajPDF.Location = new System.Drawing.Point(508, 416);
            this.btnKreirajPDF.Name = "btnKreirajPDF";
            this.btnKreirajPDF.Size = new System.Drawing.Size(148, 32);
            this.btnKreirajPDF.TabIndex = 36;
            this.btnKreirajPDF.Text = "Kreiraj PDF";
            this.btnKreirajPDF.UseVisualStyleBackColor = true;
            this.btnKreirajPDF.Click += new System.EventHandler(this.btnKreirajPDF_Click);
            // 
            // zaliheTableAdapter
            // 
            this.zaliheTableAdapter.ClearBeforeFill = true;
            // 
            // zaliheTableAdapter1
            // 
            this.zaliheTableAdapter1.ClearBeforeFill = true;
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(23, 416);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(148, 32);
            this.btnIspis.TabIndex = 37;
            this.btnIspis.Text = "Ispis na pisač";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 38;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FrmIzvjestajiZalihe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(676, 457);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnKreirajPDF);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.rptZaliheViewer);
            this.Controls.Add(this.btnPovratak);
            this.Name = "FrmIzvjestajiZalihe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stanje zaliha";
            this.Load += new System.EventHandler(this.FrmIzvjestajiZalihe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zaliheBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izvjestajiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaliheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IzvjestajiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private Microsoft.Reporting.WinForms.ReportViewer rptZaliheViewer;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button btnKreirajPDF;
        private IzvjestajiDataSet IzvjestajiDataSet;
        private IzvjestajiDataSetTableAdapters.zaliheTableAdapter zaliheTableAdapter;
        private System.Windows.Forms.BindingSource zaliheBindingSource;
        private System.Windows.Forms.BindingSource zaliheBindingSource1;
        private IzvjestajiDataSet izvjestajiDataSet1;
        private IzvjestajiDataSetTableAdapters.zaliheTableAdapter zaliheTableAdapter1;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}