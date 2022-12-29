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
    public partial class UCPrikaziOtpremnice : UserControl
    {
        private BindingList<Otpremnica> otpremnice;
        private Otpremnica otpremnica;

        public UCPrikaziOtpremnice()
        {
            InitializeComponent();
            otpremnice = new BindingList<Otpremnica>(Controller.Instance.GetOtpremnice());
            dgvOtpremnice.DataSource = otpremnice;
            Thread nitOsvezi = new Thread(OsveziPrikaz);
            nitOsvezi.Start();
        }

        private void OsveziPrikaz(object? obj)
        {
            while (true)
            {
                if (Application.OpenForms.Count == 0)
                {
                    Application.Exit();
                    break;
                }
                otpremnice = new BindingList<Otpremnica>(Controller.Instance.GetOtpremnice());

                this.Invoke(new Action(() =>
                {
                    dgvOtpremnice.DataSource = otpremnice;

                }));
                Thread.Sleep(3000);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmAddOtpremnica frmAddOtpremnicu = new FrmAddOtpremnica();
            frmAddOtpremnicu.ShowDialog();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if(dgvOtpremnice.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite otpremnicu", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            otpremnica = (Otpremnica)dgvOtpremnice.SelectedRows[0].DataBoundItem;
            FrmUpdateOtpremnicu frmUpdateOtpremnicu = new FrmUpdateOtpremnicu(otpremnica);
            frmUpdateOtpremnicu.ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvOtpremnice.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite otpremnicu", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            otpremnica = (Otpremnica)dgvOtpremnice.SelectedRows[0].DataBoundItem;
            Controller.Instance.DeleteOtpremnica(otpremnica.BrOtpremnice);
            MessageBox.Show("Uspesno ste obrisali otpremnicu!");
        }
    }
}
