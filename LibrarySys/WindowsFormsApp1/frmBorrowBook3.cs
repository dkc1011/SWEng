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
    public partial class frmBorrowBook3 : Form
    {
        frmBorrowBook parent;
        public frmBorrowBook3()
        {
            InitializeComponent();
        }

        public frmBorrowBook3(frmBorrowBook Parent)
        {
            InitializeComponent();
            parent = Parent;
            lblLDowling.Hide();
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

        private void btnFinished_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void lblLDowling_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Member LIAM DOWLING was added to the rental");
            this.Close();
            parent.Show();
        }
    }
}
