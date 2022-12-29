using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApp.Views.Forms;
using WinFormApp.Views.UserControlls;

namespace WinFormApp.Views
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void prikažiRačuneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCPrikaziRacune uCPrikaziRacune = new UCPrikaziRacune();
            pnlMain.Controls.Add(uCPrikaziRacune);
        }

        private void dodajRačunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCAddRacun uCAddRacun = new UCAddRacun();
            pnlMain.Controls.Add(uCAddRacun);
        }

        private void prikazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCPrikaziZaposlene uCPrikaziZaposlene = new UCPrikaziZaposlene();
            pnlMain.Controls.Add(uCPrikaziZaposlene);

        }

        private void prikažiDobavljačeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCPrikaziDobavljace uCPrikaziDobavljace = new UCPrikaziDobavljace();
            pnlMain.Controls.Add(uCPrikaziDobavljace);
        }

        private void dodajDobavljačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCAddDobavljac uCAddDobavljac = new UCAddDobavljac();
            pnlMain.Controls.Add(uCAddDobavljac);
        }

        private void prikažiOtpremniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCPrikaziOtpremnice uCPrikaziOtpremnice = new UCPrikaziOtpremnice();
            pnlMain.Controls.Add(uCPrikaziOtpremnice);
        }

        private void prikažiSveStavkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCPrikaziStavkeOtpremnica uCPrikaziStavkeOtpremnica = new UCPrikaziStavkeOtpremnica();
            pnlMain.Controls.Add(uCPrikaziStavkeOtpremnica);
        }

        private void prikažiOsnovnaSredstvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCPrikaziOsnovnaSredstva uCPrikaziOsnovnaSredstva = new UCPrikaziOsnovnaSredstva();
            pnlMain.Controls.Add(uCPrikaziOsnovnaSredstva);
        }


        private void prikažiTipoveOsnovnihSredstavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrikaziTipOS frmPrikaziTipOS = new FrmPrikaziTipOS();
            frmPrikaziTipOS.ShowDialog();
        }
    }
}
