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
    public partial class frmUpdateBook2 : Form
    {
        frmUpdateBook1 parent;
        public frmUpdateBook2()
        {
            InitializeComponent();
        }

        public frmUpdateBook2(frmUpdateBook1 Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void lblAddBookHeader_Click(object sender, EventArgs e)
        {

        }

        private void frmUpdateBook2_Load(object sender, EventArgs e)
        {

        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtTitle.Text.Equals(""))
            {
                MessageBox.Show("The title field must be filled.", "Error");
            }
            else
            {
                MessageBox.Show("The Book " + txtTitle.Text + " was Updated");
            }
        }
    }
}
