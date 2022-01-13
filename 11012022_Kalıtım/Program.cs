using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11012022_Kalıtım
{
    class Program
    {
        static void Main(string[] args)
        {
            temelTip T1 = new temelTip();
            //T1.temelTipMetot1();

            Ogrenci O1 = new Ogrenci();
            //O1.temelTipMetot1();

            Ogretmen Ogr = new Ogretmen();

            //Object nesnesi temel tip olduğundan Öğretmen ve öğrenci nesneleri için object gibi davranır.
            T1 = O1;//boxing
            T1 = Ogr;//boxing
            O1 = (Ogrenci)T1;//unboxing
            Ogr = (Ogretmen)T1;//unboxing

            object obj = T1;

            T1 = (temelTip)obj;

            Ogrenci o2 = new Ogrenci();

            o2 =(Ogrenci)T1;

            Personel p1 = new Personel();
            p1.PERSONELMETOT();
            Ogr.PERSONELMETOT();
            Ogr.Ogretmenmetot();
            O1.temelTipMetot1(); 




            Console.ReadLine();


        }
    }
}
