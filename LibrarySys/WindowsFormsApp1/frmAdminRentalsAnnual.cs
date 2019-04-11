using Oracle.ManagedDataAccess.Client;
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
    public partial class frmAdminRentalsAnnual : Form
    {
        string[] Months = new string[12];
        decimal[] Totals = new decimal[12];

        frmMainMenu parent;
        public frmAdminRentalsAnnual()
        {
            InitializeComponent();
        }

        public frmAdminRentalsAnnual(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

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


                for (int i = 1; i <= 12; i++)
                {
                    Months[i - 1] = getMonth(i);
                }

                String strSQL = "SELECT COUNT(RentalId), to_Char(RentalDate,'MM') FROM Rentals WHERE to_Char(RentalDate, 'YYYY') = '" + cboYear.Text + "' GROUP BY to_Char(RentalDate,'MM') ORDER BY to_Char(RentalDate,'MM')";
                DataTable dt = new DataTable();

                OracleConnection myConn = new OracleConnection(DBConnect.oradb); OracleCommand cmd = new OracleCommand(strSQL, myConn); OracleDataAdapter da = new OracleDataAdapter(cmd);

                da.Fill(dt);
                myConn.Close();

                string[] N = new string[dt.Rows.Count]; decimal[] M = new decimal[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    N[i] = getMonth(Convert.ToInt32(dt.Rows[i][1])); M[i] = Convert.ToDecimal(dt.Rows[i][0]);
                }
                chtAnnualRentals.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chtAnnualRentals.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                chtAnnualRentals.Series[0].LegendText = "Number of Rentals";
                chtAnnualRentals.Series[0].Points.DataBindXY(N, M);
                chtAnnualRentals.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

                chtAnnualRentals.Series[0].Label = "#VALY";


                chtAnnualRentals.Visible = true;
            }
            else
            {
                MessageBox.Show("No Year was Selected", "Error");
            }
        }

        private void frmAdminRentalsAnnual_Load(object sender, EventArgs e)
        {
            loadCombo();
            chtAnnualRentals.Titles.Add("Yearly Rentals");

        }
        private String getMonth(int Month)
        {
            switch (Month)
            {
                case 1: return "JAN";

                case 2: return "FEB";

                case 3: return "MAR";

                case 4: return "APR";

                case 5: return "MAY";

                case 6: return "JUN";

                case 7: return "JUL";

                case 8: return "AUG";

                case 9: return "SEP";

                case 10: return "OCT";

                case 11: return "NOV";

                case 12: return "DEC";

                default: return "OTH";

            }
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
    }
}
