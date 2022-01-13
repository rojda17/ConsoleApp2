using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SticNedir
{
    public class Ogrenci
    {
        //Field
        private string adsoyad;
        private string tCNo;
        private string email;
        private string domain="firma.com";
        //Property
        public string Email
        {
            get { return email; }
            set { email = value + "@" + domain; }
        }


        public static int ogrencisayisi;//bu field bu class a ait ama nesne üzerinden erişilemez.

        public string TCNo { get; set; }//prop+tab+tab get set kısa yolu.İçinde bir değişiklik yapmayacaksak return.this falan onları yazmamıza gerek yok.
        public string AdSoyad
        {
            get { return this.adsoyad; }
            set { adsoyad = value; }
        }
        //Constructer
        public Ogrenci()
        {
            Console.WriteLine("standart ctor");//her nesne oluşturulduğunda çalışır.
            ogrencisayisi++;//her nesne oluşturulduğunda sayı 1 arttırılıyor.
        }

        static Ogrenci()
        {
            Console.WriteLine("static ctor");//ilk nesne oluşturulduğunda 1 kere çalışır.
        }
        public void Test2()//nesne üzerinden erişilen method
        {
            Test1();
           
        }
        //class üzerinden erişilen method
        public static void Test1()//statik olan metotlara nesne üzerinden erişemeyiz.Direkt class üzerinden erişebiliriz.
        {//Test2 ye erişemedik.Çünkü static metotlar yalnıca static metot ve field lara erişebilir.
            
            
        }
    }
}
