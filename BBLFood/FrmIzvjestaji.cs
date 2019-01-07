using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBLFood
{
    public partial class FrmIzvjestaji : Form
    {
        public FrmIzvjestaji()
        {
            InitializeComponent();
        }

        private void btnStanjeZaliha_Click(object sender, EventArgs e)
        {
            FrmIzvjestajiZalihe frm = new FrmIzvjestajiZalihe();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnIzdaniRacuni_Click(object sender, EventArgs e)
        {
            FrmIzvjestajiRacuni frm = new FrmIzvjestajiRacuni();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmGlavniIzbornik frm = new FrmGlavniIzbornik();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
