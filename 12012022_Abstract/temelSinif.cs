using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12012022_Abstract
{
    public abstract class temelSinif
    {
        public DateTime kayitTarihi { get; set; }
        public void test()
        {
            Console.WriteLine("temelsinif");
        }
        public abstract void testabstract()
        {
            //bu metotun body olmaz
        }

    }
}
