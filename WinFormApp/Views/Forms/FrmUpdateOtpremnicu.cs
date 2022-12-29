using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApp.Controllers;
using WinFormApp.Models;

namespace WinFormApp.Views.Forms
{
    public partial class FrmUpdateOtpremnicu : Form
    {
        public Otpremnica Otpremnica { get; set; }
        public FrmUpdateOtpremnicu(Otpremnica otpremnica)
        {
            InitializeComponent();
            Otpremnica = otpremnica;
            cbDobavljac.DataSource = Controller.Instance.GetDobavljaci();
            cbDobavljac.SelectedItem = otpremnica.Dobavljac;
            cbNarudzbenica.DataSource = Controller.Instance.GetNarudzbenice();
            cbNarudzbenica.SelectedItem = otpremnica.Narudzbenica;
            cbZaposleni.DataSource = Controller.Instance.GetZaposleni();
            cbZaposleni.SelectedItem = otpremnica.Zaposleni;
            cbNacinIsporuke.DataSource = Controller.Instance.GetNacinIsporuke();
            cbNacinIsporuke.SelectedItem = otpremnica.NacinIsporuke;
            dateDatumIzdavanja.Value = otpremnica.DatumIzdavanja;
        }

        private void btnDodajOtpremnicu_Click(object sender, EventArgs e)
        {
            Otpremnica novaOtpremnica = new Otpremnica();
            novaOtpremnica.BrOtpremnice = Otpremnica.BrOtpremnice;
            novaOtpremnica.DatumIzdavanja = dateDatumIzdavanja.Value;
            novaOtpremnica.Dobavljac = (Dobavljac)cbDobavljac.SelectedItem;
            novaOtpremnica.Zaposleni = (Zaposleni)cbZaposleni.SelectedItem;
            novaOtpremnica.Narudzbenica = (Narudzbenica)cbNarudzbenica.SelectedItem;
            novaOtpremnica.NacinIsporuke = (NacinIsporuke)cbNacinIsporuke.SelectedItem;
            Controller.Instance.UpdateOtpremnica(novaOtpremnica);
            MessageBox.Show("Otpremnica je uspesno izmenjena");
            this.Dispose();
        }
    }
}
