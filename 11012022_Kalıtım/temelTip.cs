using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11012022_Kalıtım
{
    public class temelTip
    {
        public int id { get; set; }
        public string AdSoyad { get; set; }
        public string TCKimlikNo { get; set; }
        public int cinsiyet { get; set; }
        public DateTime kayitTarihi { get; set; }

        public void temelTipMetot1()
        {
            Console.WriteLine("Temel tip classındaki metot çalıştı");
        }

        public temelTip()
        {
            Console.WriteLine("temel tip yapıcı metot çalıştı");
        }
    }
}
