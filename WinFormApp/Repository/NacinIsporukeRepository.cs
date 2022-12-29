using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Models;
using WinFormApp.Repository.DataBaseBroker;

namespace WinFormApp.Repository
{
    internal class NacinIsporukeRepository
    {
        private Broker broker;
        private List<NacinIsporuke> nacini;

        public NacinIsporukeRepository()
        {
            broker = new Broker();
        }

        public List<NacinIsporuke> GetNaciniIsporuke()
        {
            broker.OpenConnection();
            nacini = broker.GetNacinIsporuke();
            broker.CloseConnection();
            return nacini;
        }
    }
}
