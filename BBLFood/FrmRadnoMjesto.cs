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
    public partial class FrmRadnoMjesto : Form
    {
        public FrmRadnoMjesto()
        {
            InitializeComponent();
        }

        private void FrmRadnoMjesto_Load(object sender, EventArgs e)
        {
            Zakljucaj();
            PrikaziRadnaMjesta();
        }
        private void PrikaziRadnaMjesta()
        {
            BindingList<radno_mjesto> listaRadnihMjesta = new BindingList<radno_mjesto>();
            using (var db = new Entities17045_DB())
            {
                listaRadnihMjesta = new BindingList<radno_mjesto>(db.radno_mjesto.ToList());
            }
            radnomjestoBindingSource.DataSource = listaRadnihMjesta;
        }
        private void Zakljucaj()
        {
            lblNaziv.Enabled = false;
            txtNaziv.Enabled = false;
            btnSpremi.Enabled = false;
        }
        private void Otkljucaj()
        {
            lblNaziv.Enabled = true;
            txtNaziv.Enabled = true;
            btnSpremi.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otkljucaj();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if(txtNaziv.Text == "")
            {
                MessageBox.Show("Niste unijeli sve podatke!");
                return;
            }
            using (var db = new Entities17045_DB())
            {
                var A = db.radno_mjesto.ToList();
                foreach (var item in A)
                {
                    if(item.naziv == txtNaziv.Text)
                    {
                        MessageBox.Show("Radno mjesto s tim nazivom je već uneseno!");
                        txtNaziv.Clear();
                        return;
                    }
                }
                NovoRadnoMjesto radno_mjesto = new NovoRadnoMjesto();
                radno_mjesto.Dodaj(txtNaziv.Text);
            }
            PrikaziRadnaMjesta();
        }
        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmZaposlenici frm = new FrmZaposlenici();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
