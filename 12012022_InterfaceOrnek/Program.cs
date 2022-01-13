using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12012022_InterfaceOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Hesaplama hesap = new Hesaplama();
            hesap.sayi1 = 10;
            hesap.sayi2=2.5m;

            hesap.bolum(hesap.sayi2, hesap.sayi1);
            hesap.carpma(hesap.sayi2, hesap.sayi1);
            hesap.fark(hesap.sayi2, hesap.sayi1);
            hesap.topla(hesap.sayi2, hesap.sayi1);

             

        }
    }
}
