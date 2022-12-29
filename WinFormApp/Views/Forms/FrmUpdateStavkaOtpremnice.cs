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
    public partial class FrmUpdateStavkaOtpremnice : Form
    {
        public StavkaOtpremnice Stavka { get; set; }
        public FrmUpdateStavkaOtpremnice(StavkaOtpremnice stavka)
        {
            InitializeComponent();
            Stavka = stavka;
            cbOsnovnoSredstvo.DataSource = Controller.Instance.GetOsnovnaSredstva();
            cbOsnovnoSredstvo.SelectedItem = stavka.OsnovnoSredstvo;
            txtKolicina.Text = stavka.Kolicina.ToString();
            dateDatumIzdavanja.Value = stavka.DatumIzdavanja;
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            StavkaOtpremnice novaStavka = new StavkaOtpremnice();
            novaStavka.BrOtpremnice = Stavka.BrOtpremnice;
            novaStavka.RbStavke = Stavka.RbStavke;
            novaStavka.Kolicina = int.Parse(txtKolicina.Text);
            novaStavka.DatumIzdavanja = dateDatumIzdavanja.Value;
            novaStavka.OsnovnoSredstvo = (OsnovnoSredstvo)cbOsnovnoSredstvo.SelectedItem;
            try
            {

                Controller.Instance.UpdateStavkaOtpremnice(novaStavka);
                MessageBox.Show($"Uspesno ste izmenili stavku broj: {novaStavka.RbStavke} otpremnice broj:{novaStavka.BrOtpremnice}");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
