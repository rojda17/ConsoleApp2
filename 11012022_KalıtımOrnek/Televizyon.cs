using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11012022_KalıtımOrnek
{
    public sealed class Televizyon:Urun
    {
        public bool SmartTV { get; set; }
        public bool HDMI { get; set; }
        public string EkranBoyutu { get; set; }
    }
}
