using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Models;
using WinFormApp.Repository;

namespace WinFormApp.Controllers
{
    internal class Controller
    {
        private static Controller instance;
        #region repositories
        private RacunRepository racunRepository = new RacunRepository();
        private StavkaRacunaRepository stavkaRacunaRepository = new StavkaRacunaRepository();
        private OsnovnoSredstvoRepository osnovnoSredstvoRepository = new OsnovnoSredstvoRepository();
        private OtpremnicaRepository otpremnicaRepository = new OtpremnicaRepository();
        private NarudzbenicaRepository narudzbenicaRepository = new NarudzbenicaRepository();

        internal void AddTipOsnovnogSredstva(TipOsnovnogSredstva tipOS)
        {
            tipOsRepository.AddTipOs(tipOS);
        }

        private NacinIsporukeRepository nacinisporukeRepository = new NacinIsporukeRepository();

        internal void AddOsnovnoSredstvo(OsnovnoSredstvo os)
        {
            osnovnoSredstvoRepository.AddOsnovnoSredstvo(os);
        }

        private DobavljacRepository dobavljacRepository = new DobavljacRepository();
        private StavkaOtpremniceRepository stavkaOtpremniceRepository = new StavkaOtpremniceRepository();

        internal void UpdateOsnovnoSredstvo(OsnovnoSredstvo novoOS)
        {
            osnovnoSredstvoRepository.UpdateOsnovnoSredstvo(novoOS);
        }

        private TipOsRepository tipOsRepository = new TipOsRepository();

        internal void UpdateTipOsnovnogSredstva(TipOsnovnogSredstva tipOs)
        {
            tipOsRepository.UpdateTipOs(tipOs);
        }
        #endregion

        internal List<TipOsnovnogSredstva> GetTipoviOS()
        {
            return tipOsRepository.GetTipovi();
        }

       

        internal List<NacinIsporuke> GetNacinIsporuke()
        {
            return nacinisporukeRepository.GetNaciniIsporuke();
        }

        private ZaposleniRepository zaposleniRepository = new ZaposleniRepository();

        internal void AddStavkaOtpremnice(StavkaOtpremnice stavka)
        {
            stavkaOtpremniceRepository.AddStavkaOtpremnice(stavka);
        }

        internal void DeleteTip(int idTipaOs)
        {
            tipOsRepository.DeleteTipOs(idTipaOs);
        }

        internal void DeleteOsnovnoSredstvo(int iDOsnovnogSredstva)
        {
            osnovnoSredstvoRepository.DeleteOsnovnoSredstvo(iDOsnovnogSredstva);
        }

       

        internal List<Otpremnica> GetOtpremnice()
        {
            return otpremnicaRepository.GetOtpremnice();
        }

       
        internal void AddOtpremnica(Otpremnica otpremnica)
        {
            otpremnicaRepository.AddOtpremnica(otpremnica);
        }

        internal void DeleteStavkaOtpremnice(int brOtpremnice, int rbStavke)
        {
            stavkaOtpremniceRepository.DeleteStavkaOtpremnice(brOtpremnice, rbStavke);
        }

        internal void AddDobavljac(Dobavljac dobavljac)
        {
            dobavljacRepository.AddDobavljac(dobavljac);
        }

        public static Controller Instance
        {
            get
            {
                if (instance == null)
                    instance = new Controller();
                return instance;
            }
        }

        internal void UpdateOtpremnica(Otpremnica novaOtpremnica)
        {
            otpremnicaRepository.UpdateOtpremnica(novaOtpremnica);
        }

        internal void UpdateStavkaOtpremnice(StavkaOtpremnice stavka)
        {
            stavkaOtpremniceRepository.UpdateStavkaOtpremnice(stavka);
        }

        internal List<Narudzbenica> GetNarudzbenice()
        {
            return narudzbenicaRepository.GetNarudzenice();
        }

        internal Zaposleni GetZaposleniDetalji(Zaposleni zaposleni)
        {
            return zaposleniRepository.GetZaposleniDetalji(zaposleni);
        }

        internal void DeleteOtpremnica(int brOtpremnice)
        {
            otpremnicaRepository.DeleteOtpremnica(brOtpremnice);
        }

        internal List<StavkaOtpremnice> GetStavkeOtpremnice()
        {
            return stavkaOtpremniceRepository.GetStavkeOtpremnice();
        }

        internal void UpdateStavkaRacuna(StavkaRacuna stavka)
        {
            stavkaRacunaRepository.UpdateStavkaRacuna(stavka);
        }

        internal int GetCountRacuni(int brojParticije)
        {
            return racunRepository.GetCountRacuniPoGodini(brojParticije);
        }

        internal object GetZaposleni()
        {
            return zaposleniRepository.GetZaposleni();
        }

        internal void UpdateRacun(Racun noviRacun)
        {
            racunRepository.UpdateRacun(noviRacun);
        }

        internal object GetDobavljaci()
        {
            return dobavljacRepository.GetDobavljaci();
        }

    

        internal List<OsnovnoSredstvo> GetOsnovnaSredstva()
        {
            return osnovnoSredstvoRepository.GetOsnovnaSredstva();
        }

        internal void AddStavkaRacuna(StavkaRacuna stavka)
        {
            stavkaRacunaRepository.AddStavkaRacuna(stavka);
        }

        internal void AddRacun(Racun racun)
        {
            racunRepository.AddRacun(racun);
        }

        public List<StavkaRacuna> GetStavkeRacuna(int brRacuna)
        {
            return stavkaRacunaRepository.GetStavke(brRacuna);
        }

        public List<Racun> GetRacuni()
        {
            return racunRepository.GetRacuni();
        }

        internal void DeleteRacun(int brRacuna)
        {
            racunRepository.DeleteRacun(brRacuna);
        }

        internal void DeleteStavkaRacuna(int brRacuna, int rbStavke)
        {
            stavkaRacunaRepository.DeleteStavka(brRacuna, rbStavke);
        }
    }
}
