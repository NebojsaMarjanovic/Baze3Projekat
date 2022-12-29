using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Models;
using WinFormApp.Repository.DataBaseBroker;

namespace WinFormApp.Repository
{
    internal class TipOsRepository
    {
        private Broker broker;
        private List<TipOsnovnogSredstva> tipovi;

        public TipOsRepository()
        {
            broker = new Broker();
        }

        public List<TipOsnovnogSredstva> GetTipovi()
        {
            broker.OpenConnection();
            tipovi = broker.GetTipoviOS();
            broker.CloseConnection();
            return tipovi;
        }

        internal void AddTipOs(TipOsnovnogSredstva tipOS)
        {
            broker.OpenConnection();
            broker.AddTipOS(tipOS);
            broker.CloseConnection();
        }

        internal void UpdateTipOs(TipOsnovnogSredstva tipOs)
        {
            broker.OpenConnection();
            broker.UpdateTipOs(tipOs);
            broker.CloseConnection();
        }

        internal void DeleteTipOs(int idTipaOs)
        {
            broker.OpenConnection();
            broker.DeleteTipOs(idTipaOs);
            broker.CloseConnection();
        }
    }
}
