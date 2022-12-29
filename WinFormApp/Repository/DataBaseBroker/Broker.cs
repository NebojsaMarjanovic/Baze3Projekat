using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WinFormApp.Models;

namespace WinFormApp.Repository.DataBaseBroker
{
    internal class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;


        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Baze3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        internal List<TipOsnovnogSredstva> GetTipoviOS()
        {
            List<TipOsnovnogSredstva> tipovi = new List<TipOsnovnogSredstva>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "select * from TipOsnovnogSredstva";
            using(SqlDataReader reader = command.ExecuteReader())
                while (reader.Read())
                {
                    TipOsnovnogSredstva tip = new TipOsnovnogSredstva()
                    {
                        IDTipaOS = (int)reader[0],
                        NazivTipaOS = (string)reader[1]
                    };
                    tipovi.Add(tip);
                }
            return tipovi;
        }

        internal void DeleteTipOs(int idTipaOs)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"delete from TipOsnovnogSredstva where IDTipaOS={idTipaOs}";
            command.ExecuteNonQuery();
        }

        internal void UpdateTipOs(TipOsnovnogSredstva tipOS)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"update TipOsnovnogSredstva set NazivTipaOS='{tipOS.NazivTipaOS}' where IDTipaOS={tipOS.IDTipaOS}";
            command.ExecuteNonQuery();
        }

        internal void AddTipOS(TipOsnovnogSredstva tipOS)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"insert into TipOsnovnogSredstva values ('{tipOS.NazivTipaOS}')";
            command.ExecuteReader();
        }

        internal void UpdateOsnovnoSredstvo(OsnovnoSredstvo novoOS)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"update OsnovnoSredstvo set NazivOsnovnogSredstva='{novoOS.NazivOsnovnogSredstva}', " +
                $"JedinicaMere='{novoOS.JedinicaMere}', IDTipaOS={novoOS.TipOsnovnogSredstva.IDTipaOS} where IDOsnovnogSredstva = {novoOS.IDOsnovnogSredstva}";
            command.ExecuteNonQuery();
        }

        internal void AddOsnovnoSredstvo(OsnovnoSredstvo os)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"insert into OsnovnoSredstvo (NazivOsnovnogSredstva, JedinicaMere, IDTipaOS) values " +
                $"(@NazivOS, @JM, @IDTipaOS)";
            command.Parameters.AddWithValue("@NazivOS", os.NazivTipaOS);
            command.Parameters.AddWithValue("@JM", os.JedinicaMere);
            command.Parameters.AddWithValue("@IDTipaOS", os.TipOsnovnogSredstva.IDTipaOS);
            command.ExecuteNonQuery();
        }

        internal List<NacinIsporuke> GetNacinIsporuke()
        {
            List<NacinIsporuke> nacini = new List<NacinIsporuke>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "select * from NacinIsporuke";
            using (SqlDataReader reader = command.ExecuteReader())
                while (reader.Read()) {
                    NacinIsporuke nacin = new NacinIsporuke()
                    {
                        IDNacinaIsporuke = (int)reader[0],
                        NazivNacinaIsporuke = (string)reader[1]
                    };
                    nacini.Add(nacin);
            }
            return nacini;
        }

        internal void DeleteOsnovnoSredstvo(int iDOsnovnogSredstva)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"delete from OsnovnoSredstvo where IDOsnovnogSredstva={iDOsnovnogSredstva}";
            command.ExecuteNonQuery();
        }

        internal void UpdateStavkaOtpremnice(StavkaOtpremnice stavka)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"update StavkaOtpremnice set Kolicina={stavka.Kolicina}, DatumIzdavanja='{stavka.DatumIzdavanja.ToString("yyyy-MM-dd")}', " +
                $"IDOsnovnogSredstva={stavka.OsnovnoSredstvo.IDOsnovnogSredstva} where BrOtpremnice={stavka.BrOtpremnice} and RbStavke={stavka.RbStavke}";
            command.ExecuteNonQuery();
        }

        internal void DeleteStavkaOtpremnice(int brOtpremnice, int rbStavke)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"delete from StavkaOtpremnice where BrOtpremnice={brOtpremnice} and RbStavke={rbStavke}";
            command.ExecuteNonQuery();
        }

        internal void AddStavkaOtpremnice(StavkaOtpremnice stavka)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "insert into StavkaOtpremnice values (@BrO, @Kolicina, @Datum, @IDOS)";
            command.Parameters.AddWithValue("@BrO", stavka.BrOtpremnice);
            command.Parameters.AddWithValue("@Kolicina", stavka.Kolicina);
            command.Parameters.AddWithValue("@Datum", stavka.DatumIzdavanja);
            command.Parameters.AddWithValue("@IDOS", stavka.OsnovnoSredstvo.IDOsnovnogSredstva);

            command.ExecuteNonQuery();
        }

        internal void DeleteOtpremnica(int brOtpremnice)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"delete from Otpremnica where BrOtpremnice = {brOtpremnice}";
            command.ExecuteNonQuery();
        }

        internal void UpdateOtpremnica(Otpremnica otpremnica)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"update Otpremnica set DatumIzdavanja = '{otpremnica.DatumIzdavanja.ToString("yyyy-MM-dd")}', " +
                $"IDNarudzbenice = {otpremnica.Narudzbenica.IDNarudzbenice}, " +
                $"IDZaposlenog = {otpremnica.Zaposleni.IDZaposlenog}, " +
                $"IDDobavljaca = {otpremnica.Dobavljac.IDDobavljaca}, " +
                $"IDNacinaIsporuke = {otpremnica.NacinIsporuke.IDNacinaIsporuke} " +
                $"where BrOtpremnice={otpremnica.BrOtpremnice}";
            command.ExecuteNonQuery();
        }

        internal List<StavkaOtpremnice> GetStavkeOtpremnice()
        {
            List<StavkaOtpremnice> stavke = new List<StavkaOtpremnice>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"select * from StavkaOtpremnice " +
                $"inner join OsnovnoSredstvo on StavkaOtpremnice.IDOsnovnogSredstva=OsnovnoSredstvo.IDOsnovnogSredstva";
            using (SqlDataReader reader = command.ExecuteReader())
                while (reader.Read())
                {
                    StavkaOtpremnice stavka = new StavkaOtpremnice();
                    stavka.BrOtpremnice = (int)reader[0];
                    stavka.RbStavke = (int)reader[1];
                    stavka.Kolicina= (int)reader[2];
                    stavka.DatumIzdavanja = (DateTime)reader[3];
                    stavka.OsnovnoSredstvo = new OsnovnoSredstvo()
                    {
                        IDOsnovnogSredstva = (int)reader[5],
                        NazivOsnovnogSredstva = (string)reader[6],
                        JedinicaMere = (string)reader[8]
                    };

                    stavke.Add(stavka);
                }
            return stavke;
        }

        internal void AddOtpremnica(Otpremnica otpremnica)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"insert into otpremnica values (@BrOtpremnice, @Datum, @IDN,@IDZ,@IDD, @IDNI)";
            command.Parameters.AddWithValue("@BrOtpremnice", otpremnica.BrOtpremnice);
            command.Parameters.AddWithValue("@Datum", otpremnica.DatumIzdavanja);
            command.Parameters.AddWithValue("@IDN", otpremnica.Narudzbenica.IDNarudzbenice);
            command.Parameters.AddWithValue("@IDZ", otpremnica.Zaposleni.IDZaposlenog);
            command.Parameters.AddWithValue("@IDD", otpremnica.Dobavljac.IDDobavljaca);
            command.Parameters.AddWithValue("@IDNI", otpremnica.NacinIsporuke.IDNacinaIsporuke);

            command.ExecuteNonQuery();
        }

        internal List<Otpremnica> GetOtpremnice()
        {
            List<Otpremnica> otpremnice = new List<Otpremnica>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "select * from Otpremnica" +
                " inner join Narudzbenica on Otpremnica.IDNarudzbenice=Narudzbenica.IDNarudzbenice " +
                "inner join ZaposleniPodaci on otpremnica.IDZaposlenog=ZaposleniPodaci.IDZaposlenog " +
                "inner join Dobavljac on otpremnica.IDDobavljaca=Dobavljac.IDDobavljaca " +
                "inner join NacinIsporuke on otpremnica.IDNacinaIsporuke=NacinIsporuke.IDNacinaIsporuke";
            using(SqlDataReader reader = command.ExecuteReader())
                while (reader.Read())
                {
                    Otpremnica otpremnica = new Otpremnica();
                    otpremnica.BrOtpremnice = (int)reader[0];
                    otpremnica.DatumIzdavanja = (DateTime)reader[1];
                    otpremnica.Narudzbenica = new Narudzbenica()
                    {
                        IDNarudzbenice = (int)reader[6],
                    };
                    otpremnica.Zaposleni = new Zaposleni()
                    {
                        IDZaposlenog = (int)reader[12],
                        ImePrezime = (string)reader[13]
                    };
                    otpremnica.Dobavljac = new Dobavljac()
                    {
                        IDDobavljaca = (int)reader[15],
                        Naziv = (string)reader[16]
                    };
                    otpremnica.NacinIsporuke = new NacinIsporuke()
                    {
                        IDNacinaIsporuke = (int)reader[19],
                        NazivNacinaIsporuke = (string)reader[20]
                    };

                    otpremnice.Add(otpremnica);
                }
            return otpremnice;

        }

        internal List<Zaposleni> GetZaposleni()
        {
            List<Zaposleni> zaposleniList = new List<Zaposleni>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "select * from ZaposleniPodaci inner join RadnoMesto on ZaposleniPodaci.IDRadnogMesta=RadnoMesto.IDRadnogMesta";
            using (SqlDataReader reader = command.ExecuteReader())
                while (reader.Read())
                {
                    Zaposleni zaposleni = new Zaposleni();
                    zaposleni.IDZaposlenog = (int)reader[0];
                    zaposleni.ImePrezime = (string)reader[1];
                    zaposleni.RadnoMesto = new RadnoMesto()
                    {
                        IDRadnogMesta = (int)reader[3],
                        NazivRadnogMesta=(string)reader[4]
                    };

                    zaposleniList.Add(zaposleni);
                }
            return zaposleniList;
        }

        internal void AddDobavljac(Dobavljac dobavljac)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "insert into Dobavljac values (@Naziv,@BrTelefona,@PIB)";
            command.Parameters.AddWithValue("@Naziv", dobavljac.Naziv);
            command.Parameters.AddWithValue("@BrTelefona", dobavljac.BrojTelefona);
            command.Parameters.AddWithValue("@PIB", dobavljac.PIB);

            command.ExecuteNonQuery();
        }

        internal Zaposleni GetZaposleniDetalji(Zaposleni zaposleni)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"select * from ZaposleniDetalji where IDZaposlenog={zaposleni.IDZaposlenog}";
            using (SqlDataReader reader = command.ExecuteReader())
                while (reader.Read())
                {
                    zaposleni.DatumZaposlenja = (DateTime)reader[1];
                    zaposleni.BrojTelefona=(string)reader[2];
                }
            return zaposleni;
        }

        internal void DeleteStavka(int brRacuna, int rbStavke)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"delete from StavkaRacuna where BrRacuna={brRacuna} and RbStavke={rbStavke}";
            command.ExecuteNonQuery();
        }

        internal void UpdateRacun(Racun racun)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"update Racun set Placanje='{racun.Placanje.Iznos};{racun.Placanje.BrojRata}', DatumIzdavanja='{racun.DatumIzdavanja.ToString("yyyy.MM.dd")}', Napomena='{racun.Napomena}', " +
                $"IDNarudzbenice={racun.Narudzbenica.IDNarudzbenice}, IDZaposlenog={racun.Zaposleni.IDZaposlenog}, IDDobavljaca={racun.Dobavljac.IDDobavljaca} where " +
                $"BrRacuna = {racun.BrRacuna}";
            command.ExecuteNonQuery();
        }

        internal void DeleteRacun(int brRacuna)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"delete from racun where BrRacuna={brRacuna}";
            command.ExecuteNonQuery();
        }

        internal void UpdateStavkaRacuna(StavkaRacuna stavka)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"update Stavkaracuna set Kolicina={stavka.Kolicina}, Cena={stavka.Cena}, IDOsnovnogSredstva={stavka.OsnovnoSredstvo.IDOsnovnogSredstva} " +
                $"where BrRacuna={stavka.BrRacuna} and RbStavke={stavka.RbStavke}";
            command.ExecuteNonQuery();
        }

        internal int GetCountRacuniPoGodini(int brojParticije)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"select count(*) from racun where $PARTITION.DATUMIZDAVANJA_PARTITION_FUNCTION(DatumIzdavanja)={brojParticije}";
            return (int) command.ExecuteScalar();
        }

        internal void AddRacun(Racun racun)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "insert into Racun values (@BrRacuna, @Placanje, @Datum, @Napomena, @IDNar,@IDZap,@IDDob)";
            command.Parameters.AddWithValue("@BrRacuna", racun.BrRacuna);
            command.Parameters.AddWithValue("@Placanje", $"{racun.Placanje.Iznos};{racun.Placanje.BrojRata}");
            command.Parameters.AddWithValue("@Datum", racun.DatumIzdavanja);
            command.Parameters.AddWithValue("@Napomena", racun.Napomena);
            command.Parameters.AddWithValue("@IDNar", racun.Narudzbenica.IDNarudzbenice);
            command.Parameters.AddWithValue("@IDZap", racun.Zaposleni.IDZaposlenog);
            command.Parameters.AddWithValue("@IDDob", racun.Dobavljac.IDDobavljaca);

            command.ExecuteNonQuery();
        }

        internal List<Narudzbenica> GetNarudzbenice()
        {
            List<Narudzbenica> narudzbenice = new List<Narudzbenica>();

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "select * from Narudzbenica";
            using(SqlDataReader reader = command.ExecuteReader())
                while (reader.Read())
                {
                    Narudzbenica narudzbenica = new Narudzbenica();
                    narudzbenica.IDNarudzbenice = (int)reader[0];
                    narudzbenica.DatumIzdavanja = (DateTime)reader[1];
                    narudzbenica.MestoIzdavanja = (string)reader[2];
                    narudzbenica.IDZaposlenog = (int)reader[3];
                    narudzbenica.IDDobavljaca = (int)reader[4];
                    narudzbenica.IDOdlukeONabavci = (int)reader[5];

                    narudzbenice.Add(narudzbenica);
                }
            return narudzbenice;
        }

        internal List<Dobavljac> GetDobavljaci()
        {
            List<Dobavljac> dobavljaci = new List<Dobavljac>();
            SqlCommand command = new SqlCommand("",connection);
            command.CommandText = "select * from Dobavljac";
            using(SqlDataReader reader = command.ExecuteReader())
                while (reader.Read())
                {
                    Dobavljac dobavljac = new Dobavljac();
                    dobavljac.IDDobavljaca = (int)reader[0];
                    dobavljac.Naziv = (string)reader[1];
                    dobavljac.BrojTelefona = (string)reader[2];
                    dobavljac.PIB = (int)reader[3];

                    dobavljaci.Add(dobavljac);
                }
            return dobavljaci;
        }

        internal List<OsnovnoSredstvo> GetOsnovnaSredstva()
        {
            List<OsnovnoSredstvo> osnovnaSredstva = new List<OsnovnoSredstvo>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "select * from OsnovnoSredstvo";
            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    OsnovnoSredstvo osnovnoSredstvo = new OsnovnoSredstvo();
                    osnovnoSredstvo.IDOsnovnogSredstva = (int)reader[0];
                    osnovnoSredstvo.NazivOsnovnogSredstva = (string)reader[1];
                    osnovnoSredstvo.NazivTipaOS = (string)reader[2];
                    osnovnoSredstvo.JedinicaMere = (string)reader[3];
                    osnovnoSredstvo.TipOsnovnogSredstva = new TipOsnovnogSredstva()
                    {
                        IDTipaOS = (int)reader[4]
                    };

                    osnovnaSredstva.Add(osnovnoSredstvo);
                }
            }
            return osnovnaSredstva;
        }

        internal void AddStavkaRacuna(StavkaRacuna stavka)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"insert into StavkaRacuna(BrRacuna, Kolicina, Cena, IDOsnovnogSredstva) values (@BrRacuna,@Kolicina,@Cena,@IDOS)";
            command.Parameters.AddWithValue("@BrRacuna", stavka.BrRacuna);
            command.Parameters.AddWithValue("@Kolicina", stavka.Kolicina);
            command.Parameters.AddWithValue("@Cena", stavka.Cena);
            command.Parameters.AddWithValue("@IDOS", stavka.OsnovnoSredstvo.IDOsnovnogSredstva);

            command.ExecuteNonQuery();

        }

        internal List<Racun> GetRacuni()
        {
            List<Racun> racuni = new List<Racun>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = "select Racun.BrRacuna, Racun.Placanje, Racun.DatumIzdavanja, Racun.Napomena,Dobavljac.Naziv,ZaposleniPodaci.ImePrezime, Narudzbenica.IDNarudzbenice " +
                "from Racun inner join Dobavljac on Racun.IDDobavljaca = Dobavljac.IDDobavljaca " +
                "inner join ZaposleniPodaci on Racun.IDZaposlenog = ZaposleniPodaci.IDZaposlenog " +
                "inner join Narudzbenica on Racun.IDNarudzbenice = Narudzbenica.IDNarudzbenice";
            using (SqlDataReader reader = command.ExecuteReader())
                while (reader.Read())
                {
                    Racun racun = new Racun();
                    racun.BrRacuna = (int)reader[0];
                    racun.Placanje=(Placanje)reader[1];
                    racun.DatumIzdavanja = (DateTime)reader[2];

                    if(reader[3] is DBNull)
                        racun.Napomena = "";
                    else
                        racun.Napomena = (string)reader[3];

                    racun.Dobavljac = new Dobavljac()
                    {
                        Naziv = (string)reader[4]
                    };

                    racun.Zaposleni = new Zaposleni()
                    {
                        ImePrezime = (string)reader[5]
                    };
                    racun.Narudzbenica = new Narudzbenica()
                    {
                        IDNarudzbenice = (int)reader[6]
                    };

                    racuni.Add(racun);
                }
           return racuni;
        }

        internal List<StavkaRacuna> GetStavkeRacuna(int brRacuna)
        {
            List<StavkaRacuna> stavke = new List<StavkaRacuna>();
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"select StavkaRacuna.BrRacuna, StavkaRacuna.RbStavke, OsnovnoSredstvo.NazivOsnovnogSredstva,StavkaRacuna.Kolicina, StavkaRacuna.Cena from StavkaRacuna " +
                $"inner join OsnovnoSredstvo on StavkaRacuna.IDOsnovnogSredstva=OsnovnoSredstvo.IDOsnovnogSredstva where BrRacuna={brRacuna}";
            using(SqlDataReader reader = command.ExecuteReader())
                while (reader.Read())
                {
                    StavkaRacuna stavka = new StavkaRacuna();
                    stavka.BrRacuna = (int)reader[0];
                    stavka.RbStavke = (int)reader[1];
                    stavka.OsnovnoSredstvo = new OsnovnoSredstvo()
                    {
                        NazivOsnovnogSredstva = (string)reader[2]
                    };
                    stavka.Kolicina = (int)reader[3];
                    stavka.Cena = (double)reader[4];

                    stavke.Add(stavka);
                }
            return stavke;
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            if (connection != null && connection.State != ConnectionState.Closed)
                connection.Close();
        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }


    }
}
