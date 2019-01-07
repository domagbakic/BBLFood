using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_forme
{
    public partial class FrmJela : Form
    {
        public FrmJela()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmNovoJelo frm = new FrmNovoJelo();
            frm.ShowDialog();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
