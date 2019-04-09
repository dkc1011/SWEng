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
    public partial class frmPayFine2 : Form
    {
        frmPayFine parent;
        public frmPayFine2()
        {
            InitializeComponent();
        }

        public frmPayFine2(frmPayFine Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmPayFine2_Load(object sender, EventArgs e)
        {
            


        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter a value to decrease the Members fees by.");
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
    }
}
