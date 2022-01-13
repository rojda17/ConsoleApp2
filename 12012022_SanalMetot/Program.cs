using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12012022_SanalMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            Banka b1 = new Banka();
            b1.EFTIslemi();

            Akbank a1 = new Akbank();
            a1.EFTIslemi();
            Console.ReadLine();
        }
    }
}
