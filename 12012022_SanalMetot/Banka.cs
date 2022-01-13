using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12012022_SanalMetot
{
    public class Banka
    {
        public double Eftucreti { get; set; }
       public Banka()
        {
            Eftucreti = 0;
        }
        virtual public void EFTIslemi()
        {
            Console.WriteLine("banka EFT işlemi gerçekleşti." + this.Eftucreti);
        }
    }
}
