using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11012022_YemekOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Yemek y1 = new Yemek();
            Tatlilar t1 = new Tatlilar();
            t1.ad = "Sekerpare";
            t1.Hazırlamasuresi = "1 saat";
            t1.gram = 100;
            t1.YagTipi = "tereyağ";
            t1.fiyat = 20;
        }
    }
}
