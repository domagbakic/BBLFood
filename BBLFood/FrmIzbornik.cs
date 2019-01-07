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

namespace Projekt_forme
{
    public partial class FrmIzbornik : Form
    {
        public FrmIzbornik()
        {
            InitializeComponent();
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            FrmRezervacije frm = new FrmRezervacije();           
            frm.ShowDialog();            
        }

        private void btnJelovnici_Click(object sender, EventArgs e)
        {
            FrmJelovnici frm = new FrmJelovnici();
            frm.ShowDialog();
        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
            FrmZaposlenici frm = new FrmZaposlenici();
            frm.ShowDialog();
        }

        private void btnIzdavanjeRacuna_Click(object sender, EventArgs e)
        {
            FrmIzdavanjeRacuna frm = new FrmIzdavanjeRacuna();
            frm.ShowDialog();
        }

        private void btnZalihe_Click(object sender, EventArgs e)
        {
            FrmZalihe frm = new FrmZalihe();
            frm.ShowDialog();
        }

        private void btnIzvjestaji_Click(object sender, EventArgs e)
        {
            FrmIzvjestaji frm = new FrmIzvjestaji();
            frm.ShowDialog();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            showHelp();
        }
        private void showHelp()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            path = "file://" + Path.Combine(path, "..\\..\\Help.chm");
            Help.ShowHelp(this, path);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                showHelp();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
