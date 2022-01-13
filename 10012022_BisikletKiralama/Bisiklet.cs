using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10012022_BisikletKiralama
{
    public class Bisiklet
    {
        private int ID;
        private string marka;
        private string model;
        private string vitessayisi;
        private string renk;


        public string Marka
        {
            get { return this.marka; }
            set { this.marka = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string VitesSayisi
        {
            get { return this.vitessayisi; }
            set { this.vitessayisi = value; }
        }

        public string Renk
        {
            get { return this.renk; }
            set { this.renk = value; }
        }
    }
}
