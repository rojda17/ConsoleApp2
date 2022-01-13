using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11012022_KalıtımOrnek
{
    public static class sanaldatabase
    {
        public static ArrayList db = new ArrayList();
        public static void UrunEkle(Urun urun)
        {
            if(urun!=null && !string.IsNullOrEmpty(urun.Barkod))
            db.Add(urun);

        }
        public static bool BarkodKontrol(string barkod)
        {
            for (int i = 0; i < db.Count; i++)
            {
                Urun urun = new Urun();
                urun=(Urun)db[i];
                if (urun.Barkod == barkod)
                    return true;

            }
            return false;

        }
    }
}
