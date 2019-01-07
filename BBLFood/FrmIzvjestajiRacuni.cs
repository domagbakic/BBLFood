using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotekaPDF;

namespace BBLFood
{
    public partial class FrmIzvjestajiRacuni : Form
    {
        public FrmIzvjestajiRacuni()
        {
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmIzvjestaji frm = new FrmIzvjestaji();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void FrmIzvjestajiRacuni_Load(object sender, EventArgs e)
        {
            this.racunTableAdapter.Fill(this.IzvjestajiDataSet.racun);
            this.rptRacuniViewer.RefreshReport();
        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value != null)
            {
                string dt = dateTimePicker1.Value.ToShortDateString();
                this.racunTableAdapter1.FillByDatum(this.izvjestajiDataSet1.racun, dt);
            }
            this.rptRacuniViewer.RefreshReport();
        }

        private void btnKreirajPDF_Click(object sender, EventArgs e)
        {
            PDF.KreirajPDF(rptRacuniViewer);
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            rptRacuniViewer.PrintDialog();
        }
    }
}
