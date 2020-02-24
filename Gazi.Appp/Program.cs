using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.Appp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci a = new Ogrenci();

            a.ad = "Ahmet Ruhi";
            a.soyad = "Aydemir";
            a.no = 193801006;
            a.bolum = "PC";


            Console.WriteLine(a.OgrenciBilgileri());
            Console.ReadKey();
        }
    }

    class Ogrenci
    {
        public int no;
        public string ad;
        public string soyad;
        public string bolum;

        public string OgrenciBilgileri()=> $"Adı:{this.ad}\nSoyadı:{this.soyad}\nNumara:{this.no}\nBölüm:{this.bolum}";
        //{
        //    return $"Adı:{this.ad}\nSoyadı:{this.soyad}\nNumara:{this.no}\nBölüm:{this.bolum}";
        //}
    }
}
