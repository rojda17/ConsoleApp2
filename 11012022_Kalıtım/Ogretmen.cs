using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11012022_Kalıtım
{
    public class Ogretmen : Personel
    {

        public string Brans { get; set; }
        public int BransSeviye { get; set; }

        public void Ogretmenmetot()
        {
            Console.WriteLine("öğretmen metot oluşturuldu");
        }

        protected void OgretmenMetot2()
        {
            Console.WriteLine("Öğretmen metot 2 oluşturuldu")
        }
      
            
    }
}
