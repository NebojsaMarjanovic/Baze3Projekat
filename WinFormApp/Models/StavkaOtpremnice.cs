using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Models
{
    public class StavkaOtpremnice
    {
        public int BrOtpremnice { get; set; }
        public int RbStavke { get; set; }
        public int Kolicina { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public OsnovnoSredstvo OsnovnoSredstvo { get; set; }
    }
}
