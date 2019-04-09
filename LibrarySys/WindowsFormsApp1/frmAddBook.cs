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
    public partial class frmAddBook : Form
    {
        frmMainMenu parent;
        public frmAddBook()
        {
            InitializeComponent();
        }

        public frmAddBook(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Equals(""))
            {
                MessageBox.Show("Title field must be filled.", "Error");
            }
            else if(txtAuthor.Text.Equals(""))
            {
                MessageBox.Show("Author field must be filled.", "Error");
            }
            else if(txtISBN.Text.Equals(""))
            {
                MessageBox.Show("ISBN field must be filled.", "Error");
            }
            else if(txtISBN.Text.Length < 12 && txtISBN.Text.Length > 15)
            {
                MessageBox.Show("Invalid ISBN entered");
            }
            else
            {
                Book myBook = new Book(Book.NextBookId(),txtTitle.Text, txtAuthor.Text, txtISBN.Text, 'a', Convert.ToInt32(cboGenre.Text.Substring(0, 3)));
                myBook.addBook();

                MessageBox.Show("Book " + txtTitle.Text.ToUpper() + " has been added.", "Success");

                txtTitle.Clear();
                txtAuthor.Clear();
                txtISBN.Clear();
                loadCombo();
            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            Close();
            parent.Show();
        }

        private void frmAddBook_Load(object sender, EventArgs e)
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
    }
}
