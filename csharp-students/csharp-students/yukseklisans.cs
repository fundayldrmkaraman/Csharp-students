using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_students
{

    class Yukseklisans : Ogrenci
    {
        private string mezunOlduguLisansOkulAdi;
        private string mezunOlduguLisansBolumAdi;

        public Yukseklisans(string mezunOlduguLisansBolumAdi, string mezunOlduguLisansOkulAdi, string ogrno, string ogradsoyad, string bolumadi, Ders[] dersler) : base(ogrno, ogradsoyad, bolumadi, dersler)
        {
            this.mezunOlduguLisansBolumAdi = mezunOlduguLisansBolumAdi;
            this.mezunOlduguLisansOkulAdi = mezunOlduguLisansOkulAdi;
        }
        public override void BilgileriGoster()
        {
            Console.WriteLine("\n" + this.ogrno + "==> " + this.ogradsoyad + ", " + this.bolumadi);
            Console.WriteLine("\nLisans Bilgileri:");
            Console.WriteLine("\n\n" + this.mezunOlduguLisansOkulAdi + ", " + this.mezunOlduguLisansBolumAdi);
            Console.WriteLine("\nDers Bilgileri:");
            foreach (Ders ders in this.Dersler)
            {
                Console.WriteLine("\n\n" + ders.Derskodu + "= " + ders.Dersadi + ", " + ders.akts + " akts, " + ders.basarinotu + "puan");
            }
            Console.WriteLine();
        }
    }
}
