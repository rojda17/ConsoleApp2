using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11012022_Kalıtım
{
    public class Personel:temelTip//eğer class yerine sealed yazarsak class ın katılımını keser.Başka yerde kullanılamaz.
    {
        public DateTime IsBaslangıcTarihi { get; set; }
        public DateTime IsBitisTarihi { get; set; }
        public int İzingunsayisi { get; set; }

        public void PERSONELMETOT()
        {
            Console.WriteLine("PERSONEL METOT ÇALIŞTI");
        }
    }
}
