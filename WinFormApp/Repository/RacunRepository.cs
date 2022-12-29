using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Models;
using WinFormApp.Repository.DataBaseBroker;

namespace WinFormApp.Repository
{
    internal class RacunRepository
    {
        private List<Racun> racuni;
        private Broker broker;

        public RacunRepository()
        {
            broker = new Broker();
        }

        public List<Racun> GetRacuni()
        {
            broker.OpenConnection();
            racuni = broker.GetRacuni();
            broker.CloseConnection();
            return racuni;
        }

        internal void AddRacun(Racun racun)
        {
            try
            {

                broker.OpenConnection();
                broker.AddRacun(racun);
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        internal int GetCountRacuniPoGodini(int brojParticije)
        {
            broker.OpenConnection();
            int count = broker.GetCountRacuniPoGodini(brojParticije);
            broker.CloseConnection();
            return count;
        }

        internal void UpdateRacun(Racun racun)
        {
            try
            {
                broker.OpenConnection();
                broker.UpdateRacun(racun);
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        internal void DeleteRacun(int brRacuna)
        {
            try
            {

                broker.OpenConnection();
                broker.DeleteRacun(brRacuna);
            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}
