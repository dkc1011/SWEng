using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmAdminRentalsGenre : Form
    {


        frmMainMenu parent;
        public frmAdminRentalsGenre()
        {
            InitializeComponent();
        }

        public frmAdminRentalsGenre(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            Close();
            parent.Show();
        
        }

        private void btnViewStatistics_Click(object sender, EventArgs e)
        {
            if (cboYear.Text != "SELECT YEAR")
            {
                if (validYear(cboYear.Text))
                {

                    String strSQL = "SELECT COUNT(RentalItems.RentalId), Books.GenreId FROM RentalItems INNER JOIN Books ON RentalItems.BookId = Books.BookId INNER JOIN Rentals ON RentalItems.RentalId = Rentals.RentalId WHERE to_Char(Rentals.RentalDate, 'YYYY') = '" + cboYear.Text + "' GROUP BY Books.GenreId ORDER BY Books.GenreId";
                    DataTable dt = new DataTable();

                    OracleConnection myConn = new OracleConnection(DBConnect.oradb); OracleCommand cmd = new OracleCommand(strSQL, myConn);
                    OracleDataAdapter da = new OracleDataAdapter(cmd);

                    da.Fill(dt);
                    myConn.Close();

                    string[] N = new string[dt.Rows.Count]; decimal[] M = new decimal[dt.Rows.Count];

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        N[i] = getGenre(Convert.ToInt32(dt.Rows[i][1])); M[i] = Convert.ToDecimal(dt.Rows[i][0]);
                    }
                    chtAnnualGenre.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                    chtAnnualGenre.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                    chtAnnualGenre.Series[0].LegendText = "Rentals by Genre";
                    chtAnnualGenre.Series[0].Points.DataBindXY(N, M);
                    chtAnnualGenre.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

                    chtAnnualGenre.Series[0].Label = "#VALY";


                    chtAnnualGenre.Visible = true;
                }
                else
                {
                    MessageBox.Show("No Year was Selected", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please input a valid year.");
            }
        }
    


        private void frmAdminRentalsGenre_Load(object sender, EventArgs e)
        {
            loadCombo();
            chtAnnualGenre.Titles.Add("Yearly Rentals by Genre");

        }
        public void loadCombo()
        {
            cboYear.Items.Add("SELECT YEAR");
            cboYear.Items.Add(DateTime.Now.Year - 4);
            cboYear.Items.Add(DateTime.Now.Year - 3);
            cboYear.Items.Add(DateTime.Now.Year - 2);
            cboYear.Items.Add(DateTime.Now.Year - 1);
            cboYear.Items.Add(DateTime.Now.Year);

        }
        private String getGenre(int Genre)
        {
            switch (Genre)
            {
                case 1: return "HORR";

                case 2: return "FANT";

                case 3: return "CRME";

                case 4: return "NATR";

                case 5: return "HIST";

                case 6: return "HW-TO";

                default: return "OTH";

            }
        }



    public bool validYear(String inStr)
        {
            if (Regex.IsMatch(inStr, @"^\d{4}$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
