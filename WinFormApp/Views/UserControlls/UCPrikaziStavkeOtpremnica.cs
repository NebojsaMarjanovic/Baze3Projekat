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
using WinFormApp.Views.Forms;

namespace WinFormApp.Views.UserControlls
{
    public partial class UCPrikaziStavkeOtpremnica : UserControl
    {
        private BindingList<StavkaOtpremnice> stavkeOtpremnice;
        private StavkaOtpremnice stavka;
        public UCPrikaziStavkeOtpremnica()
        {
            InitializeComponent(); 
            stavkeOtpremnice = new BindingList<StavkaOtpremnice>(Controller.Instance.GetStavkeOtpremnice());
            dgvStavke.DataSource = stavkeOtpremnice;
            dgvStavke.Columns[1].Visible = false;

        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            FrmAddStavkaOtpremnice frmAddStavkaOtpremnice = new FrmAddStavkaOtpremnice();
            frmAddStavkaOtpremnice.ShowDialog();
            stavkeOtpremnice = new BindingList<StavkaOtpremnice>(Controller.Instance.GetStavkeOtpremnice());
            dgvStavke.DataSource = stavkeOtpremnice;
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            if (dgvStavke.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite stavku otpremnice!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            stavka = (StavkaOtpremnice)dgvStavke.SelectedRows[0].DataBoundItem;
            Controller.Instance.DeleteStavkaOtpremnice(stavka.BrOtpremnice, stavka.RbStavke);
            MessageBox.Show($"Uspesno ste obrisali stavku otpremnice za otpremnicu broj: {stavka.BrOtpremnice}!");
            stavkeOtpremnice = new BindingList<StavkaOtpremnice>(Controller.Instance.GetStavkeOtpremnice());
            dgvStavke.DataSource = stavkeOtpremnice;
        }

        private void btnIzmeniStavku_Click(object sender, EventArgs e)
        {
            if (dgvStavke.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite stavku otpremnice!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            stavka = (StavkaOtpremnice)dgvStavke.SelectedRows[0].DataBoundItem;
            FrmUpdateStavkaOtpremnice frmUpdateStavkaOtpremnice = new FrmUpdateStavkaOtpremnice(stavka);
            frmUpdateStavkaOtpremnice.ShowDialog();
            stavkeOtpremnice = new BindingList<StavkaOtpremnice>(Controller.Instance.GetStavkeOtpremnice());
            dgvStavke.DataSource=stavkeOtpremnice;
        }
    }
}
