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
    public partial class frmUpdateBook1 : Form
    {
        frmMainMenu parent;
        Book myBook = new Book();
        public frmUpdateBook1()
        {
            InitializeComponent();
        }

        public frmUpdateBook1(frmMainMenu Parent)
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

        private void frmUpdateBook1_Load(object sender, EventArgs e)
        {
            loadCombo();
        }

        public void loadCombo()
        {
            // create instance of data set
            DataSet ds = new DataSet();

            ds = Genre.getAllGenres(ds);

            //Remove existing items from combo box
            cboGenre.Items.Clear();

            //Add first item to instruct user
            cboGenre.Items.Add("SELECT GENRE");

            //load data from ds to cboStock
            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                cboGenre.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][1].ToString());
            cboGenre.SelectedIndex = 0;
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            myBook.FindById(Convert.ToInt32(lstBooks.Text.Substring(0, 3)));

            txtTitle.Text = myBook.GetTitle();
            txtAuthor.Text = myBook.GetAuthor();
            txtISBN.Text = myBook.GetISBN();
            cboGenre.SelectedIndex = myBook.GetGenreID();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            myBook.SetTitle(txtTitle.Text.ToUpper());
            myBook.SetAuthor(txtAuthor.Text.ToUpper());
            myBook.SetISBN(txtISBN.Text.ToUpper());
            myBook.SetGenreId(Convert.ToInt32( cboGenre.Text.Substring(0, 3)));
       
            myBook.updBook();

            MessageBox.Show("Book " + txtTitle.Text.ToUpper() + " Updated", "Success");

            txtBookSearch.Clear();
            txtBookSearch.Focus();
        }

    }
}
