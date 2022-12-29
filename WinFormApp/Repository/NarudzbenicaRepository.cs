using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Models;
using WinFormApp.Repository.DataBaseBroker;

namespace WinFormApp.Repository
{
    internal class NarudzbenicaRepository
    {
        private Broker broker;
        private List<Narudzbenica> narurdzbenice;

        public NarudzbenicaRepository()
        {
            broker = new Broker();
        }

        public List<Narudzbenica> GetNarudzenice()
        {
            broker.OpenConnection();
            narurdzbenice = broker.GetNarudzbenice();
            broker.CloseConnection();
            return narurdzbenice;   
        }
    }
}
