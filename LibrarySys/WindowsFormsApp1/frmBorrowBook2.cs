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
    public partial class frmBorrowBook2 : Form
    {
        frmBorrowBook parent;
        public frmBorrowBook2()
        {
            InitializeComponent();
        }

        public frmBorrowBook2(frmBorrowBook Parent)
        {
            InitializeComponent();
            parent = Parent;
            lblEnder.Hide();
        }

        private void lblEnder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Book Enders Game was added to the rental");
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            if (txtBookSearch.Text.Equals("Ender") || txtBookSearch.Text.Equals("Enders Game"))
            {
                lblEnder.Show();
            }
            else
            {
                MessageBox.Show("No Book with that title found. (for prototype purposes, try Ender)", "Error");
            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
    }
}
