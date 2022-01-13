using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SticNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o1 = new Ogrenci();
            o1.Test2();//nesne örneği alınarak static olmayan metota eriştik.
            Ogrenci.Test1();//static olmayan metota nesne üzerinden erişilmez.

            o1.AdSoyad = "ROJDA GÖK";
            o1.TCNo = "123456789";
            o1.Email = "rojda.gok";


            Ogrenci o2 = new Ogrenci() { AdSoyad = "muhammet çetinel", TCNo = "123554538" };

            Console.WriteLine(Ogrenci.ogrencisayisi);
            Helper.emailGonder(o1.AdSoyad, o1.Email, "bigilendirme", "yeni öğrenci kaydı oluşturuldu");


            Console.ReadLine();
        }
    }
}
