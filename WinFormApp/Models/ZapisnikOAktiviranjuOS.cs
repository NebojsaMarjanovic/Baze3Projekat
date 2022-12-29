using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Models
{
    internal class ZapisnikOAktiviranjuOS
    {
        public int IDZapisnika { get; set; }
        public DateOnly DatumIzdavanja { get; set; }
        public int BrRacuna { get; set; }
        public int IDZaposlenog { get; set; }
        public int IDOsnovnogSredstva { get; set; }
    }
}
