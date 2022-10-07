using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_students
{
    class Ders
    {
        private string derskodu;
        private string dersadi;
        public double akts { get; set; }
        public double basarinotu { get; }
        public string Derskodu { get => derskodu; set => derskodu = value; }
        public string Dersadi { get => dersadi; set => dersadi = value; }

        public Ders(string derskodu, string dersadi, int akts, double basarinotu)
        {
            this.Derskodu = derskodu;
            this.Dersadi = dersadi;
            this.akts = akts;
            this.basarinotu = basarinotu;
        }
    }
}
