using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Models;
using WinFormApp.Repository.DataBaseBroker;

namespace WinFormApp.Repository
{
    internal class StavkaRacunaRepository
    {
        private List<StavkaRacuna> stavke;
        private Broker broker;

        public StavkaRacunaRepository()
        {
            broker = new Broker();
        }

        public List<StavkaRacuna> GetStavke(int brRacuna)
        {
            broker.OpenConnection();
            stavke = broker.GetStavkeRacuna(brRacuna);
            broker.CloseConnection();
            return stavke;
        }

        internal void AddStavkaRacuna(StavkaRacuna stavka)
        {
            try
            {

                broker.OpenConnection();
                broker.AddStavkaRacuna(stavka);
            }
            finally
            {
                broker.CloseConnection();

            }
        }

        internal void UpdateStavkaRacuna(StavkaRacuna stavka)
        {
            broker.OpenConnection();
            broker.UpdateStavkaRacuna(stavka);
            broker.CloseConnection();
        }

        internal void DeleteStavka(int brRacuna, int rbStavke)
        {
            try
            {

                broker.OpenConnection();
                broker.DeleteStavka(brRacuna, rbStavke);
            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}
