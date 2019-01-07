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
    public partial class FrmIzdavanjeRacuna : Form
    {
        public FrmIzdavanjeRacuna()
        {
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
