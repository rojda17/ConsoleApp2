using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12012022_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //temelSinif t1 = new temelSinif();
            musteri m1 = new musteri();
            m1.kayitTarihi = DateTime.Now;
            m1.test();
            Console.ReadLine();
        }
    }
}
