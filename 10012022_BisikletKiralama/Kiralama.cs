using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10012022_BisikletKiralama
{
    public class Kiralama
    {
        private int ID;
        private float sure;
        private float ucret;
        private float OdenecekTutar;
        private DateTime baslamazamani;
        private DateTime bitiszamani;
        private Kullanıcı _kullanici;
        private Bisiklet _bisiklet;

        public Bisiklet Bisiklet
        {
            get { return this._bisiklet; }
            set { this._bisiklet = value; }
        }

        public Kullanıcı Kullanıcı
        {
            get { return this._kullanici; }
            set { this._kullanici = value; }
        }

        public void UcretHesapla()
        {
            TimeSpan zaman = bitiszamani - baslamazamani;
            sure = zaman.Seconds;
            ucret = 0.05f;
            OdenecekTutar = sure * ucret;
            EkrandaGoster();

        }

        public void EkrandaGoster()
        {
            Console.WriteLine("Sayın {0},{1} sn kullanım süreniz için ödemeniz gereken tutar:{2}", Kullanıcı.AdSoyad, sure, OdenecekTutar);

        }

        public void Baslat()
        {
            baslamazamani = DateTime.Now;
        }

        public void Bitir()
        {
            bitiszamani = DateTime.Now;
            UcretHesapla();
            
        }       
    }
}
