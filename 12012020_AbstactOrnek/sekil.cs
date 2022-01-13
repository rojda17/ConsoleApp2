using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12012020_AbstactOrnek
{
    public abstract class Sekil
    {
       protected string sekilad;
        public void SekilYaz()
        {
            Console.WriteLine("Şekil Yaz"+sekilad);
        }
        abstract public void
            CevreHesapla();
        abstract public void
            AlanHesapla();
    }
}
