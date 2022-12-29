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
    public partial class UCPrikaziOsnovnaSredstva : UserControl
    {
        private OsnovnoSredstvo os;
        private List<OsnovnoSredstvo> osList;
        public UCPrikaziOsnovnaSredstva()
        {
            InitializeComponent();
            osList = Controller.Instance.GetOsnovnaSredstva();
            dgvOsnvnoSredstvo.DataSource = osList;
            dgvOsnvnoSredstvo.Columns[0].Visible = false;
            dgvOsnvnoSredstvo.Columns[4].Visible = false;
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
                     osList = Controller.Instance.GetOsnovnaSredstva();

                this.Invoke(new Action(() =>
                {
                    dgvOsnvnoSredstvo.DataSource = osList;

                }));
                Thread.Sleep(3000);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvOsnvnoSredstvo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite osnovno sredstvo", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            os = (OsnovnoSredstvo)dgvOsnvnoSredstvo.SelectedRows[0].DataBoundItem;
            Controller.Instance.DeleteOsnovnoSredstvo(os.IDOsnovnogSredstva);
            MessageBox.Show("Uspesno ste obrisali osnovno sredstvo!");
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            FrmAddOsnovnoSredstvo frmAddOsnovnoSredstvo = new FrmAddOsnovnoSredstvo();
            frmAddOsnovnoSredstvo.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvOsnvnoSredstvo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite osnovno sredstvo", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            os = (OsnovnoSredstvo)dgvOsnvnoSredstvo.SelectedRows[0].DataBoundItem;
            FrmUpdateOsnovnoSredstvo frmUpdateOsnovnoSredstvo = new FrmUpdateOsnovnoSredstvo(os);
            frmUpdateOsnovnoSredstvo.ShowDialog();

        }
    }
}
