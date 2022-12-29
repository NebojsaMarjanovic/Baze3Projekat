using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Models;
using WinFormApp.Repository.DataBaseBroker;

namespace WinFormApp.Repository
{
    internal class ZaposleniRepository
    {
        private Broker broker;
        private List<Zaposleni> zaposleni;

        public ZaposleniRepository()
        {
            broker = new Broker();
        }

        public List<Zaposleni> GetZaposleni()
        {
            broker.OpenConnection();
            zaposleni = broker.GetZaposleni();
            broker.CloseConnection();
            return zaposleni;
        }

        internal Zaposleni GetZaposleniDetalji(Zaposleni zaposleni)
        {
            broker.OpenConnection();
            zaposleni = broker.GetZaposleniDetalji(zaposleni);
            broker.CloseConnection();
            return zaposleni;
        }
    }
}
