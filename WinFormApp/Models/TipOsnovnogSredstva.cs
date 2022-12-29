using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Models
{
    public class TipOsnovnogSredstva
    {
        public int IDTipaOS { get; set; }
        public string NazivTipaOS { get; set; }

        public override string ToString()
        {
            return NazivTipaOS;
        }
    }

}
