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
    public partial class FrmNoviSastojak : Form
    {
        private jelo odabranoJelo;
        public FrmNoviSastojak(jelo jelo)
        {
            InitializeComponent();
            odabranoJelo = jelo;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (txtKolicina.Text != "")
            {
                try
                {
                    decimal temp = Convert.ToDecimal(txtKolicina.Text);
                }
                catch
                {
                    MessageBox.Show("Količina sadrži samo brojeve!");
                    return;
                }
            }
            if (txtKolicina.Text != "" && txtKolicina.Text.Contains(","))
            {
                MessageBox.Show("Količina se unosi s točkom, a ne zarezom");
                return;
            }

            if (cmbNaziv.SelectedItem != null && txtKolicina.Text != "" && (rbKilogram.Checked || rbKomad.Checked || rbLitra.Checked))
            {
                using (var db = new Entities17045_DB())
                {
                    var A = odabranoJelo.sastojaks.ToList();
                    foreach (var item in A)
                    {
                        if (item.naziv == cmbNaziv.Text)
                        {
                            MessageBox.Show("Odabrani sastojak je već dodan!");
                            return;
                        }
                    }
                    db.jeloes.Attach(odabranoJelo);
                    sastojak noviSastojak = new sastojak();
                    noviSastojak.naziv = cmbNaziv.Text;
                    noviSastojak.kolicina = decimal.Parse(txtKolicina.Text);
                    noviSastojak.jelo = odabranoJelo;
                    if (rbKilogram.Checked)
                    {
                        noviSastojak.mjerna_jedinica = "Kilogram";
                    }
                    if (rbLitra.Checked)
                    {
                        noviSastojak.mjerna_jedinica = "Litra";
                    }
                    if (rbKomad.Checked)
                    {
                        noviSastojak.mjerna_jedinica = "Komad";
                    }
                    db.sastojaks.Add(noviSastojak);
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Potrebno je unijeti sve podatke!");
            }
            FrmJelo frm = new FrmJelo();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void FrmNoviSastojak_Load(object sender, EventArgs e)
        {
            PopuniComboBox();
        }
        private void PopuniComboBox()
        {
            BindingList<zalihe> listaZaliha = null;
            using (var db = new Entities17045_DB())
            {
                listaZaliha = new BindingList<zalihe>(db.zalihes.ToList());
            }
            cmbNaziv.DataSource = listaZaliha;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            FrmJelo frm = new FrmJelo();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
