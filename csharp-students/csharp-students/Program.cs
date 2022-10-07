using System;

namespace csharp_students
{
    class Program
    {
        static void Main(string[] args)
        {
            Ders[] dersler1 = new Ders[2];
            dersler1[0] = new Ders("IST1001", "İSTATİSTİK", 6, 62);
            dersler1[1] = new Ders("BİL1001", "BİLGİSAYAR BİLİMLERİNE GİRİS", 4, 44);
            Ogrenci ogr1 = new Lisans("9201291014", "HAMİDE KAYA", "BİLGİSAYAR BİLİMLERİ", dersler1);

            Ders[] dersler2 = new Ders[3];
            dersler2[0] = new Ders("MAT1001", "MATEMATİK", 6, 75);
            dersler2[1] = new Ders("MAT1007", "AYRIK MATEMATİK", 6, 23);
            dersler2[2] = new Ders("FSH333", "İLETİŞİM", 8, 100);
            Ogrenci ogr2 = new Lisans("5201321022", "FULYA KARAMAN", "MATEMATİK", dersler2);

            Ders[] dersler3 = new Ders[2];
            dersler3[0] = new Ders("EKO1009", "EKONOMİYE GİRİŞ", 3, 89);
            dersler3[1] = new Ders("İST1003", "İŞ HUKUKU", 4, 65);
            Ogrenci ogr3 = new Yukseklisans("ÇALIŞMA EKONOMİSİ VE ENDÜSTRİ İLİŞKİLER", "İSTANBUL ÜNİVERSİTESİ", "601029102", "CUMHUR YILDIRIM", "EKONOMİ", dersler3);

            Ders[] dersler4 = new Ders[2];
            dersler4[0] = new Ders("HUK1873", "ROMA HUKUKU", 6, 88);
            dersler4[1] = new Ders("TAR2347", "OSMANLI TARİHİNDE HUKUK", 7, 60);
            Ogrenci ogr4 = new Yukseklisans("HUKUK", "DOKUZ EYLÜL ÜNİVERSİTESİ", "401387005", "OYLUM GÜLER", "ULUSLARARASI İLİŞKİLER", dersler4);

            Ders[] dersler5 = new Ders[2];
            dersler5[0] = new Ders("TIP4837", "ANATOMİ", 8, 5);
            dersler5[1] = new Ders("PSK4673", "FİZİKSEL PSİKOLOJİ", 6, 100);
            Ogrenci ogr5 = new Doktora("İZMİR KATİP ÇELEBİ ÜNİVERSİTESİ", "FİZYOTERAPİ", "BOĞAZİÇİ ÜNİVERSİTESİ", "PSİKOLOJİ", "4741030", "ÇAĞLA ÇAĞLAYAN", "HEMŞİRELİK", dersler5);

            Console.WriteLine("LİSANS\n");
            ogr1.BilgileriGoster();
            Console.WriteLine("\t\t\tKümülatif:" + ogr1.Kumulatif() + "\n");

            ogr2.BilgileriGoster();
            Console.WriteLine("\t\t\tKümülatif:" + ogr2.Kumulatif() + "\n");

            Console.WriteLine("YÜKSEK LİSANS\n");
            ogr3.BilgileriGoster();
            Console.WriteLine("\t\t\tKümülatif:" + ogr3.Kumulatif() + "\n");

            ogr4.BilgileriGoster();
            Console.WriteLine("\t\t\tKümülatif:" + ogr4.Kumulatif() + "\n");

            Console.WriteLine("DOKTORA\n");
            ogr5.BilgileriGoster();
            Console.WriteLine("\t\t\tKümülatif:" + ogr5.Kumulatif() + "\n\n");

            Console.ReadKey();
        }
    }
}
