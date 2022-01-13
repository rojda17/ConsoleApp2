using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12012020_AbstactOrnek
{
    public class Daire:Sekil
    {
        public int yaricap;
        private float pi = 3.14f;

        public Daire()
        {
            sekilad = "daire";
        }

        public override void AlanHesapla()
        {
            SekilYaz();
            Console.WriteLine("dairenin alanı:{0}",pi*Math.Pow(yaricap,2));
        }

        public override void CevreHesapla()
        {
            SekilYaz();
            Console.WriteLine("dairenin çevresi:{0}",2*yaricap*pi);
        }
    }
}
