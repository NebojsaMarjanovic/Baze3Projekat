using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Models
{
    public class Zaposleni
    {
        public int IDZaposlenog { get; set; }
        public string ImePrezime { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public string BrojTelefona { get; set; }
        public RadnoMesto RadnoMesto { get; set; }

        public override string ToString()
        {
            return ImePrezime;
        }

        public override bool Equals(object obj)
        {
            if (obj is Zaposleni z)
            {
                return z.IDZaposlenog == IDZaposlenog;
            }
            return false;
        }
    }
}
