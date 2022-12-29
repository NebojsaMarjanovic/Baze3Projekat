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
    public partial class UCAddDobavljac : UserControl
    {
        public UCAddDobavljac()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Dobavljac dobavljac = new Dobavljac()
            {
                Naziv = txtNaziv.Text,
                BrojTelefona = txtBrojTelefona.Text,
                PIB = int.Parse(txtPIB.Text)
            };

            try
            {
                Controller.Instance.AddDobavljac(dobavljac);
                MessageBox.Show("Uspesno ste dodali dobavljaca");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
