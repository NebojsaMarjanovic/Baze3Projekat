using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Models;
using WinFormApp.Repository.DataBaseBroker;

namespace WinFormApp.Repository
{
    internal class OtpremnicaRepository
    {

        private List<Otpremnica> otpremnice;
        private Broker broker;

        public OtpremnicaRepository()
        {
            broker = new Broker();
        }

        public List<Otpremnica> GetOtpremnice()
        {
            broker.OpenConnection();
            otpremnice = broker.GetOtpremnice();
            broker.CloseConnection();
            return otpremnice;
        }

        internal void AddOtpremnica(Otpremnica otpremnica)
        {
            broker.OpenConnection();
            broker.AddOtpremnica(otpremnica);
            broker.CloseConnection();
        }

        internal void UpdateOtpremnica(Otpremnica otpremnica)
        {
            broker.OpenConnection();
            broker.UpdateOtpremnica(otpremnica);
            broker.CloseConnection();
        }

        internal void DeleteOtpremnica(int brOtpremnice)
        {
            broker.OpenConnection();
            broker.DeleteOtpremnica(brOtpremnice);
            broker.CloseConnection();
        }
    }
}
