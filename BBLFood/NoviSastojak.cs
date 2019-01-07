using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBLFood
{
    class NoviSastojak
    {
        public void Dodaj(string naziv, string kolicina, string mjerna_jedinica, jelo odabranoJelo)
        {
            using (var db = new Entities17045_DB())
            {
                db.jeloes.Attach(odabranoJelo);
                sastojak noviSastojak = new sastojak();
                noviSastojak.naziv = naziv;
                noviSastojak.kolicina = decimal.Parse(kolicina);
                noviSastojak.mjerna_jedinica = mjerna_jedinica;
                noviSastojak.jelo = odabranoJelo;
                db.sastojaks.Add(noviSastojak);
                db.SaveChanges();
            }
        }
        public void Obrisi(sastojak odabraniSastojak)
        {
            using (var db = new Entities17045_DB())
            {
                db.sastojaks.Attach(odabraniSastojak);
                db.sastojaks.Remove(odabraniSastojak);
                db.SaveChanges();
            }
        }
    }
}
