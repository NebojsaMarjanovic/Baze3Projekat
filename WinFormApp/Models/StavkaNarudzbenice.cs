using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Models
{
    public class StavkaNarudzbenice
    {
        public int IDNarudzbenice { get; set; }
        public int RbStavke { get; set; }
        public int Kolicina { get; set; }
        public double Cena { get; set; }
        public int IDOsnovnogSredstva { get; set; }
    }
}
