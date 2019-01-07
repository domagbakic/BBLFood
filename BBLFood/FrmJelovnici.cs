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
    public partial class FrmJelovnici : Form
    {
        public FrmJelovnici()
        {
            InitializeComponent();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmGlavniIzbornik frm = new FrmGlavniIzbornik();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void FrmJelovnici_Load(object sender, EventArgs e)
        {
            PrikaziJelovnike();
            PopuniCombobox();
            Zakljucaj();
        }
        private void Zakljucaj()
        {
            lblCijena.Enabled = false;
            lblNaziv.Enabled = false;
            txtCijena.Enabled = false;
            txtNaziv.Enabled = false;
            btnSpremi.Enabled = false;
        }
        private void Otkljucaj()
        {
            lblCijena.Enabled = true;
            lblNaziv.Enabled = true;
            txtCijena.Enabled = true;
            txtNaziv.Enabled = true;
            btnSpremi.Enabled = true;
        }
        private void PrikaziJelovnike()
        {
            BindingList<jelovnik> listaJelovnika = new BindingList<jelovnik>();
            using (var db = new Entities17045_DB())
            {
                listaJelovnika = new BindingList<jelovnik>(db.jelovniks.ToList());
            }
            jelovnikBindingSource.DataSource = listaJelovnika;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Otkljucaj();
        }
        private void PopuniCombobox()
        {
            BindingList<jelo> listaPredjela = null;
            using (var db = new Entities17045_DB())
            {
                var A = db.jeloes.Where(x => x.vrsta == "Predjelo").ToList();
                listaPredjela = new BindingList<jelo>(A);
            }
            cmbPredjelo.DataSource = listaPredjela;

            BindingList<jelo> listaGlavnihJela = null;
            using (var db = new Entities17045_DB())
            {
                var A = db.jeloes.Where(x => x.vrsta == "Glavno Jelo").ToList();
                listaGlavnihJela = new BindingList<jelo>(A);
            }
            cmbGlavnoJelo.DataSource = listaGlavnihJela;

            BindingList<jelo> listaDeserata = null;
            using (var db = new Entities17045_DB())
            {
                var A = db.jeloes.Where(x => x.vrsta == "Desert").ToList();
                listaDeserata = new BindingList<jelo>(A);
            }
            cmbDesert.DataSource = listaDeserata;
        }

        private void btnDodajPredjelo_Click(object sender, EventArgs e)
        {
            jelovnik odabraniJelovnik = jelovnikBindingSource.Current as jelovnik;
            jelo odabranoPredjelo = cmbPredjelo.SelectedItem as jelo;
            using (var db = new Entities17045_DB())
            {
                var A = db.jelovnik_jelo.Where(x => x.id_jelovnik == odabraniJelovnik.id).ToList();
                foreach (var item in A)
                {
                    var B = item.jelo.vrsta;
                    if (item.jelo.naziv != "" && B == "Predjelo")
                    {
                        MessageBox.Show("Predjelo je već uneseno!");
                        return;
                    }
                }
                NoviJelovnik jelovnik = new NoviJelovnik();
                jelovnik.DodajPredjelo(odabranoPredjelo, odabraniJelovnik);
                MessageBox.Show("Uspješno ste dodali predjelo!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jelovnik odabraniJelovnik = jelovnikBindingSource.Current as jelovnik;
            jelo odabranoGlavnoJelo = cmbGlavnoJelo.SelectedItem as jelo;
            using (var db = new Entities17045_DB())
            {
                var A = db.jelovnik_jelo.Where(x => x.id_jelovnik == odabraniJelovnik.id).ToList();
                foreach (var item in A)
                {
                    var B = item.jelo.vrsta;
                    if (item.jelo.naziv != "" && B == "Glavno Jelo")
                    {
                        MessageBox.Show("Glavno jelo je već uneseno!");
                        return;
                    }
                }
                NoviJelovnik jelovnik = new NoviJelovnik();
                jelovnik.DodajGlavnoJelo(odabranoGlavnoJelo,odabraniJelovnik);
                MessageBox.Show("Uspješno ste dodali glavno jelo!");
            }
        }

        private void btnDodajDesert_Click(object sender, EventArgs e)
        {
            jelovnik odabraniJelovnik = jelovnikBindingSource.Current as jelovnik;
            jelo odabraniDesert = cmbDesert.SelectedItem as jelo;
            using (var db = new Entities17045_DB())
            {
                var A = db.jelovnik_jelo.Where(x => x.id_jelovnik == odabraniJelovnik.id).ToList();
                foreach (var item in A)
                {
                    var B = item.jelo.vrsta;
                    if (item.jelo.naziv != "" && B == "Desert")
                    {
                        MessageBox.Show("Desert je već unesen!");
                        return;
                    }
                }
                NoviJelovnik jelovnik = new NoviJelovnik();
                jelovnik.DodajDesert(odabraniDesert, odabraniJelovnik);
                MessageBox.Show("Uspješno ste dodali desert!");
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text == "" || txtCijena.Text == "")
            {
                MessageBox.Show("Niste unijeli sve podatke!");
                return;
            }
            if (txtCijena.Text != "")
            {
                try
                {
                    double temp = double.Parse(txtCijena.Text);
                }
                catch
                {
                    MessageBox.Show("Cijena treba sadržavati samo brojeve!");
                    return;
                }
            }
            if (txtCijena.Text != "" && txtCijena.Text.Contains(","))
            {
                MessageBox.Show("Cijena se unosi s točkom, a ne zarezom");
                return;
            }
            using (var db = new Entities17045_DB())
            {
                var A = db.jelovniks.ToList();
                foreach (var item in A)
                {
                    if (item.naziv == txtNaziv.Text)
                    {
                        MessageBox.Show("Jelovnik s tim nazivom je već unesen.");
                        txtNaziv.Clear();
                        txtCijena.Clear();
                        return;
                    }
                }
                NoviJelovnik jelovnik = new NoviJelovnik();
                jelovnik.Dodaj(txtNaziv.Text,txtCijena.Text);
                txtCijena.Clear();
                txtNaziv.Clear();
            }
            PrikaziJelovnike();
        }
    }
}
