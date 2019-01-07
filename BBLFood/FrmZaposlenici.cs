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
    public partial class FrmZaposlenici : Form
    {
        private zaposlenik odabraniZaposlenik;
        public FrmZaposlenici()
        {
            InitializeComponent();
        }

        private void FrmZaposlenici_Load(object sender, EventArgs e)
        {
            PrikaziZaposlenike();
        }
        private void PrikaziZaposlenike()
        {
            BindingList<zaposlenik> listaZaposlenika = new BindingList<zaposlenik>();
            using (var db = new Entities17045_DB())
            {
                listaZaposlenika = new BindingList<zaposlenik>(db.zaposleniks.ToList());
            }
            zaposlenikBindingSource.DataSource = listaZaposlenika;
        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            FrmNoviZaposlenik frm = new FrmNoviZaposlenik();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
        private void dgvZaposlenici_SelectionChanged(object sender, EventArgs e)
        {
            odabraniZaposlenik = zaposlenikBindingSource.Current as zaposlenik;
        }

        private void btnRadnaMjesta_Click(object sender, EventArgs e)
        {
            FrmRadnoMjesto frm = new FrmRadnoMjesto();
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
