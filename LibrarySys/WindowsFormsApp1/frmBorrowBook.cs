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
    public partial class frmBorrowBook : Form
    {
        frmMainMenu parent;
        Member myMember = new Member();
        private int bookIndex;
        public frmBorrowBook()
        {
            InitializeComponent();
        }

        public frmBorrowBook(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnSelectMember_Click(object sender, EventArgs e)
        {
            if(lstMemberSearch.Items.Count > 0)
            { 
                int memberId = Convert.ToInt32(lstMemberSearch.Text.Substring(0, 3));
                myMember.findById(memberId);

                if (myMember.GetLateFees() == 0)
                {
                    txtSelectedMember.Visible = true;
                    lblSelectedMember.Visible = true;
                    txtSelectedMember.Visible = false;

                    txtSelectedMember.Text = lstMemberSearch.Text.Substring(0, 3);

                    txtSelectedMember.Visible = true;
                }
                else
                {
                    MessageBox.Show("A member with late fees cannot make a new rental. Please select a member with no late fees.", "Error");
                }
             }       
            else
            {
                MessageBox.Show("There was no member selected", "Error");
            }
        }

        private void lstSelectedBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            Close();
            parent.Show();
        }

        private void btnSelectBooks_Click(object sender, EventArgs e)
        {
            lstSelectedBooks.Visible = true;
            btnClear.Visible = true;
            lblBookSelected.Visible = true;
            int bookChecker = 0;

            if (lstBookSearch.Items.Count > 0 && lstBookSearch.SelectedIndex != -1)
            {         
                for (int i = 0; i < lstSelectedBooks.Items.Count; i++)
                {
                    lstSelectedBooks.SelectedIndex = i;

                    if (lstSelectedBooks.Text == lstBookSearch.Text)
                    {
                        MessageBox.Show("The selected book is already in the queue", "Error");
                    }
                    else
                    {
                        bookChecker++;
                        lstSelectedBooks.SelectedIndex = -1;
                    }
                }

                if (bookChecker == lstSelectedBooks.Items.Count)
                {
                    lstSelectedBooks.Items.Add(lstBookSearch.Text);
                    lstBookSearch.SelectedIndex = -1;
                }
            }        
            else
            {
                MessageBox.Show("There was no book selected", "Error");
            }
    
        }

        private void frmBorrowBook_Load(object sender, EventArgs e)
        {
        }

        private void txtSelectedMember_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {

            if (txtBookSearch.Text.Equals(""))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookSearch.Focus();
                return;
            }

            //retrieve all books with matching name
            DataSet ds = new DataSet();
            ds = Book.FindAvailableBookByName(txtBookSearch.Text.ToUpper());


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
            lstBookSearch.Visible = true;

 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstSelectedBooks.Items.Clear();
            lstSelectedBooks.Visible = false;
            lblBookSelected.Visible = false;
            btnClear.Visible = false;
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
            lstMemberSearch.SelectedIndex = 0;
            txtMemberSearch.Clear();
            lstMemberSearch.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Confirm Rental?",
             "Confirm",
             MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                if (txtSelectedMember.Text != "None")
                {
                    DateTime currentDate = DateTime.Today;

                    //Create the Rental in the database
                    DateTime dueDate = currentDate.AddDays(14);
                    Rental myRental = new Rental();

                    myRental.SetrentalId(Rental.NextRentalId());
                    myRental.SetMemberId(Convert.ToInt32(txtSelectedMember.Text));
                    myRental.SetDueDate(String.Format("{0:dd-MMM-yy}", dueDate));

                    //Creates as many RentalItems as there are books in the table
                    if (lstSelectedBooks.Items.Count > 0)
                    {
                        myRental.AddRental();

                        for (int i = 0; i < lstSelectedBooks.Items.Count; i++)
                        {
                            RentalItem myRentalItem = new RentalItem();
                            lstSelectedBooks.SelectedIndex = i;
                            int myBookId = Convert.ToInt32(lstSelectedBooks.Text.Substring(0, 3));


                            myRentalItem.SetRentalId(myRental.GetRentalID());
                            myRentalItem.SetBookId(myBookId);
                            myRentalItem.SetRentalDate(String.Format("{0:dd-MMM-yy}", currentDate));
                            myRentalItem.SetOpen('o');
                            Book.makeBookUnavailable(myBookId);

                            myRentalItem.AddRentalItem();
                        }

                        MessageBox.Show("New Rental was Opened");
                        ClearUI();

                    }
                    else
                    {
                        MessageBox.Show("There were no books selected, please select a book(s) and click confirm.", "Error");
                        ClearUI();
                    }
                }
                else
                {
                    MessageBox.Show("There was no member selected, please select a member and click confirm.","Error");
                    ClearUI();
                }
                
            }
            else
            {
                ClearUI();
            }
        }

        private void ClearUI()
        {
            txtSelectedMember.Text = "None";
            txtSelectedMember.Hide();
            txtMemberSearch.Clear();
            txtBookSearch.Clear();
            lblSelectedMember.Hide();
            lblBookSelected.Hide();
            lstSelectedBooks.Items.Clear();
            lstSelectedBooks.Hide();
            lstBookSearch.Items.Clear();
            lstMemberSearch.Items.Clear();
            btnClear.Hide();
        }
    }
}
