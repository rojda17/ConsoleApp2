using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11012022_SanalMetot
{
    public class temelTip
    {
        public override string ToString()
        {
            return "merhaba override metot"; 
        }
        public virtual string EkranaYaz()
        {
            return "merhaba virtual metot";
        }
    }
}
