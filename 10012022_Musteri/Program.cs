using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10012022_Musteri
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri()
            {
                AdSoyad = "rojda gök",
                KullaniciAdi = "roj",
                Email = "rojda@gmail.com",
                Sifre = "12345"
             };
            m1.MusteriEkle(m1);
            
        }
    }
}
