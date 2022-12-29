using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Models
{
    public class StavkaRacuna
    {
        public int BrRacuna { get; set; }
        public int RbStavke { get; set; }
        public int Kolicina { get; set; }
        public double Cena { get; set; }
        public OsnovnoSredstvo OsnovnoSredstvo { get; set; }
    }
}
