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

namespace WinFormApp.Views.UserControlls
{
    public partial class UCPrikaziDobavljace : UserControl
    {
        public UCPrikaziDobavljace()
        {
            InitializeComponent();
            dgvDobavljaci.DataSource = Controller.Instance.GetDobavljaci();
            dgvDobavljaci.Columns[0].Visible = false;
        }

       
    }
}
