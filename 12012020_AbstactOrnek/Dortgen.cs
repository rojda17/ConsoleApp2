using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12012020_AbstactOrnek
{
    public class Dortgen:Sekil
    {
        public int en;
        public int boy;

        public Dortgen()
        {
            sekilad = "dörtgen";
        }

        public override void AlanHesapla()
        {
            SekilYaz();
            Console.WriteLine("Dörtgenin alanı:{0}",en*boy);
        }
        public override void CevreHesapla()
        {

            SekilYaz();
            Console.WriteLine("Dörtgenin Çevresi:{0}",2*(en+boy));
        }

        

    }
}
