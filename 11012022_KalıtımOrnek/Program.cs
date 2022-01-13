using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11012022_KalıtımOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun = new Urun();
           
            Bilgisayar b1 = new Bilgisayar();
            b1.Marka = "asus";
            b1.Model = "x005";
            b1.Islemci = "i7";
            b1.Ram = 16;
            b1.EkranKartı = "e15";
            b1.Barkod = "b00b2";
            b1.AlisFiyati = 5500;
            b1.SatisFiyati = 7500;
            b1.KampanyaFiyati = 7200;

            sanaldatabase.UrunEkle(b1);

        }
    }
}
