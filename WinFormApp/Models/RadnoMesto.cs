using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Models
{
    public class RadnoMesto
    {
        public int IDRadnogMesta { get; set; }
        public string NazivRadnogMesta { get; set; }

        public override string ToString()
        {
            return NazivRadnogMesta;
        }
    }
}
