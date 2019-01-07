using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace BBLFood
{
    public partial class FrmRacun : Form
    {
        float ZaPlatiti = 0;
        public FrmRacun()
        {
            InitializeComponent();
        }
        private void btnNoviRacun_Click(object sender, EventArgs e)
        {
            Otkljucaj();
            NoviRacun noviRacun = new NoviRacun();
            noviRacun.KreirajNoviRacun(cmbZaposlenik.SelectedItem as zaposlenik);
            PrikaziRacune();
        }
        private void Zakljucaj()
        {
            lblJelo.Enabled = false;
            lblKolicinaJelo.Enabled = false;
            cmbJelo.Enabled = false;
            txtKolicinaJelo.Enabled = false;
            btnDodajJelo.Enabled = false;
            lblJelovnik.Enabled = false;
            cmbJelovnik.Enabled = false;
            lblKolicinaJelovnik.Enabled = false;
            txtKolicinaJelovnik.Enabled = false;
            btnDodajJelovnik.Enabled = false;
        }
        private void Otkljucaj()
        {
            lblJelo.Enabled = true;
            lblKolicinaJelo.Enabled = true;
            cmbJelo.Enabled = true;
            txtKolicinaJelo.Enabled = true;
            btnDodajJelo.Enabled = true;
            btnNoviRacun.Enabled = false;
            lblJelovnik.Enabled = true;
            cmbJelovnik.Enabled = true;
            lblKolicinaJelovnik.Enabled = true;
            txtKolicinaJelovnik.Enabled = true;
            btnDodajJelovnik.Enabled = true;
        }
        private void FrmRacun_Load(object sender, EventArgs e)
        {
            rTxtStavke.Clear();
            Zakljucaj();
            
            BindingList<zaposlenik> listaZaposlenika = null;
            using (var db = new Entities17045_DB())
            {
                listaZaposlenika = new BindingList<zaposlenik>(db.zaposleniks.ToList());
            }
            cmbZaposlenik.DataSource = listaZaposlenika;

            BindingList<jelo> listaJela = null;
            using (var db = new Entities17045_DB())
            {
                listaJela = new BindingList<jelo>(db.jeloes.ToList());
            }
            cmbJelo.DataSource = listaJela;

            BindingList<jelovnik> listaJelovnika = null;
            using (var db = new Entities17045_DB())
            {
                listaJelovnika = new BindingList<jelovnik>(db.jelovniks.ToList());
            }
            cmbJelovnik.DataSource = listaJelovnika;
        }
    
        private void PrikaziRacune()
        {
            BindingList<racun> listaRacuna = new BindingList<racun>();
            using (var db = new Entities17045_DB())
            {
                listaRacuna = new BindingList<racun>(db.racuns.ToList());
            }
            var A = listaRacuna.LastOrDefault();
            racunBindingSource.DataSource = A;
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtKolicinaJelo.Text != "")
            {
                try
                {
                    int temp = Convert.ToInt32(txtKolicinaJelo.Text);
                }
                catch
                {
                    MessageBox.Show("Količina sadrži samo brojeve!");
                    return;
                }
            }
            if (txtKolicinaJelo.Text != "")
            {
                racun odabraniRacun = racunBindingSource.Current as racun;
                jelo odabranoJelo = cmbJelo.SelectedItem as jelo;

                NoviRacun noviRacun = new NoviRacun();
                noviRacun.DodajJeloNaRacun(odabraniRacun, odabranoJelo as jelo, int.Parse(txtKolicinaJelo.Text));
                
                rTxtStavke.Text += odabranoJelo.naziv.ToString() + "   KOL: " + txtKolicinaJelo.Text + "   CIJENA:"
                    + ((int.Parse(txtKolicinaJelo.Text)) * odabranoJelo.cijena) + " kn" + Environment.NewLine;
                ZaPlatiti += ((int.Parse(txtKolicinaJelo.Text)) * (float)odabranoJelo.cijena);
                txtZaPlatiti.Text = ZaPlatiti.ToString();
            }
        }
        private void btnDodajJelovnik_Click(object sender, EventArgs e)
        {
            if (txtKolicinaJelovnik.Text != "")
            {
                try
                {
                    int temp = Convert.ToInt32(txtKolicinaJelovnik.Text);
                }
                catch
                {
                    MessageBox.Show("Količina sadrži samo brojeve!");
                    return;
                }
            }
            if (txtKolicinaJelovnik.Text != "")
            {
                racun odabraniRacun = racunBindingSource.Current as racun;
                jelovnik odabraniJelovnik = cmbJelovnik.SelectedItem as jelovnik;

                NoviRacun noviRacun = new NoviRacun();
                noviRacun.DodajJelovnikNaRacun(odabraniRacun, odabraniJelovnik, int.Parse(txtKolicinaJelovnik.Text));

                rTxtStavke.Text += odabraniJelovnik.naziv.ToString() + "   KOL: " + txtKolicinaJelovnik.Text + "   CIJENA:"
                        + ((int.Parse(txtKolicinaJelovnik.Text)) * odabraniJelovnik.cijena) + " kn" + Environment.NewLine;
                ZaPlatiti += ((int.Parse(txtKolicinaJelovnik.Text)) * (float)odabraniJelovnik.cijena);
                txtZaPlatiti.Text = ZaPlatiti.ToString();
            }
        }
        private void btnIzdaj_Click(object sender, EventArgs e)
        {
            racun odabraniRacun = racunBindingSource.Current as racun;
            string imeZaposlenika = cmbZaposlenik.Text;

            NoviRacun noviRacun = new NoviRacun();
            noviRacun.IzdajRacun(odabraniRacun, float.Parse(txtZaPlatiti.Text), rTxtStavke.Text, imeZaposlenika);

            FrmGlavniIzbornik frm = new FrmGlavniIzbornik();
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
