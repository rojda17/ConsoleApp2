using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12012022_Interface
{
    public interface Imusteri
    {
        //FİELD TANIMLANAMAZ PROPERTY OLMAK ZORUNDA
        int id { get; set; }
        string isim { get; set; }
        string soyisim { get; set; }

        int yenikayit(string isim,string soyisim);//bu metotların bodysi{} olamaz!
        int kayitsil(int id);//bu metotların bodysi{} olamaz!

    }
}
