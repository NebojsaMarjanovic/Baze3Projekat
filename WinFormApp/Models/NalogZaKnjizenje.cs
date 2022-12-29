using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Models
{
    internal class NalogZaKnjizenje
    {
        public int BrRacuna { get; set; }
        public int IDZaposlenog { get; set; }
        public int BrNaloga { get; set; }
        public string Napomena { get; set; }
        public double Potrazivanje { get; set; }
        public double Dugovanje { get; set; }
        public DateOnly DatumIzdavanja { get; set; }
    }
}
