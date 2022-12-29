using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Models
{
    public class Racun
    {
        public int BrRacuna { get; set; }
        public Placanje Placanje { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public Narudzbenica Narudzbenica { get; set; }
        public Zaposleni Zaposleni  { get; set; }
        public Dobavljac Dobavljac { get; set; }
        public string Napomena { get; set; }

        public override string ToString()
        {
            return BrRacuna.ToString();
        }
    }
}
