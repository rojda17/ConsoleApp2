using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11012022_YemekOrnek
{
    public class Yemek
    {
        //id ye dışarıdan bir şey yazmayalım kendisi atasın,o yüzden bu işlemi yaptık
        public int sayac = 1;
        public Yemek()
        {
            this._id = sayac;
            sayac++;
        }

        public int _id;
        public int ID { get { return this._id; }
            private set { } }
        public string ad { get; set; }
        public float fiyat { get; set; }
        public int kalori { get; set; }
        public int gram { get; set; }
        public string asci { get; set; }
        public string YagTipi { get; set; }
        public string Hazırlamasuresi { get; set; }
    }
}
