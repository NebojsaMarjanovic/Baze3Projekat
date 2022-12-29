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
    public partial class UCPrikaziZaposlene : UserControl
    {
        public UCPrikaziZaposlene()
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
            txtBrojTelefona.Visible = false;
            txtDatumZaposlenja.Visible = false;

            dgvZaposleni.DataSource = Controller.Instance.GetZaposleni();
            dgvZaposleni.Columns[2].Visible = false;
            dgvZaposleni.Columns[3].Visible = false;


        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {

            if (dgvZaposleni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite zaposlenog!");
                return;
            }
            Zaposleni zaposleni = (Zaposleni) dgvZaposleni.SelectedRows[0].DataBoundItem;
            label1.Visible = true;
            label2.Visible = true;
            txtBrojTelefona.Visible = true;
            txtDatumZaposlenja.Visible = true;

            zaposleni = Controller.Instance.GetZaposleniDetalji(zaposleni);

            txtBrojTelefona.Text = zaposleni.BrojTelefona;
            txtDatumZaposlenja.Text = zaposleni.DatumZaposlenja.ToString("dd.MM.yyyy.");
        }
    }
}
