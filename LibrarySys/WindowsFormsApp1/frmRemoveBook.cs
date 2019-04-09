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
    public partial class frmRemoveBook : Form
    {
        frmMainMenu parent;
        private int mno;

        public frmRemoveBook()
        {
            InitializeComponent();
        }

        public frmRemoveBook(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        private void btnFinished_Click(object sender, EventArgs e)
        {
            Close();
            parent.Show();
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            lstBooks.Visible = false;

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

            lstBooks.Items.Clear();
            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                lstBooks.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][1].ToString() + " BY " + ds.Tables[0].Rows[i][2].ToString());
            lstBooks.SelectedIndex = 0;
            txtBookSearch.Clear();
            lstBooks.Visible = true;
            btnRemoveBook.Visible = true;
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            mno = Convert.ToInt32(lstBooks.Text.Substring(0, 3));
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this member?",
                         "Confirm Remove Member",
                         MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Book.removeBook(mno);
                MessageBox.Show("Member was successfully removed", "Success");
                lstBooks.Hide();
                btnRemoveBook.Hide();
            }
            else
            {
                txtBookSearch.Clear();
                txtBookSearch.Focus();
                lstBooks.Hide();
                btnRemoveBook.Hide();
            }
        }

        private void frmRemoveBook_Load(object sender, EventArgs e)
        {
            lstBooks.Hide();
            btnRemoveBook.Hide();
        }
    }
}
