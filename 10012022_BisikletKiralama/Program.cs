using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10012022_BisikletKiralama
{
    class Program
    {
        static void Main(string[] args)
        {
            Kullanıcı k1 = new Kullanıcı();
            k1.AdSoyad = "rojda gök";
            k1.TCNo = "123456456789";
            k1.TelNo = "05384216789";

            Bisiklet b1 = new Bisiklet();
            b1.Marka = "bisan";
            b1.Model = "standart";
            b1.VitesSayisi = "24";
            b1.Renk = "kırmızı";

            Kiralama kira = new Kiralama();
            kira.Kullanıcı = k1;
            kira.Bisiklet = b1;

            Console.WriteLine("Bisiklet Kiralama");
            kira.Baslat();
            Thread.Sleep(5000);//bisikleti aldık süre geçti ve bitirdik.
            kira.Bitir();

            Console.ReadLine();
        } 
    }
}
