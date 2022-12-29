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
    public partial class FrmUpdateRacun : Form
    {
        private Racun noviRacun = new Racun();
        public FrmUpdateRacun(Racun racun)
        {
            InitializeComponent();

            noviRacun.BrRacuna = racun.BrRacuna;

            txtIznos.Text=racun.Placanje.Iznos.ToString();
            txtBrojRata.Text=racun.Placanje.BrojRata.ToString();
            dateDatumIzdavanja.Value = racun.DatumIzdavanja;
            rtbNapomena.Text = racun.Napomena;
            cbNarudzbenica.DataSource = Controller.Instance.GetNarudzbenice();
            cbNarudzbenica.SelectedItem = racun.Narudzbenica;
            cbZaposleni.DataSource = Controller.Instance.GetZaposleni();
            cbZaposleni.SelectedItem = racun.Zaposleni;
            cbDobavljac.DataSource = Controller.Instance.GetDobavljaci();
            cbDobavljac.SelectedItem = racun.Dobavljac;

        }

        private void btnIzmeniRacun_Click(object sender, EventArgs e)
        {
            noviRacun.Placanje = new Placanje(double.Parse(txtIznos.Text),int.Parse(txtBrojRata.Text));
            noviRacun.DatumIzdavanja = dateDatumIzdavanja.Value;
            noviRacun.Napomena = rtbNapomena.Text;
            noviRacun.Narudzbenica = (Narudzbenica)cbNarudzbenica.SelectedItem;
            noviRacun.Zaposleni = (Zaposleni)cbZaposleni.SelectedItem;
            noviRacun.Dobavljac=(Dobavljac)cbDobavljac.SelectedItem;

            try
            {
                Controller.Instance.UpdateRacun(noviRacun);
                MessageBox.Show("Račun je uspešno izmenjen");
                this.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
