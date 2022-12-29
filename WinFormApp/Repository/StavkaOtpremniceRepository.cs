using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Models;
using WinFormApp.Repository.DataBaseBroker;

namespace WinFormApp.Repository
{
    internal class StavkaOtpremniceRepository
    {
        private List<StavkaOtpremnice> stavke;
        private Broker broker;

        public StavkaOtpremniceRepository()
        {
            broker = new Broker();
        }

        public List<StavkaOtpremnice> GetStavkeOtpremnice()
        {
            broker.OpenConnection();
            stavke = broker.GetStavkeOtpremnice();
            broker.CloseConnection();
            return stavke;
        }

        internal void AddStavkaOtpremnice(StavkaOtpremnice stavka)
        {
            broker.OpenConnection();
            broker.AddStavkaOtpremnice(stavka);
            broker.CloseConnection();
        }

        internal void DeleteStavkaOtpremnice(int brOtpremnice, int rbStavke)
        {
            broker.OpenConnection();
            broker.DeleteStavkaOtpremnice(brOtpremnice, rbStavke);
            broker.CloseConnection();
        }

        internal void UpdateStavkaOtpremnice(StavkaOtpremnice stavka)
        {
            try
            {
                broker.OpenConnection();
                broker.UpdateStavkaOtpremnice(stavka);
            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}
