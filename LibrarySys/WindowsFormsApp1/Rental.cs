using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    class Rental
    {
        private int rentalID;
        private string dueDate;
        private int memberID;


        public Rental()
        {
            rentalID = 0;
            dueDate = "";
            memberID = 0;

        }

        public Rental(int rentalID, string date, int memberId)
        {
            this.rentalID = rentalID;
            this.dueDate = date;
            this.memberID = memberId;
        }

        public void SetrentalId(int rentalID)
        {
            this.rentalID = rentalID;
        }

        public void SetMemberId(int memberID)
        {
            this.memberID = memberID;
        }

        public void SetDueDate(string dueDate)
        {
            this.dueDate = dueDate;
        }

        public int GetRentalID()
        {
            return rentalID;
        }

        public int GetMemberID()
        {
            return memberID;
        }

        public string GetDueDate()
        {
            return dueDate;
        }

        public static int NextRentalId()
        {
            int intNextrentalId = 1;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(rentalId) FROM rentals";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (!dr.IsDBNull(0))
            {
                intNextrentalId = dr.GetInt32(0) + 1;
            }

            return intNextrentalId;
        }

        public void AddRental()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            String strSQL = "INSERT INTO rentals VALUES ('" + NextRentalId().ToString() + "','" + dueDate.ToUpper() + "','" + memberID + "')";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

        public void FindByRentalId(int rentalId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT * FROM rentals WHERE rentalId =" + rentalId;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            this.rentalID = dr.GetInt32(0);
            this.dueDate = dr.GetString(1);
            this.memberID = dr.GetInt32(5);

            conn.Close();
        }

        public static DataSet FindByMemberId(int memberId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            DataSet DS = new DataSet();
            conn.Open();

            String strSQL = "SELECT * FROM rentals WHERE memberId =" + memberId;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();
            return DS;
        }

    }
}
