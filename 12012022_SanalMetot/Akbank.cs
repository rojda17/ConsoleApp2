using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12012022_SanalMetot
{
    public class Akbank:Banka
    {
        public Akbank()
        {
            Eftucreti = 1.2;
        }

        public override void EFTIslemi()
        {
            Console.WriteLine("Akbank EFT işlemi gerçekleşti."+this.Eftucreti);
        }
    }
}
