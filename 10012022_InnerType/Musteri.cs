using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10012022_InnerType
{
    public class Musteri
    {
        public int musteriID { get; set; }
        public string adSoyad { get; set; }
        public string TcNo { get; set; }

        //Inner Type gerektiren alanlar
        public List<MusteriAdres> musteriAdresleri;

        public List<Musteriiletisim> musteritelefon;

        public List<MusteriUr>


    }
}
