using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMProject
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnBalance_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCheckBalance nextForm = new frmCheckBalance(this);
            nextForm.Show();
        }
    }
}
