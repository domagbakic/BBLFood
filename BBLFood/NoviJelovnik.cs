using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBLFood
{
    class NoviJelovnik
    {
        public void Dodaj(string naziv, string cijena)
        {
            using (var db = new Entities17045_DB())
            {
                jelovnik noviJelovnik = new jelovnik();
                noviJelovnik.naziv = naziv;
                noviJelovnik.cijena = double.Parse(cijena);
                db.jelovniks.Add(noviJelovnik);
                db.SaveChanges();
            }
        }
        public void DodajPredjelo(jelo odabranoPredjelo, jelovnik odabraniJelovnik)
        {
            using (var db = new Entities17045_DB())
            {
                db.jeloes.Attach(odabranoPredjelo);
                db.jelovniks.Attach(odabraniJelovnik);
                jelovnik_jelo JJ = new jelovnik_jelo();
                JJ.jelo = odabranoPredjelo;
                JJ.jelovnik = odabraniJelovnik;
                JJ.kolicina = 1;
                db.jelovnik_jelo.Add(JJ);
                db.SaveChanges();
            }
        }
        public void DodajGlavnoJelo(jelo odabranoGlavnoJelo, jelovnik odabraniJelovnik)
        {
            using (var db = new Entities17045_DB())
            {
                db.jeloes.Attach(odabranoGlavnoJelo);
                db.jelovniks.Attach(odabraniJelovnik);
                jelovnik_jelo JJ = new jelovnik_jelo();
                JJ.jelo = odabranoGlavnoJelo;
                JJ.jelovnik = odabraniJelovnik;
                JJ.kolicina = 1;
                db.jelovnik_jelo.Add(JJ);
                db.SaveChanges();
            }
        }
        public void DodajDesert(jelo odabraniDesert, jelovnik odabraniJelovnik)
        {
            using (var db = new Entities17045_DB())
            {
                db.jeloes.Attach(odabraniDesert);
                db.jelovniks.Attach(odabraniJelovnik);
                jelovnik_jelo JJ = new jelovnik_jelo();
                JJ.jelo = odabraniDesert;
                JJ.jelovnik = odabraniJelovnik;
                JJ.kolicina = 1;
                db.jelovnik_jelo.Add(JJ);
                db.SaveChanges();
            }
        }
    }
}
