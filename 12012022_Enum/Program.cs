using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12012022_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.adsoyad = "elif cengiz";
            ogrenci1.alan =Alan.Sayisal;

            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.adsoyad = "enes yalçın";
            ogrenci2.alan = Alan.EsitAgirlik;

            string alanbilgisi = Enum.GetName(typeof(Alan), ogrenci2.alan);
            string[] alandizisi = Enum.GetNames(typeof(Alan));  
        }
    }
}
