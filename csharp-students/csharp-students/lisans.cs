using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_students
{
    class Lisans : Ogrenci
    {
        public Lisans(string ogrno, string ogradsoyad, string bolumadi, Ders[] dersler) : base(ogrno, ogradsoyad, bolumadi, dersler)
        {
            this.ogradsoyad = ogradsoyad;
            this.ogrno = ogrno;
            this.bolumadi = bolumadi;
        }
        public override void BilgileriGoster()
        {
            Console.WriteLine("\n" + this.ogrno + "==> " + this.ogradsoyad + ", " + this.bolumadi);

            foreach (Ders ders in this.Dersler)
            {
                Console.WriteLine("\n\n" + ders.Derskodu + "= " + ders.Dersadi + ", " + ders.akts + " akts, " + ders.basarinotu + "puan");
            }
            Console.WriteLine();
        }
    }
}
