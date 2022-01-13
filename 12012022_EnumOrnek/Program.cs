using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12012022_EnumOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.ID = 1;
            musteri.AdSoyad = "can karahan";
            musteri.musteriNo = "123456";
            musteri.Email = "bbb";

            SanalDatabase sb = new SanalDatabase();
            MusteriReturnValue sonuc=sb.YeniKayit(musteri);

            if (sonuc==MusteriReturnValue.kayitBasarili)
            {
                //işlemler devam ediyor
            }
            else if(sonuc==MusteriReturnValue.kayitBasarisiz)
            {
                //işlemler
            }
        }
    }
}
