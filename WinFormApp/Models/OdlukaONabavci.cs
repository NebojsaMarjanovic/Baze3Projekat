using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Models
{
    internal class OdlukaONabavci
    {
        public int IDOdlukeONabavci { get; set; }
        public DateOnly DatumDonosenja { get; set; }
        public int IDZaposlenog { get; set; }
    }
}
