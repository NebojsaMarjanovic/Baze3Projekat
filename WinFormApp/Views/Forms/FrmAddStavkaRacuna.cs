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
    public partial class FrmAddStavkaRacuna : Form
    {
        public StavkaRacuna StavkaRacuna { get; set; } = new StavkaRacuna();
        public FrmAddStavkaRacuna()
        {
            InitializeComponent();
            cbOsnovnoSredstvo.DataSource = Controller.Instance.GetOsnovnaSredstva();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            StavkaRacuna.OsnovnoSredstvo = (OsnovnoSredstvo) cbOsnovnoSredstvo.SelectedItem;
            StavkaRacuna.Cena = double.Parse(txtCena.Text);
            StavkaRacuna.Kolicina = int.Parse(txtKolicina.Text);
            Controller.Instance.AddStavkaRacuna(StavkaRacuna);
            this.Dispose();
        }
    }
}
