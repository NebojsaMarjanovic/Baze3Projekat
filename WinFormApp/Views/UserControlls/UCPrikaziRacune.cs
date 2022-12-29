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
    public partial class UCPrikaziRacune : UserControl
    {
        private BindingList<Racun> racuni;
        private BindingList<StavkaRacuna> stavkeRacuna;
        private Racun racun;
        public UCPrikaziRacune()
        {
            InitializeComponent();
            racuni = new BindingList<Racun>(Controller.Instance.GetRacuni());
            dgvRacuni.DataSource = racuni;
            dgvRacuni.AutoSize = true;
            dgvStavke.AutoSize = true;
            dgvRacuni.Columns[3].Visible = false;
            dgvRacuni.Columns[1].HeaderText = "Iznos;Rata";
            dgvStavke.Visible = false;
            txtRata.Visible = false;
            label1.Visible = false;
            btnDodajStavku.Visible = false;
            btnIzmeniStavku.Visible = false;
            btnObrisiStavku.Visible = false;

            lblPre2020.Text = Controller.Instance.GetCountRacuni(1).ToString();
            lbl2020.Text = Controller.Instance.GetCountRacuni(2).ToString();
            lbl2021.Text = Controller.Instance.GetCountRacuni(3).ToString();
            lbl2022.Text = Controller.Instance.GetCountRacuni(4).ToString();

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

                racuni = new BindingList<Racun>(Controller.Instance.GetRacuni());

                this.Invoke(new Action(() =>
                {
                    dgvRacuni.DataSource = racuni;

                    lblPre2020.Text = Controller.Instance.GetCountRacuni(1).ToString();
                    lbl2020.Text = Controller.Instance.GetCountRacuni(2).ToString();
                    lbl2021.Text = Controller.Instance.GetCountRacuni(3).ToString();
                    lbl2022.Text = Controller.Instance.GetCountRacuni(4).ToString();

                    if (racun!=null)
                        txtRata.Text = Math.Round(racuni.Where(r => r.BrRacuna == racun.BrRacuna).First().Placanje.IzracunajRatu(),2,MidpointRounding.AwayFromZero).ToString();
                }));
                Thread.Sleep(3000);
            }
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            if(dgvRacuni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite račun","Greska",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            dgvStavke.Visible = true;
            txtRata.Visible = true;
            label1.Visible = true;
            btnDodajStavku.Visible = true;
            btnIzmeniStavku.Visible = true;
            btnObrisiStavku.Visible = true;
            racun = (Racun)dgvRacuni.SelectedRows[0].DataBoundItem;
            stavkeRacuna = new BindingList<StavkaRacuna>(Controller.Instance.GetStavkeRacuna(racun.BrRacuna));
            txtRata.Text = Math.Round(racun.Placanje.IzracunajRatu(), 2, MidpointRounding.AwayFromZero).ToString();
            dgvStavke.DataSource = stavkeRacuna;
            dgvStavke.Columns[1].Visible = false;
            //dgvStavke.Columns[2].Visible = false;
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            FrmAddStavkaRacuna frmAddStavkaRacuna = new FrmAddStavkaRacuna();
            frmAddStavkaRacuna.StavkaRacuna.BrRacuna = racun.BrRacuna;
            frmAddStavkaRacuna.ShowDialog();
            stavkeRacuna.Add(frmAddStavkaRacuna.StavkaRacuna);
            //txtRata.Text = Math.Round((decimal)racun.Placanje.IzracunajRatu(), 2, MidpointRounding.AwayFromZero).ToString();
        }

        private void btnIzmeniStavku_Click(object sender, EventArgs e)
        {
            if (dgvStavke.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite stavku računa", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StavkaRacuna stavka = (StavkaRacuna) dgvStavke.SelectedRows[0].DataBoundItem;
            FrmUpdateStavkaRacuna frmUpdateStavkaRacuna = new FrmUpdateStavkaRacuna(stavka);
            frmUpdateStavkaRacuna.ShowDialog();
            stavkeRacuna = new BindingList<StavkaRacuna>(Controller.Instance.GetStavkeRacuna(racun.BrRacuna));
            dgvStavke.DataSource = stavkeRacuna;
        }

        private void btnIzmeniRacun_Click(object sender, EventArgs e)
        {
            if(dgvRacuni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali račun!");
                return;
            }
            Racun racun = (Racun)dgvRacuni.SelectedRows[0].DataBoundItem;
            FrmUpdateRacun frmUpdateRacun = new FrmUpdateRacun(racun);
            frmUpdateRacun.ShowDialog();
            stavkeRacuna = new BindingList<StavkaRacuna>(Controller.Instance.GetStavkeRacuna(racun.BrRacuna));



        }

        private void btnObrisiRacun_Click(object sender, EventArgs e)
        {
            if (dgvRacuni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali račun!");
                return;
            }
            Racun racun = (Racun)dgvRacuni.SelectedRows[0].DataBoundItem;

            Controller.Instance.DeleteRacun(racun.BrRacuna);
            MessageBox.Show("Racun je uspesno obrisan!");

        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            if (dgvStavke.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite stavku računa", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StavkaRacuna stavka = (StavkaRacuna)dgvStavke.SelectedRows[0].DataBoundItem;
            Controller.Instance.DeleteStavkaRacuna(stavka.BrRacuna, stavka.RbStavke);
            MessageBox.Show("Stavka je uspesno obrisana");
            stavkeRacuna = new BindingList<StavkaRacuna>(Controller.Instance.GetStavkeRacuna(racun.BrRacuna));
            dgvStavke.DataSource = stavkeRacuna;
        }
    }
}
