using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11012022_KalıtımOrnek
{
    public class Urun
    {
        private int sayac = 1;
        public Urun()
        {
            this._ID = sayac;
            sayac++;
        }
        private int _ID;
        public int ID
        {
            get { return _ID; }
            private set{ ID = value;} //ID ye dışardan bir şey atılmaması için private yaptık
         }
        public string  Marka { get; set; }
        public string Model { get; set; }
        public decimal AlisFiyati { get { return AlisFiyati; }
            set
            { if (value > 0)
                    this.AlisFiyati = value;
                else
                    Console.WriteLine("ALIŞ FİYATI SIFIRDAN BÜYÜK OLMALIDIR");

                    }

        }
        public decimal SatisFiyati
        {
            get { return SatisFiyati; }
            set
            {
                if (value > this.AlisFiyati)
                    this.AlisFiyati = value;
                else
                    Console.WriteLine("satış fiyatı alış fiyatından küçük olamaz.");
            }
        }
        private decimal _KampanyaFiyati;
        public decimal KampanyaFiyati { get { return _KampanyaFiyati; }
            set
            {
                if (value > this.AlisFiyati)
                    this._KampanyaFiyati = value;
                else
                    Console.WriteLine("KAMPANYA FİYATI ALIŞ FİYATINDAN KÜÇÜK OLAMAZ.");
            }
            }
        public string Barkod {
            get { return Barkod; } 
            set { bool sonuc = sanaldatabase.BarkodKontrol(value);
                if (sonuc == false)
                    this.Barkod = value;
                else
                    Console.WriteLine("bu barkod daha önce tanımlanmış");
            }
                }

        

    }
}
