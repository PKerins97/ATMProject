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
    public partial class frmCheckBalance : Form
    {
        frmDashBoard parent;
        double balance;

        public frmCheckBalance()
        {
            InitializeComponent();
        }
        public frmCheckBalance(frmDashBoard Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        private void frmCheckBalance_Load(object sender, EventArgs e)
        {

        }

        private void BtnBalance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Balance is " + balance , "Balance", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
