using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBLFood
{
    class NovoRadnoMjesto
    {
        public void Dodaj(string naziv)
        {
            using (var db = new Entities17045_DB())
            {
                radno_mjesto novoRadnoMjesto = new radno_mjesto();
                novoRadnoMjesto.naziv = naziv;
                db.radno_mjesto.Add(novoRadnoMjesto);
                db.SaveChanges();
            }
        }
    }
}
