using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12012022_InterfaceOrnek
{
    public class Hesaplama:Ihesaplama
    {
        public decimal sayi1;
        public decimal sayi2;
        public decimal bolum(decimal s1,decimal s2)
        {
            return s1 / s2;
        }
        public decimal carpma(decimal s1, decimal s2)
        {
            return s1 * s2;
        }
        public decimal fark(decimal s1, decimal s2)
        {
            return s1 - s2;
        }
        public decimal topla(decimal s1, decimal s2)
        {
            return s1 + s2;
        }

    }
}
