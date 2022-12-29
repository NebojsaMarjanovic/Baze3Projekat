using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Models
{
    public class OsnovnoSredstvo
    {
        public int IDOsnovnogSredstva { get; set; }
        public string NazivOsnovnogSredstva { get; set; }
        public string NazivTipaOS { get; set; }
        public string JedinicaMere { get; set; }
        public TipOsnovnogSredstva TipOsnovnogSredstva { get; set; }

        public override string ToString()
        {
            if(JedinicaMere!=null)
                return $"{NazivOsnovnogSredstva}({JedinicaMere})";
            return NazivOsnovnogSredstva;
        }
    }
}
