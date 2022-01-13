using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10012022_BisikletKiralama
{
    public class Kullanıcı
    {
        public int ID;
        public string adsoyad;
        public string tcno;
        public string telno;

        public string AdSoyad
        {
            get { return this.adsoyad; }
            set { this.adsoyad = value; }
        }

        public string TCNo
        {
            get { return this.tcno; }
            set { this.tcno = value; }
        }

        public string TelNo
        {
            get { return this.telno; }
            set { this.telno = value; }
        }

    }
}
