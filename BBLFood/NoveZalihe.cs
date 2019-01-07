using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBLFood
{
    class NoveZalihe
    {
        public void DodajZalihe(string naziv, decimal kolicina, decimal kriticnaKolicina, RadioButton rbKilogram, RadioButton rbLitra, RadioButton rbKomad)
        {
            using (var db = new Entities17045_DB())
            {
                zalihe noveZalihe = new zalihe();
                noveZalihe.naziv = naziv;
                noveZalihe.kolicina = kolicina;
                noveZalihe.kriticna_kolicina = kriticnaKolicina;
                noveZalihe.datum = DateTime.Now.ToShortDateString();
                if (rbKilogram.Checked)
                {
                    noveZalihe.mjernaJedinica = "Kilogram";
                }
                if (rbLitra.Checked)
                {
                    noveZalihe.mjernaJedinica = "Litra";
                }
                if (rbKomad.Checked)
                {
                    noveZalihe.mjernaJedinica = "Komad";
                }
                db.zalihes.Add(noveZalihe);
                db.SaveChanges();
                MessageBox.Show("Uspješno ste dodali zalihu " + noveZalihe.naziv + "!");
            }
        }
        public void UmanjiKolicinuZaliha(zalihe odabranaZaliha, decimal kolicina)
        {
            using (var db = new Entities17045_DB())
            {
                db.zalihes.Attach(odabranaZaliha);
                odabranaZaliha.kolicina = odabranaZaliha.kolicina - kolicina;
                if (odabranaZaliha.kolicina >= 0)
                {
                    db.SaveChanges();
                    MessageBox.Show("Uspješno ste umanjili zalihu " + odabranaZaliha.naziv + "!");
                }
                else
                {
                    MessageBox.Show("Količina zaliha mora biti nula ili više!");
                }
            }
        }
        public void UvecajKolicinuZaliha(zalihe odabranaZaliha, decimal kolicina)
        {
            using (var db = new Entities17045_DB())
            {
                db.zalihes.Attach(odabranaZaliha);
                odabranaZaliha.kolicina = odabranaZaliha.kolicina + kolicina;
                db.SaveChanges();
                MessageBox.Show("Uspješno ste nadopunili zalihu " + odabranaZaliha.naziv + "!");
            }
        }
        public void BrisiZalihe(zalihe odabraneZalihe)
        {
            using (var db = new Entities17045_DB())
            {
                if (odabraneZalihe != null)
                {
                    var A = db.sastojaks.Where(x => x.naziv == odabraneZalihe.naziv).FirstOrDefault();
                    if (A != null)
                    {
                        if (MessageBox.Show("Odabrana zaliha korištena je u nekom jelu! Ako ju obrišete, obrisat će se i sastojak u jelu. Želite li nastaviti?",
                            "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            db.zalihes.Attach(odabraneZalihe);
                            db.zalihes.Remove(odabraneZalihe);
                            db.sastojaks.Attach(A);
                            db.sastojaks.Remove(A);
                            db.SaveChanges();
                            MessageBox.Show("Uspješno ste obrisali zalihu " + odabraneZalihe.naziv + "!");
                        }
                    }
                    else
                    {
                        db.zalihes.Attach(odabraneZalihe);
                        db.zalihes.Remove(odabraneZalihe);
                        db.SaveChanges();
                        MessageBox.Show("Uspješno ste obrisali zalihu " + odabraneZalihe.naziv + "!");
                    }
                }
                else
                {
                    MessageBox.Show("Greška! Niti jedna zaliha nije odabrana!");
                }
            }
        }
    }
}
