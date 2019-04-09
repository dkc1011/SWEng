using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void analyseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminRentalsAnnual form = new frmAdminRentalsAnnual(this);
            this.Hide();
            form.Show();
        }

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddMember form = new frmAddMember(this);
            this.Hide();
            form.Show();
        }

        private void updateMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateMember1 form = new frmUpdateMember1(this);
            this.Hide();
            form.Show();
        }

        private void removeMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Members.frmRemoveMember1 form = new Manage_Members.frmRemoveMember1(this);
            this.Hide();
            form.Show();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddBook form = new frmAddBook(this);
            this.Hide();
            form.Show();
        }

        private void updateBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateBook1 form = new frmUpdateBook1(this);
            this.Hide();
            form.Show();
        }

        private void removeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoveBook form = new frmRemoveBook(this);
            this.Hide();
            form.Show();
        }

        private void checkBookAvailabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckBookAvailable form = new frmCheckBookAvailable(this);
            this.Hide();
            form.Show();
    
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrowBook form = new frmBorrowBook(this);
            this.Hide();
            form.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReturnBook form = new frmReturnBook(this);
            this.Hide();
            form.Show();
        }

        private void listOverdueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOverdueBooks form = new frmListOverdueBooks(this);
            this.Hide();
            form.Show();
        }

        private void payFineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayFine form = new frmPayFine(this);
            this.Hide();
            form.Show();
        }

        private void analyseLoansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminRentalsGenre form = new frmAdminRentalsGenre(this);
            this.Hide();
            form.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
