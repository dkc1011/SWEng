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
    public partial class frmReturnBook : Form
    {
        frmMainMenu parent;
        public frmReturnBook()
        {
            InitializeComponent();
        }

        public frmReturnBook(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnMemberSearch_Click(object sender, EventArgs e)
        {
            lstMemberSearch.Visible = false;

            if (txtMemberSearch.Text.Equals(""))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberSearch.Focus();
                return;
            }

            //retrieve all members with matching surname
            DataSet ds = new DataSet();
            ds = Member.FindActiveBySurname(txtMemberSearch.Text.ToUpper());


            //if no members found
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No members Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberSearch.Focus();
                return;
            }

            lstMemberSearch.Items.Clear();
            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                lstMemberSearch.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][2].ToString() + " " + ds.Tables[0].Rows[i][1].ToString() + " - " + ds.Tables[0].Rows[i][4].ToString() + " - " + ds.Tables[0].Rows[i][5].ToString());
            //lstMemberSearch.SelectedIndex = 0;
            txtMemberSearch.Clear();
            lstMemberSearch.Visible = true;
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void lstMemberSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int memberId = Convert.ToInt32(lstMemberSearch.Text.Substring(0,3));
                DataSet rentalIds = new DataSet();
                    
                rentalIds = Rental.FindByMemberId(memberId);

                DataSet ds = new DataSet();

                for (int i = 0; i < rentalIds.Tables["ss"].Rows.Count; i++)
                {
                    ds = RentalItem.FindBooksByRentalItemId(Convert.ToInt32(rentalIds.Tables[0].Rows[i][0].ToString()));
                }

                grdRentedBooks.DataSource = ds.Tables["RentalItem_books"];
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Member has no rentals currently");
            }

            

            /*
            //retrieve all books with matching name
            DataSet ds = new DataSet();
            DataSet ds2 = new DataSet();
            ds = RentalItem.FindOpenRentalItemsByBookId(Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()));
            ds2 = Book.FindBookById(Convert.ToInt32(lstMemberBooks.Text.Substring(0,3)));
            


            //if no books are found
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No Books Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookSearch.Focus();
                return;
            }

            lstBookSearch.Items.Clear();
            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                lstBookSearch.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][1].ToString() + " BY " + ds.Tables[0].Rows[i][2].ToString());
            lstBookSearch.SelectedIndex = 0;
            txtBookSearch.Clear();
            lstBookSearch.Visible = true;*/


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCloseRental_Click(object sender, EventArgs e)
        {
            /*if (lstMemberBooks.SelectedIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Is this the book to be returned?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    RentalItem.closeRental(Convert.ToInt32(lstMemberBooks.Text.Substring(0,3)));
                    lstMemberBooks.Items.Remove(lstMemberBooks.SelectedIndex);
                    MessageBox.Show("Rental was successfully closed");
                }
            }
            else
            {
                MessageBox.Show("No rental was selected", "Error");
            }*/
        }

        private void clearUI()
        {

        }

        private void grdRentedBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lblMemberSearch_Click(object sender, EventArgs e)
        {

        }

        private void frmReturnBook_Load(object sender, EventArgs e)
        {

        }
    }
}
