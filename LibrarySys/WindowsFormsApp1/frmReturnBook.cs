﻿using System;
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
            lblMemSearch.Visible = true;
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
                grpReturnBook.Visible = true;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Member has no rentals currently");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCloseRental_Click(object sender, EventArgs e)
        {
            if (grdRentedBooks.Rows.Count > 0)
            {
                int memberId = Convert.ToInt32(lstMemberSearch.Text.Substring(0, 3));
                int bookId = Convert.ToInt32(grdRentedBooks.Rows[grdRentedBooks.CurrentCell.RowIndex].Cells[0].Value);
                
                Member myMember = new Member();

                double LateFeesStart = myMember.GetLateFees();

                DateTime currentDate = DateTime.Today;                
                myMember.findById(memberId);
                DateTime dueDate = Rental.FindDueDate(memberId, RentalItem.FindRentalIdFromBookId(bookId));

                double LateFees = myMember.CalculateLateFees(String.Format("{0:dd-MMM-yy}", currentDate), dueDate, LateFeesStart);
                myMember.UpdateLateFees(LateFees);

                // update the book status to returned
                Book.SetAvailable(bookId);

                //update rental Item with return date and status
                RentalItem.CloseRental(bookId, (String.Format("{0:dd-MMM-yy}", currentDate)));

                if (LateFeesStart < LateFees)
                {
                    MessageBox.Show("Rental was succesfully closed, Late Fees were added");
                }
                else
                {
                    MessageBox.Show("Rental was succesfully closed");
                }

                clearUI();
            }
            else
            {
                MessageBox.Show("No selected rental");
            }
            
        }

        private void clearUI()
        {
            grpReturnBook.Visible = false;
            lstMemberSearch.Items.Clear();
            lstMemberSearch.Visible = false;
            lblMemSearch.Visible = false;
        }

        private void frmReturnBook_Load(object sender, EventArgs e)
        {
            lstMemberSearch.Visible = false;
            grpReturnBook.Visible = false;
            lblMemSearch.Visible = false;
        }
    }
}
