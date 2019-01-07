using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBLFood
{
    public class NovaRezervacija
    {
        public void Rezerviraj(string ime, string prezime, int kontakt, int stol, int osobe, string objed, DateTime datum, TimeSpan vrijeme, zaposlenik odabraniZaposlenik)
        {
            using (var db = new Entities17045_DB())
            {
                db.zaposleniks.Attach(odabraniZaposlenik);
                rezervacija novaRezervacija = new rezervacija();
                novaRezervacija.ime_narucitelj = ime;
                novaRezervacija.prezime_narucitelj = prezime;
                novaRezervacija.kontakt_broj_narucitelj = kontakt.ToString();
                novaRezervacija.broj_stola = stol;
                novaRezervacija.broj_osoba = osobe;
                novaRezervacija.objed = objed;
                novaRezervacija.datum = datum;
                novaRezervacija.termin = vrijeme;
                novaRezervacija.zaposlenik = odabraniZaposlenik;

                db.rezervacijas.Add(novaRezervacija);
                db.SaveChanges();
            }
        }

        public void Obrisi(rezervacija selektiranaRezervacija)
        {
            using (var db = new Entities17045_DB())
            {
                db.rezervacijas.Attach(selektiranaRezervacija);
                db.rezervacijas.Remove(selektiranaRezervacija);
                db.SaveChanges();
            }
        }
    }
}
