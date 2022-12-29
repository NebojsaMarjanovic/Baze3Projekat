using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Models;
using WinFormApp.Repository.DataBaseBroker;

namespace WinFormApp.Repository
{
    public class OsnovnoSredstvoRepository
    {
        private List<OsnovnoSredstvo> osnovnaSredstva;
        private Broker broker;

        public OsnovnoSredstvoRepository()
        {
            broker = new Broker();
        }

        public List<OsnovnoSredstvo> GetOsnovnaSredstva()
        {
            broker.OpenConnection();
            osnovnaSredstva = broker.GetOsnovnaSredstva();
            broker.CloseConnection();
            return osnovnaSredstva;
               
        }

        internal void DeleteOsnovnoSredstvo(int iDOsnovnogSredstva)
        {
            broker.OpenConnection();
            broker.DeleteOsnovnoSredstvo(iDOsnovnogSredstva);
            broker.CloseConnection();
        }

        internal void AddOsnovnoSredstvo(OsnovnoSredstvo os)
        {
            broker.OpenConnection();
            broker.AddOsnovnoSredstvo(os);
            broker.CloseConnection();
        }

        internal void UpdateOsnovnoSredstvo(OsnovnoSredstvo novoOS)
        {
            broker.OpenConnection();
            broker.UpdateOsnovnoSredstvo(novoOS);
            broker.CloseConnection();
        }
    }
}
