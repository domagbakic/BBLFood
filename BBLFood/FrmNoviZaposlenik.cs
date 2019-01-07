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
    public partial class FrmNoviZaposlenik : Form
    {
        public FrmNoviZaposlenik()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new Entities17045_DB())
            {
                radno_mjesto odabranoRadnoMjesto = cmbRadnoMjesto.SelectedItem as radno_mjesto;
                zaposlenik noviZaposlenik = new zaposlenik();
                db.radno_mjesto.Attach(odabranoRadnoMjesto);
                noviZaposlenik.ime = txtIme.Text;
                noviZaposlenik.prezime = txtPrezime.Text;
                noviZaposlenik.radno_mjesto = odabranoRadnoMjesto;
                db.zaposleniks.Add(noviZaposlenik);
                db.SaveChanges();
            }
            FrmZaposlenici frm = new FrmZaposlenici();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void FrmNoviZaposlenik_Load(object sender, EventArgs e)
        {
            PopuniComboBox();
        }
        private void PopuniComboBox()
        {
            BindingList<radno_mjesto> listaRadnihMjesta = null;
            using (var db = new Entities17045_DB())
            {
                listaRadnihMjesta = new BindingList<radno_mjesto>(db.radno_mjesto.ToList());
            }
            cmbRadnoMjesto.DataSource = listaRadnihMjesta;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            FrmZaposlenici frm = new FrmZaposlenici();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
