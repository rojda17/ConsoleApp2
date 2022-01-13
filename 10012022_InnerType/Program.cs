using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10012022_InnerType
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.adSoyad = "ad soyad";
            m1.TcNo = "tc no";
            m1.musteriAdresleri.Add(new MusteriAdres() { adresTip = "ev", Adres = "cadde sokak", Il = "istanbul", Ilce = "kadıköy" });
            m1.musteriAdresleri.Add(new MusteriAdres() { adresTip = "ev", Adres = "cadde sokak", Il = "istanbul", Ilce = "şişli" });//2. bir adres atmak istersek
            m1.musteritelefon.Add(new Musteriiletisim() { alankodu = "0532", telTip = "ev", telno = "025152313" });


        }
    }
}
