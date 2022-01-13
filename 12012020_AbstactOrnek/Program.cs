using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12012020_AbstactOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Dortgen dortgen = new Dortgen();
            dortgen.en = 5;
            dortgen.boy = 10;
            dortgen.AlanHesapla();
            dortgen.CevreHesapla();
            

            Daire daire = new Daire();
            daire.yaricap = 5;
            daire.AlanHesapla();
            daire.CevreHesapla();
            Console.ReadLine();
        }
    }
}
