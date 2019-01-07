using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBLFood
{
    class NovoJelo
    {
        public void Dodaj(string naziv, string vrsta, string cijena)
        {
            using (var db = new Entities17045_DB())
            {
                jelo novoJelo = new jelo();
                novoJelo.naziv = naziv;
                novoJelo.vrsta = vrsta;
                novoJelo.cijena = double.Parse(cijena);
                db.jeloes.Add(novoJelo);
                db.SaveChanges();
            }
        }
    }
}
