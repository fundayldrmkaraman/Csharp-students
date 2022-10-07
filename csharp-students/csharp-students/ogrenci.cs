using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_students
{
    abstract class Ogrenci
    {
        public string ogrno;
        public string ogradsoyad;
        public string bolumadi;
        public Ders[] Dersler { get; set; }

        public Ogrenci(string ogrno, string ogradsoyad, string bolumadi, Ders[] dersler)
        {
            this.ogrno = ogrno;
            this.ogradsoyad = ogradsoyad;
            this.bolumadi = bolumadi;
            this.Dersler = dersler;
        }
        public double Kumulatif(int akts = 10)
        {
            double k = 0;
            for (int i = 0; i < Dersler.Length; i++)
            {
                Dersler[i].akts = (Dersler[i].akts == 100.0) ? akts : Dersler[i].akts;
            }
            double toplamAkts = 0;
            for (int i = 0; i < Dersler.Length; i++)
            {
                k += Dersler[i].basarinotu * Dersler[i].akts;
                toplamAkts += Dersler[i].akts;
            }
            k /= toplamAkts;
            return k;
        }
        public abstract void BilgileriGoster();
    }
}
