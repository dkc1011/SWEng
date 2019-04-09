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
    public partial class frmAdminRentalsGenre : Form
    {
        frmMainMenu parent;
        public frmAdminRentalsGenre()
        {
            InitializeComponent();
        }

        public frmAdminRentalsGenre(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            imgGenre.Hide();
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            Close();
            parent.Show();
        
        }

        private void btnViewStatistics_Click(object sender, EventArgs e)
        {
            if(cboGenre.Text.Equals("2017"))
            {
                imgGenre.Show();
            }
            else
            {
                MessageBox.Show("There was not data to display in your chosen year (for Prototyping purposes, select 2017)");
            }
        }
    }
}
