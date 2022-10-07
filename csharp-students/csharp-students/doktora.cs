using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_students
{

    class Doktora : Ogrenci
    {
        private string mezunOlduguLisansOkulAdi;
        private string mezunOlduguLisansBolumAdi;
        private string mezunOlduguYuksekLisansOkulAdi;
        private string mezunOlduguYuksekLisansBolumAdi;

        public Doktora(string mezunOlduguLisansOkulAdi, string mezunOlduguLisansBolumAdi, string mezunOlduguYuksekLisansOkulAdi, string mezunOlduguYuksekLisansBolumAdi, string ogrno, string ogradsoyad, string bolumadi, Ders[] dersler) : base(ogrno, ogradsoyad, bolumadi, dersler)
        {
            this.mezunOlduguLisansBolumAdi = mezunOlduguLisansBolumAdi;
            this.mezunOlduguLisansOkulAdi = mezunOlduguLisansOkulAdi;
            this.mezunOlduguYuksekLisansBolumAdi = mezunOlduguYuksekLisansBolumAdi;
            this.mezunOlduguYuksekLisansOkulAdi = mezunOlduguYuksekLisansOkulAdi;
        }

        public override void BilgileriGoster()
        {
            Console.WriteLine("\n" + this.ogrno + "==> " + this.ogradsoyad + ", " + this.bolumadi);
            Console.WriteLine("\nLisans Bilgileri:");
            Console.WriteLine("\n\n" + this.mezunOlduguLisansOkulAdi + "; " + this.mezunOlduguLisansBolumAdi);
            Console.WriteLine("\nYüksek Lisans Bilgileri:");
            Console.WriteLine("\n\n" + this.mezunOlduguYuksekLisansOkulAdi + "; " + this.mezunOlduguYuksekLisansBolumAdi); ;
            Console.WriteLine("\nDers Bilgileri:");
            foreach (Ders ders in this.Dersler)
            {
                Console.WriteLine("\n\n" + ders.Derskodu + "= " + ders.Dersadi + ", " + ders.akts + " akts, " + ders.basarinotu + "puan");
            }
            Console.WriteLine();
        }
    }
}
