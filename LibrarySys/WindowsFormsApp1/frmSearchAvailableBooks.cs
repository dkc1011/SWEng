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
    public partial class frmSearchAvailableBooks : Form
    {
        frmMainMenu parent;
        public frmSearchAvailableBooks()
        {
            InitializeComponent();
        }

        public frmSearchAvailableBooks(frmMainMenu Parent)
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
        }
    }
}
