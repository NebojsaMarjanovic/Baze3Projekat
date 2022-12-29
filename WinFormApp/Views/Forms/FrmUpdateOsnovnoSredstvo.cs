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
    public partial class FrmUpdateOsnovnoSredstvo : Form
    {
        OsnovnoSredstvo osnovnoSredstvo;
        public FrmUpdateOsnovnoSredstvo(OsnovnoSredstvo os)
        {
            InitializeComponent();
            osnovnoSredstvo = os;
            cbTipOS.DataSource = Controller.Instance.GetTipoviOS();
            cbTipOS.SelectedItem = os.TipOsnovnogSredstva;
            txtJM.Text = os.JedinicaMere;
            txtNaziv.Text = os.NazivOsnovnogSredstva;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            OsnovnoSredstvo novoOS = new OsnovnoSredstvo();
            novoOS.IDOsnovnogSredstva = osnovnoSredstvo.IDOsnovnogSredstva;
            novoOS.JedinicaMere = txtJM.Text;
            novoOS.TipOsnovnogSredstva = (TipOsnovnogSredstva)cbTipOS.SelectedItem;
            novoOS.NazivOsnovnogSredstva = txtNaziv.Text;

            Controller.Instance.UpdateOsnovnoSredstvo(novoOS);
            MessageBox.Show($"Uspesno ste izmenili osnovno sredstvo: {novoOS.NazivOsnovnogSredstva}");
            this.Dispose();
        }
    }
}
