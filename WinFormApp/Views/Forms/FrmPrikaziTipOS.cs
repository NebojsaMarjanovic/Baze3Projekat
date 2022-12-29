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
    public partial class FrmPrikaziTipOS : Form
    {
        private int operacija;
        private TipOsnovnogSredstva tip;
        public FrmPrikaziTipOS()
        {
            InitializeComponent();
            lblAddupdate.Visible = false;
            txtNaziv.Visible = false;
            btnPotrvdi.Visible = false;
            cbTipOS.DataSource = Controller.Instance.GetTipoviOS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblAddupdate.Visible = true;
            txtNaziv.Visible = true;
            btnPotrvdi.Visible = true;
            operacija = 1;
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            tip = (TipOsnovnogSredstva)cbTipOS.SelectedItem;
            lblAddupdate.Visible = true;
            txtNaziv.Visible = true;
            btnPotrvdi.Visible = true;
            operacija = 2;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tip = (TipOsnovnogSredstva)cbTipOS.SelectedItem;
            Controller.Instance.DeleteTip(tip.IDTipaOS);
            MessageBox.Show("Uspesno ste obrisali tip");
            cbTipOS.DataSource = Controller.Instance.GetTipoviOS();
        }

        private void Potvrdi(int operacija)
        {
            switch (operacija)
            {
                case 1:
                    AddTip();
                    break;
                case 2:
                    UpdateTip();
                    break;
            }
            cbTipOS.DataSource = Controller.Instance.GetTipoviOS();
        }

        private void AddTip()
        {
            TipOsnovnogSredstva tipOS = new TipOsnovnogSredstva()
            {
                NazivTipaOS = txtNaziv.Text
            };
            Controller.Instance.AddTipOsnovnogSredstva(tipOS);
            MessageBox.Show("Uspesno ste dodali novi tip");
            lblAddupdate.Visible = false;
            txtNaziv.Visible = false;
            btnPotrvdi.Visible = false;
            cbTipOS.DataSource = Controller.Instance.GetTipoviOS();

        }

        private void UpdateTip()
        {
            TipOsnovnogSredstva tipOs = new TipOsnovnogSredstva()
            {
                IDTipaOS = tip.IDTipaOS,
                NazivTipaOS = txtNaziv.Text
            };
            Controller.Instance.UpdateTipOsnovnogSredstva(tipOs);
            MessageBox.Show("Uspesno ste izmenili tip");
            lblAddupdate.Visible = false;
            txtNaziv.Visible = false;
            btnPotrvdi.Visible = false;
            cbTipOS.DataSource = Controller.Instance.GetTipoviOS();
        }

       

        private void btnPotrvdi_Click(object sender, EventArgs e)
        {
            Potvrdi(operacija);
        }
    }
}
