using Oracle.ManagedDataAccess.Client;
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
            
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            Close();
            parent.Show();
        
        }

        private void btnViewStatistics_Click(object sender, EventArgs e)
        {
            
        }

        private void frmAdminRentalsGenre_Load(object sender, EventArgs e)
        {
            

            
        }
    }
}
