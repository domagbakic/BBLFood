using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBLFood
{
    class NoviZaposlenik
    {
        public void Dodaj(string ime, string prezime, radno_mjesto odabranoRadnoMjesto)
        {
            using (var db = new Entities17045_DB())
            {
                db.radno_mjesto.Attach(odabranoRadnoMjesto);
                zaposlenik noviZaposlenik = new zaposlenik();
                noviZaposlenik.ime = ime;
                noviZaposlenik.prezime = prezime;
                noviZaposlenik.radno_mjesto = odabranoRadnoMjesto;
                db.zaposleniks.Add(noviZaposlenik);
                db.SaveChanges();
            }
        }
        /*
        public void Obrisi(zaposlenik odabraniZaposlenik)
        {
            using (var db = new Entities17045_DB())
            {
                db.zaposleniks.Attach(odabraniZaposlenik);
                db.zaposleniks.Remove(odabraniZaposlenik);
                db.SaveChanges();
            }
        }
        */
    }
}
