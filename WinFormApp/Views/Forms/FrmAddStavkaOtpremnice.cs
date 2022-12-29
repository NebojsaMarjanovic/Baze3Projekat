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
    public partial class FrmAddStavkaOtpremnice : Form
    {
        public FrmAddStavkaOtpremnice()
        {
            InitializeComponent();
            cbOtpremnica.DataSource = Controller.Instance.GetOtpremnice();
            cbOsnovnoSredstvo.DataSource = Controller.Instance.GetOsnovnaSredstva();
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            StavkaOtpremnice stavka = new StavkaOtpremnice();
            stavka.BrOtpremnice = ((Otpremnica)cbOtpremnica.SelectedItem).BrOtpremnice;
            stavka.Kolicina=int.Parse(txtKolicina.Text);
            stavka.DatumIzdavanja = dateDatumIzdavanja.Value;
            stavka.OsnovnoSredstvo = (OsnovnoSredstvo)cbOsnovnoSredstvo.SelectedItem;

            Controller.Instance.AddStavkaOtpremnice(stavka);
            MessageBox.Show("Uspesno ste dodali novu stavku otpremnice!");
            this.Dispose();

        }
    }
}
