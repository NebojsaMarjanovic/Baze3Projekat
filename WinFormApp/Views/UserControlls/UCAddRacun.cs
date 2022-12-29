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

namespace WinFormApp.Views.UserControlls
{
    public partial class UCAddRacun : UserControl
    {
        public UCAddRacun()
        {
            InitializeComponent();
            cbNarudzbenica.DataSource = Controller.Instance.GetNarudzbenice();
            cbZaposleni.DataSource = Controller.Instance.GetZaposleni();
            cbDobavljac.DataSource = Controller.Instance.GetDobavljaci();
        }

        private void btnDodajRacun_Click(object sender, EventArgs e)
        {
            Racun racun = new Racun();
            racun.BrRacuna = int.Parse(txtBrojRacuna.Text);
            racun.Placanje = new Placanje(double.Parse(txtIznos.Text), int.Parse(txtBrojRata.Text));
            racun.DatumIzdavanja = dateDatumIzdavanja.Value;
            racun.Napomena = rtbNapomena.Text;
            racun.Narudzbenica = (Narudzbenica)cbNarudzbenica.SelectedItem;
            racun.Zaposleni=(Zaposleni)cbZaposleni.SelectedItem;
            racun.Dobavljac = (Dobavljac)cbDobavljac.SelectedItem;

            Controller.Instance.AddRacun(racun);
            MessageBox.Show("Racun je uspesno dodat!");
        }

       
    }
}
