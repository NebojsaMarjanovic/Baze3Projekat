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
    public partial class FrmAddOtpremnica : Form
    {
        public FrmAddOtpremnica()
        {
            InitializeComponent();
            cbDobavljac.DataSource = Controller.Instance.GetDobavljaci();
            cbNarudzbenica.DataSource = Controller.Instance.GetNarudzbenice();
            cbZaposleni.DataSource = Controller.Instance.GetZaposleni();
            cbNacinIsporuke.DataSource = Controller.Instance.GetNacinIsporuke();

        }

        private void btnDodajOtpremnicu_Click(object sender, EventArgs e)
        {
            Otpremnica otpremnica = new Otpremnica()
            {
                BrOtpremnice = int.Parse(txtBrOtpremnice.Text),
                DatumIzdavanja = dateDatumIzdavanja.Value,
                Zaposleni = (Zaposleni)cbZaposleni.SelectedItem,
                Dobavljac = (Dobavljac)cbDobavljac.SelectedItem,
                Narudzbenica = (Narudzbenica)cbNarudzbenica.SelectedItem,
                NacinIsporuke = (NacinIsporuke)cbNacinIsporuke.SelectedItem
            };

            Controller.Instance.AddOtpremnica(otpremnica);
            MessageBox.Show("Uspesno ste dodali otpremnicu!");
            this.Dispose();
        }
    }
}
