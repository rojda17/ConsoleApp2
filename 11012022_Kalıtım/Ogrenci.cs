using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11012022_Kalıtım
{
    public class Ogrenci:temelTip//Ogrenci class ı temelTip class ından kalıtılmış oluyor.
    {
        public string Bolum { get; set; }
        public int seviye { get; set; }

        public Ogrenci()
        {
            Console.WriteLine("Öğrenci yapıcı metot çalıştı");
        }
    }
}
