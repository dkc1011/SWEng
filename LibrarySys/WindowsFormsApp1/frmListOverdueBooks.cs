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
    public partial class frmListOverdueBooks : Form
    {
        frmMainMenu parent;
        public frmListOverdueBooks()
        {
            InitializeComponent();
        }
        public frmListOverdueBooks(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            lblHPotter.Hide();
            lblLOTR.Hide();
        }
        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            lblHPotter.Show();
            lblLOTR.Show();
        }

        private void lblHPotter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Harry Potter and the Deathly Hallows was rented by Liam Dowling and was due back 05/12/2018");
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }


        private void lblLOTR_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("The Lord of the Rings was rented by Liam Dowling and was due back 06/12/2018");
        }
    }
}
