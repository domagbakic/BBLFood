using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;

namespace BBLFood
{
    class NoviRacun
    {
        public void KreirajNoviRacun(zaposlenik odabraniZaposlenik)
        {
            using (var db = new Entities17045_DB())
            {
                db.zaposleniks.Attach(odabraniZaposlenik);
                racun noviRacun = new racun();
                noviRacun.zaposlenik = odabraniZaposlenik;
                noviRacun.datum_vrijeme = DateTime.Now;
                noviRacun.datum = DateTime.Now.ToShortDateString();
                noviRacun.iznos = 1;
                db.racuns.Add(noviRacun);
                db.SaveChanges();
            }
        }
        public void DodajJeloNaRacun(racun odabraniRacun, jelo odabranoJelo, int kolicina)
        {
            using (var db = new Entities17045_DB())
            {
                db.racuns.Attach(odabraniRacun);
                db.jeloes.Attach(odabranoJelo);
                racun_jelo RJ = new racun_jelo();
                RJ.racun = odabraniRacun;
                RJ.jelo = odabranoJelo;
                RJ.kolicina = kolicina;
                db.racun_jelo.Add(RJ);
                db.SaveChanges();
            }
        }
        public void DodajJelovnikNaRacun(racun odabraniRacun, jelovnik odabraniJelovnik, int kolicina)
        {
            using (var db = new Entities17045_DB())
            {
                var A = db.jelovnik_jelo.Where(x => x.jelovnik.id == odabraniJelovnik.id).ToList();
                foreach (var item in A)
                {
                    jelo odabranoJelo = item.jelo;
                    if (odabranoJelo != null)
                    {
                        db.jeloes.Attach(odabranoJelo);
                        db.racuns.Attach(odabraniRacun);
                        racun_jelo RJ = new racun_jelo();
                        RJ.racun = odabraniRacun;
                        RJ.jelo = odabranoJelo;
                        RJ.kolicina = kolicina;
                        db.racun_jelo.Add(RJ);
                        db.SaveChanges();
                    }
                }
            }
        } 
        public void IzdajRacun(racun odabraniRacun, float zaPlatiti, string popisStavki, string imeZaposlenika)
        {
            string Naziv = "";
            decimal Iznos = 0;
            List<decimal> listaZaUmanjiti = new List<decimal>();
            List<string> listaNaziva = new List<string>();

            using (var db = new Entities17045_DB())
            {
                var A = db.racun_jelo.Where(x => x.id_racun == odabraniRacun.id).ToList();
                foreach (var item in A)
                {
                    var C = item.jelo.sastojaks.Where(x => x.jelo.naziv == item.jelo.naziv).ToList();
                    foreach (var ite in C)
                    {
                        listaNaziva.Add(ite.naziv.ToString());
                        listaZaUmanjiti.Add((decimal)item.kolicina * (decimal)ite.kolicina);
                    }
                }
                for (int i = 0; i < listaNaziva.Count(); i++)
                {
                    Naziv = listaNaziva[i];
                    var B = db.zalihes.FirstOrDefault(x => x.naziv == Naziv);
                    if (B != null)
                    {
                        Iznos = listaZaUmanjiti[i];
                        zalihe odabranaZaliha = B;
                        db.zalihes.Attach(odabranaZaliha);
                        odabranaZaliha.kolicina = (decimal)odabranaZaliha.kolicina - Iznos;
                        odabranaZaliha.datum = DateTime.Now.ToShortDateString();
                        if (odabranaZaliha.kolicina >= 0)
                        {
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Nema dovoljno potrebnih sastojaka na zalihi!");
                            return;
                        }
                    }
                }
            }
            listaNaziva.Clear();
            listaZaUmanjiti.Clear();

            using (var db = new Entities17045_DB())
            {
                db.racuns.Attach(odabraniRacun);
                odabraniRacun.iznos = zaPlatiti;
                db.SaveChanges();
            }

            //Kreiranje računa u PDF-u
            string nazivDatoteke = "Racun" + odabraniRacun.id.ToString() + ".pdf";
            Document racunPDF = new Document(iTextSharp.text.PageSize.LETTER, 20, 15, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(racunPDF, new FileStream(nazivDatoteke, FileMode.Create));
            racunPDF.Open();
            Paragraph header = new Paragraph("\n\nŠifra racuna: " + odabraniRacun.id.ToString() + "     ||     Vrijeme: " + odabraniRacun.datum_vrijeme.ToString()
                + "     ||     Zaposlenik: " + imeZaposlenika + "\n\n\n");
            header.Alignment = Element.ALIGN_CENTER;
            Paragraph stavke = new Paragraph(popisStavki + "\n\n");
            stavke.IndentationLeft = 30;
            Paragraph footer = new Paragraph("Iznos za platiti: " + odabraniRacun.iznos.ToString() + " kn");
            footer.IndentationLeft = 30;
            racunPDF.Add(header);
            racunPDF.Add(stavke);
            racunPDF.Add(footer);
            racunPDF.Close();

            //Otvaranje PDF-a
            System.Diagnostics.Process.Start(nazivDatoteke);
        }       
    }
}
