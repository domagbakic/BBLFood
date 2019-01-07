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
    public partial class FrmRezervacije : Form
    {
        public FrmRezervacije()
        {
            InitializeComponent();
        }

        private void FrmRezervacije_Load(object sender, EventArgs e)
        {
            PrikaziRezervacije();
        }
        private void PrikaziRezervacije()
        {
            BindingList<rezervacija> listaRezervacija = null;
            using (var db = new Entities17045_DB())
            {
                listaRezervacija = new BindingList<rezervacija>(db.rezervacijas.ToList());
            }
            rezervacijaBindingSource.DataSource = listaRezervacija;
        }

        private void btnDodajRezervaciju_Click(object sender, EventArgs e)
        {
            FrmNovaRezervacija frm = new FrmNovaRezervacija();
            frm.ShowDialog();
            PrikaziRezervacije();
        }
        
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            rezervacija selektiranaRezervacija = rezervacijaBindingSource.Current as rezervacija;
            NovaRezervacija novaRezervacija = new NovaRezervacija();
            if (selektiranaRezervacija != null)
            {
                if (MessageBox.Show("Jeste li sigurni da želite obrisati rezervaciju?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    novaRezervacija.Obrisi(selektiranaRezervacija);
                    PrikaziRezervacije();
                }
            }
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
