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
    public partial class FrmJelo : Form
    {
        public FrmJelo()
        {
            InitializeComponent();
        }

        private void FrmJelo_Load(object sender, EventArgs e)
        {
            Zakljucaj();
            PrikaziJela();
            PrikaziSastojke(jeloBindingSource.Current as jelo);
        }
        private void PrikaziJela()
        {
            BindingList<jelo> listaJela = new BindingList<jelo>();
            using (var db = new Entities17045_DB())
            {
                listaJela = new BindingList<jelo>(db.jeloes.ToList());
            }
            jeloBindingSource.DataSource = listaJela;
        }

        private void btnDodajSastojak_Click(object sender, EventArgs e)
        {
            FrmNoviSastojak frm = new FrmNoviSastojak(jeloBindingSource.Current as jelo);
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void dgvJela_SelectionChanged(object sender, EventArgs e)
        {
            jelo odabranoJelo = jeloBindingSource.Current as jelo;
            if (odabranoJelo != null)
            {
                PrikaziSastojke(odabranoJelo);
            }
        }
        private void PrikaziSastojke(jelo jelo)
        {
            BindingList<sastojak> listaSastojaka = null;
            using (var db = new Entities17045_DB())
            {
                if (jelo != null)
                {
                    db.jeloes.Attach(jelo);
                    listaSastojaka = new BindingList<sastojak>(jelo.sastojaks.ToList<sastojak>());
                }
            }
            sastojakBindingSource.DataSource = listaSastojaka;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
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
            if (txtNaziv.Text != "" && txtCijena.Text != "" && (rbPredjelo.Checked || rbGlavnoJelo.Checked || rbDesert.Checked))
            {
                using (var db = new Entities17045_DB())
                {
                    string vrsta = null;
                    var A = db.jeloes.ToList();
                    foreach (var item in A)
                    {
                        if (item.naziv == txtNaziv.Text)
                        {
                            MessageBox.Show("Jelo s tim nazivom je već uneseno!");
                            txtNaziv.Clear();
                            txtCijena.Clear();
                            rbDesert.Checked = false;
                            rbGlavnoJelo.Checked = false;
                            rbPredjelo.Checked = false;
                            return;
                        }
                    }
                    if (rbPredjelo.Checked)
                    {
                        vrsta = "Predjelo";
                    }
                    if (rbGlavnoJelo.Checked)
                    {
                        vrsta = "Glavno Jelo";
                    }
                    if (rbDesert.Checked)
                    {
                        vrsta = "Desert";
                    }
                    NovoJelo jelo = new NovoJelo();
                    jelo.Dodaj(txtNaziv.Text, vrsta, txtCijena.Text);
                }
            }
            else
            {
                MessageBox.Show("Niste unijeli sve podatke!");
                return;
            }
            PrikaziJela();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmGlavniIzbornik frm = new FrmGlavniIzbornik();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnDodajJelo_Click(object sender, EventArgs e)
        {
            Otkljucaj();
        }
        private void Otkljucaj()
        {
            lblNaziv.Enabled = true;
            lblCijena.Enabled = true;
            lblVrsta.Enabled = true;
            txtNaziv.Enabled = true;
            txtCijena.Enabled = true;
            rbDesert.Enabled = true;
            rbGlavnoJelo.Enabled = true;
            rbPredjelo.Enabled = true;
            btnSpremi.Enabled = true;
        }
        private void Zakljucaj()
        {
            lblNaziv.Enabled = false;
            lblCijena.Enabled = false;
            lblVrsta.Enabled = false;
            txtNaziv.Enabled = false;
            txtCijena.Enabled = false;
            rbDesert.Enabled = false;
            rbGlavnoJelo.Enabled = false;
            rbPredjelo.Enabled = false;
            btnSpremi.Enabled = false;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            sastojak odabraniSastojak = sastojakBindingSource.Current as sastojak;
            NoviSastojak sastojak = new NoviSastojak();
            if (odabraniSastojak != null)
            {
                if (MessageBox.Show("Jeste li sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    sastojak.Obrisi(odabraniSastojak);
                }
                PrikaziSastojke(jeloBindingSource.Current as jelo);
            }
        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
