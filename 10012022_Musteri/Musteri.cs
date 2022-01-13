using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10012022_Musteri
{
    public class Musteri
    {
        
        private string adsoyad;
        private string kullaniciadi;
        private string email;
        private string sifre;

        public string AdSoyad { get; set; }
        public string KullaniciAdi {
            get
            { return this.kullaniciadi; }
            set
            { if (!KulAdKontrol(value))
                    this.kullaniciadi = value;
                else
                    this.kullaniciadi = string.Empty;
            }
                }
        public string Email
        {
            get
            { return this.email; }
            set
            {
                if (!KulAdKontrol(value))
                    this.email = value;
                else
                    this.email = string.Empty;
            }
        }


        public string Sifre { get; set; }

        List<Musteri> database = new List<Musteri>();

        public bool KulAdKontrol(string kulad)
        {
            foreach (var item in database)
            {
                if (item.kullaniciadi == kullaniciadi)
                  return  true;
                break;

            }
            return false;
        }

        public bool EmailKontrol(string email)
        {
            foreach (var item in database)
            {
                if (item.email == email)
                    return true;
                break;

            }
            return false;
        }

        public void MusteriEkle(Musteri musteri)
        {
            if((musteri!=null) && !string.IsNullOrEmpty(musteri.kullaniciadi) && !string.IsNullOrEmpty(musteri.Email))
            database.Add(musteri);
            Console.WriteLine("yeni müşteri eklendi");
        }
    }
}
