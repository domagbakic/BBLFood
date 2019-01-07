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
    public partial class FrmNovaRezervacija : Form
    {
        public FrmNovaRezervacija()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void PrikaziRezervacije()
        {
            BindingList<rezervacija> listaRezervacija = null;
            using (var db = new Entities17045_DB())
            {
                listaRezervacija = new BindingList<rezervacija>(db.rezervacijas.ToList());
            }
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {

            if (txtImeKlijenta.Text == "" || txtPrezimeKlijenta.Text == "" || txtKontaktBroj.Text == "" || cmbStol.Text == "")
            {
                MessageBox.Show("Niste unijeli sve podatke!");
            }

            if (txtKontaktBroj.Text != "")
            {
                try
                {
                    int temp = Convert.ToInt32(txtKontaktBroj.Text);
                }
                catch
                {
                    MessageBox.Show("Kontakt broj sadrži samo brojeve!");
                    return;
                }
            }



            if (txtImeKlijenta.Text != "" && txtPrezimeKlijenta.Text != "" && txtKontaktBroj.Text != "" && cmbZaposlenik.Text != "")
            {
                using (var db = new Entities17045_DB())
                {
                    string stolovi = cmbStol.Text;
                    int table = int.Parse(stolovi);
                    string food = cmbObjed.Text;
                    DateTime datumR = DateTime.Parse(datumRezervacije.Text);
                    TimeSpan vrijemeR = TimeSpan.Parse(cmbVrijeme.Text);

                    var stol = db.rezervacijas.FirstOrDefault(u => u.broj_stola == table && u.objed == food && u.datum == datumR && u.termin == vrijemeR);
                    var kontakt = db.rezervacijas.FirstOrDefault(z => z.kontakt_broj_narucitelj == txtKontaktBroj.Text);

                    if (stol != null)
                    {
                        if (stol.broj_stola == int.Parse(cmbStol.Text) && stol.objed == cmbObjed.Text && stol.datum == DateTime.Parse(datumRezervacije.Text) && stol.termin == TimeSpan.Parse(cmbVrijeme.Text))
                        {
                            MessageBox.Show("Stol je zauzet!");
                            return;
                        }
                    }

                    if (kontakt != null)
                    {
                        if (kontakt.kontakt_broj_narucitelj == txtKontaktBroj.Text)
                        {
                            MessageBox.Show("Kontakt broj već postoji!");
                            return;
                        }
                    }

                    else
                    {
                        NovaRezervacija rezervacija = new NovaRezervacija();
                        rezervacija.Rezerviraj(txtImeKlijenta.Text, txtPrezimeKlijenta.Text, int.Parse(txtKontaktBroj.Text), int.Parse(cmbStol.Text), int.Parse(cmbBrojOsoba.Text), cmbObjed.Text, DateTime.Parse(datumRezervacije.Text), TimeSpan.Parse(cmbVrijeme.Text), cmbZaposlenik.SelectedItem as zaposlenik);
                    }
                }
                Close();
            }
        }

        private void FrmNovaRezervacija_Load(object sender, EventArgs e)
        {
            cmbBrojOsoba.Items.Add("1");
            cmbBrojOsoba.Items.Add("2");
            cmbBrojOsoba.Items.Add("3");
            cmbBrojOsoba.Items.Add("4");
            cmbBrojOsoba.Items.Add("5");
            cmbBrojOsoba.Items.Add("6");
            cmbBrojOsoba.Items.Add("7");
            cmbBrojOsoba.Items.Add("8");
            cmbBrojOsoba.Items.Add("9");
            cmbBrojOsoba.Items.Add("10");
            cmbBrojOsoba.Items.Add("11");
            cmbBrojOsoba.Items.Add("12");
            cmbBrojOsoba.Items.Add("13");
            cmbBrojOsoba.Items.Add("14");
            cmbBrojOsoba.Items.Add("15");


            cmbStol.Items.Add("1");
            cmbStol.Items.Add("2");
            cmbStol.Items.Add("3");
            cmbStol.Items.Add("4");
            cmbStol.Items.Add("5");
            cmbStol.Items.Add("6");
            cmbStol.Items.Add("7");
            cmbStol.Items.Add("8");
            cmbStol.Items.Add("9");
            cmbStol.Items.Add("10");
            cmbStol.Items.Add("11");
            cmbStol.Items.Add("12");
            cmbStol.Items.Add("13");
            cmbStol.Items.Add("14");
            cmbStol.Items.Add("15");
            cmbStol.Items.Add("16");
            cmbStol.Items.Add("17");
            cmbStol.Items.Add("18");
            cmbStol.Items.Add("19");
            cmbStol.Items.Add("20");

            cmbObjed.Items.Add("dorucak");
            cmbObjed.Items.Add("rucak");
            cmbObjed.Items.Add("vecera");

            BindingList<zaposlenik> listaZaposlenika = null;
            using (var db = new Entities17045_DB())
            {
                listaZaposlenika = new BindingList<zaposlenik>(db.zaposleniks.ToList());
            }
            cmbZaposlenik.DataSource = listaZaposlenika;
        }

        private void cmbObjed_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbVrijeme.Items.Count > 0)
            {
                cmbVrijeme.Items.Clear();
            }
            if (cmbObjed.SelectedItem.ToString() == "dorucak")
            {
                cmbVrijeme.Items.Add("7:00");
                cmbVrijeme.Items.Add("8:00");
                cmbVrijeme.Items.Add("9:00");
                cmbVrijeme.Items.Add("10:00");
            }
            
            else if (cmbObjed.SelectedItem.ToString() == "rucak")
            {
                cmbVrijeme.Items.Add("11:00");
                cmbVrijeme.Items.Add("12:00");
                cmbVrijeme.Items.Add("13:00");
                cmbVrijeme.Items.Add("14:00");
                cmbVrijeme.Items.Add("15:00");
                cmbVrijeme.Items.Add("16:00");
            }

            else if (cmbObjed.SelectedItem.ToString() == "vecera")
            {
                cmbVrijeme.Items.Add("17:00");
                cmbVrijeme.Items.Add("18:00");
                cmbVrijeme.Items.Add("19:00");
                cmbVrijeme.Items.Add("20:00");
                cmbVrijeme.Items.Add("21:00");
            }
        }
    }
}
