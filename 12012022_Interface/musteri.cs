using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12012022_Interface
{
    public class musteri : temelTip,Imusteri
    {
        public int id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string isim { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string soyisim { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int kayitsil(int id)
        {
            throw new NotImplementedException();
        }

        public int yenikayit(string isim, string soyisim)
        {
            throw new NotImplementedException();
        }
    }
}
