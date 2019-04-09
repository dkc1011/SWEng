using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmAdminRentalsAnnual : Form
    {
        frmMainMenu parent;
        public frmAdminRentalsAnnual()
        {
            InitializeComponent();
        }

        public frmAdminRentalsAnnual(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            imgAnnRent.Hide();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            Close();
            parent.Show();
        }

        private void btnViewStatistics_Click(object sender, EventArgs e)
        {
            if(cboYear.Text.Equals("2017"))
            {
                imgAnnRent.Show();
            }
            else
            {
                MessageBox.Show("No data avaialbe for the chosen year (for Prototyping purposes, select 2017)");
            }
        }
    }
}
