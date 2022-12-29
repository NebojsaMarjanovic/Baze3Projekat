using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Models
{
    public class Narudzbenica
    {
        public int IDNarudzbenice { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public string MestoIzdavanja { get; set; }
        public int IDZaposlenog { get; set; }
        public int IDDobavljaca { get; set; }
        public int IDOdlukeONabavci { get; set; }
        public List<StavkaNarudzbenice> StavkeNarudzbenice { get; set; }

        public override string ToString()
        {
            return "ID: "+IDNarudzbenice;
        }

        public override bool Equals(object obj)
        {
            if (obj is Narudzbenica n)
            {
                return n.IDNarudzbenice == IDNarudzbenice;
            }
            return false;
        }
    }
}
