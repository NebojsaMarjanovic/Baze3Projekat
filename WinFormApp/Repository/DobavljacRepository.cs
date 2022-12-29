using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Models;
using WinFormApp.Repository.DataBaseBroker;

namespace WinFormApp.Repository
{
    internal class DobavljacRepository
    {
        private List<Dobavljac> dobavljaci;
        private Broker broker;

        public DobavljacRepository()
        {
            broker = new Broker();
        }

        public List<Dobavljac> GetDobavljaci()
        {
            broker.OpenConnection();
            dobavljaci = broker.GetDobavljaci();
            broker.CloseConnection();
            return dobavljaci;
        }

        internal void AddDobavljac(Dobavljac dobavljac)
        {
            try
            {
                broker.OpenConnection();
                broker.AddDobavljac(dobavljac);
            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}
