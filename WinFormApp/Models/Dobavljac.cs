using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Models
{
    public class Dobavljac
    {
        public int IDDobavljaca { get; set; }
        public string Naziv { get; set; }
        public string BrojTelefona { get; set; }
        public int PIB { get; set; }

        public override string ToString()
        {
            return Naziv;
        }

        public override bool Equals(object obj)
        {
            if (obj is Dobavljac d)
            {
                return d.IDDobavljaca == IDDobavljaca;
            }
            return false;
        }
    }
}
