using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Models
{
    public class NacinIsporuke
    {
        public int IDNacinaIsporuke { get; set; }
        public string NazivNacinaIsporuke { get; set; }

        public override string ToString()
        {
            return NazivNacinaIsporuke;
        }
    }
}
