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
        }
        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpSelectedDate.Value;

             

            DataSet ds = new DataSet();

            ds = RentalItem.FindOverdueBook(selectedDate);

            grdOverdueBooks.DataSource = ds.Tables["RentalItem_books"];
            grdOverdueBooks.Visible = true;
            
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
    }
}
