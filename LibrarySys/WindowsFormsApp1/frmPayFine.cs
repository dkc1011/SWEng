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
    public partial class frmPayFine : Form
    {
        frmMainMenu parent;
        public frmPayFine()
        {
            InitializeComponent();
        }

        public frmPayFine(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            lblLDowling.Hide();
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            Close();
            parent.Show();
        }

        private void btnMemberSearch_Click(object sender, EventArgs e)
        {
            if (txtMemberSearch.Text.Equals("Dowling") || txtMemberSearch.Text.Equals("dowling"))
            {
                lblLDowling.Show();
            }
            else
            {
                MessageBox.Show("No member with that surname found. (for prototype purposes, try Dowling)", "Error");
            }
        }

        private void lblLDowling_Click(object sender, EventArgs e)
        {
            frmPayFine2 form = new frmPayFine2(this);

            this.Hide();
            form.Show();
        }
    }
}
