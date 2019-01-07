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
    public partial class FrmIzvjestajiZalihe : Form
    {
        public FrmIzvjestajiZalihe()
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

        private void FrmIzvjestajiZalihe_Load(object sender, EventArgs e)
        {
            this.zaliheTableAdapter.Fill(this.IzvjestajiDataSet.zalihe);
            this.rptZaliheViewer.RefreshReport();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value != null)
            {
                string dt = dateTimePicker1.Value.ToShortDateString();
                this.zaliheTableAdapter1.FillByDatum(this.izvjestajiDataSet1.zalihe, dt);
            }
            this.rptZaliheViewer.RefreshReport();
        }

        private void btnKreirajPDF_Click(object sender, EventArgs e)
        {
            PDF.KreirajPDF(rptZaliheViewer);
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            rptZaliheViewer.PrintDialog();
        }

       
    }
}
