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

namespace BBLFood
{
    public partial class FrmGlavniIzbornik : Form
    {
        public FrmGlavniIzbornik()
        {
            InitializeComponent();
        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
            FrmZaposlenici frm = new FrmZaposlenici();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnJela_Click(object sender, EventArgs e)
        {
            FrmJelo frm = new FrmJelo();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnZalihe_Click(object sender, EventArgs e)
        {
            FrmZalihe frm = new FrmZalihe();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRacun frm = new FrmRacun();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            FrmRezervacije frm = new FrmRezervacije();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnJelovnici_Click(object sender, EventArgs e)
        {
            FrmJelovnici frm = new FrmJelovnici();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnIzvještaji_Click(object sender, EventArgs e)
        {
            FrmIzvjestaji frm = new FrmIzvjestaji();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void FrmGlavniIzbornik_Load(object sender, EventArgs e)
        {
            btnZalihe.TabStop = false;
        }
        private void showHelp()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            path = "file://" + Path.Combine(path, "..\\..\\Help-BBLFood.chm");
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

        private void button2_Click(object sender, EventArgs e)
        {
            showHelp();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
