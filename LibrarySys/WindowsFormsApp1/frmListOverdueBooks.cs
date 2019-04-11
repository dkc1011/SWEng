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

            try
            {               

                DataSet ds = new DataSet();

                ds = RentalItem.FindOverdueBook(selectedDate);

                grdOverdueBooks.DataSource = ds.Tables["RentalItem_books"];
                grdOverdueBooks.Visible = true;
            }
            catch (Oracle.ManagedDataAccess.Client.OracleException)
            {
                MessageBox.Show("No books were overdue after this date.");
            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmListOverdueBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
