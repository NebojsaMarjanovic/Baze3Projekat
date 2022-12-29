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
    public partial class FrmUpdateStavkaRacuna : Form
    {
        public StavkaRacuna stavka { get; set; }
        public FrmUpdateStavkaRacuna(StavkaRacuna stavka)
        {
            InitializeComponent();
            this.stavka = stavka;
            cbOsnovnoSredstvo.DataSource = Controller.Instance.GetOsnovnaSredstva();
            cbOsnovnoSredstvo.SelectedItem = stavka.OsnovnoSredstvo;
            txtCena.Text = stavka.Cena.ToString();
            txtKolicina.Text = stavka.Kolicina.ToString();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            stavka.OsnovnoSredstvo = (OsnovnoSredstvo)cbOsnovnoSredstvo.SelectedItem;
            stavka.Cena = double.Parse(txtCena.Text);
            stavka.Kolicina = int.Parse(txtKolicina.Text);
           
            Controller.Instance.UpdateStavkaRacuna(stavka);
            this.Dispose();
        }
    }
}
