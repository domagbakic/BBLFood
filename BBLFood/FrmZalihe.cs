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
    public partial class FrmZalihe : Form
    {
        public FrmZalihe()
        {
            InitializeComponent();
        }

        private void FrmZalihe_Load(object sender, EventArgs e)
        {
            PrikaziZalihe();
            PromjeniBoju();
        }
        private void PrikaziZalihe()
        {
            BindingList<zalihe> listaZaliha = new BindingList<zalihe>();
            using (var db = new Entities17045_DB())
            {
                listaZaliha = new BindingList<zalihe>(db.zalihes.ToList());
            }
            zaliheBindingSource.DataSource = listaZaliha;
        }
        private void PromjeniBoju()
        {
            using (var db = new Entities17045_DB())
            {
                var sveZalihe = db.zalihes.ToList();
                foreach (var item in sveZalihe)
                {
                    if (item.kolicina < item.kriticna_kolicina)
                    {
                        for (int i = 0; i < dgvZalihe.Rows.Count; i++)
                        {
                            string naziv = dgvZalihe.Rows[i].Cells[1].Value.ToString();
                            if (naziv == item.naziv)
                            {
                                dgvZalihe.Rows[i].DefaultCellStyle.BackColor = Color.IndianRed;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < dgvZalihe.Rows.Count; i++)
                        {
                            string naziv = dgvZalihe.Rows[i].Cells[1].Value.ToString();
                            if (naziv == item.naziv)
                            {
                                dgvZalihe.Rows[i].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                            }
                        }
                    }
                }
            }
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
            if (txtNaziv.Text != "" && txtKolicina.Text != "" && (rbKilogram.Checked || rbKomad.Checked || rbLitra.Checked))
            {
                using (var db = new Entities17045_DB())
                {
                    var A = db.zalihes.ToList();
                    foreach (var item in A)
                    {
                        if (item.naziv == txtNaziv.Text)
                        {
                            MessageBox.Show("Zaliha je već unesena!");
                            txtKolicina.Clear();
                            txtNaziv.Clear();
                            rbKilogram.Checked = false;
                            rbKomad.Checked = false;
                            rbLitra.Checked = false;
                            return;
                        }
                    }
                    NoveZalihe noveZalihe = new NoveZalihe();
                    noveZalihe.DodajZalihe(txtNaziv.Text, decimal.Parse(txtKolicina.Text), decimal.Parse(txtKriticnaKolicina.Text), 
                        rbKilogram, rbLitra, rbKomad);
                }
                PrikaziZalihe();
                PromjeniBoju();
            }
            else
            {
                MessageBox.Show("Potrebno je unijeti sve podatke!");
            }
            txtKolicina.Clear();
            txtKriticnaKolicina.Clear();
            txtNaziv.Clear();
            rbKilogram.Checked = false;
            rbKomad.Checked = false;
            rbLitra.Checked = false;            
        }
        private void btnSpremiNadopuni_Click(object sender, EventArgs e)
        {
            if (txtKolicinaNadopuni.Text != "")
            {
                try
                {
                    decimal temp = Convert.ToDecimal(txtKolicinaNadopuni.Text);
                }
                catch
                {
                    MessageBox.Show("Količina sadrži samo brojeve!");
                    return;
                }
            }
            if (txtKolicinaNadopuni.Text != "" && txtKolicinaUmanjiti.Text.Contains(","))
            {
                MessageBox.Show("Količina se unosi s točkom, a ne zarezom");
                return;
            }
            if (txtKolicinaNadopuni.Text != "")
            {
                zalihe odabranaZaliha = zaliheBindingSource.Current as zalihe;
                if (odabranaZaliha != null)
                {
                    NoveZalihe noveZalihe = new NoveZalihe();
                    noveZalihe.UvecajKolicinuZaliha(odabranaZaliha, decimal.Parse(txtKolicinaNadopuni.Text));

                    PrikaziZalihe();
                    PromjeniBoju();
                }
                else
                {
                    MessageBox.Show("Morate odabrati jednu zalihu u datagridview-u!");
                }
            }
            else
            {
                MessageBox.Show("Potrebno je unijeti sve podatke!");
            }
            txtPretraga.Clear();
            txtKolicinaNadopuni.Clear();
        }
        private void btnSpremiUmanjiti_Click(object sender, EventArgs e)
        {
            if(txtKolicinaUmanjiti.Text != "")
            {
                try
                {
                    decimal temp = Convert.ToDecimal(txtKolicinaUmanjiti.Text);
                }
                catch
                {
                    MessageBox.Show("Količina sadrži samo brojeve!");
                    return;
                }
            }
            if (txtKolicinaUmanjiti.Text != "" && txtKolicinaUmanjiti.Text.Contains(","))
            {
                MessageBox.Show("Količina se unosi s točkom, a ne zarezom");
                return;
            }
            if (txtKolicinaUmanjiti.Text != "")
            {
                zalihe odabranaZaliha = zaliheBindingSource.Current as zalihe;
                if (odabranaZaliha != null)
                {
                    NoveZalihe noveZalihe = new NoveZalihe();
                    noveZalihe.UmanjiKolicinuZaliha(odabranaZaliha, decimal.Parse(txtKolicinaUmanjiti.Text));

                    PrikaziZalihe();
                    PromjeniBoju();
                }
                else
                {
                    MessageBox.Show("Morate odabrati jednu zalihu u datagridview-u!");
                }
            }
            else
            {
                MessageBox.Show("Potrebno je unijeti sve podatke!");
            }
            txtPretraga.Clear();
            txtKolicinaUmanjiti.Clear();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            BindingList<zalihe> listaPretrazenihZaliha = new BindingList<zalihe>();
            using (var db = new Entities17045_DB())
            {
                var A = db.zalihes.Where(x => x.naziv.Contains(txtPretraga.Text)).ToList();
                listaPretrazenihZaliha = new BindingList<zalihe>(A);
            }
            zaliheBindingSource.DataSource = listaPretrazenihZaliha;
        }

        private void btnObrisi_Click_1(object sender, EventArgs e)
        {
            zalihe odabraneZalihe = zaliheBindingSource.Current as zalihe;

            NoveZalihe noveZalihe = new NoveZalihe();
            noveZalihe.BrisiZalihe(odabraneZalihe);

            txtPretraga.Clear();
            PrikaziZalihe();
            PromjeniBoju();
        }
        private void btnPovratak_Click(object sender, EventArgs e)
        {
            FrmGlavniIzbornik frm = new FrmGlavniIzbornik();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
        private void gbUmanji_Enter(object sender, EventArgs e)
        {
        }
    }
}
