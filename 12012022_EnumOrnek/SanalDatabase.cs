using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12012022_EnumOrnek
{
    public class SanalDatabase
    {
        ArrayList sanalDB = new ArrayList();
        public MusteriReturnValue YeniKayit(Musteri M)
        {
            sanalDB.Add(M);
            return MusteriReturnValue.kayitBasarili;
        }
    }
}
