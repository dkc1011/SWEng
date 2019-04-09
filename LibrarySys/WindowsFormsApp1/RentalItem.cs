using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
namespace WindowsFormsApp1
{
    class RentalItem
    {
        private int rentalId;
        private int bookId;
        private string returnDate;
        private char open;

        public RentalItem()
        {
            rentalId = 0;
            bookId = 0;
            returnDate = "";
            open = 'c';
        }

        public RentalItem(int rentalId, int bookId, string returnDate, char open)
        {
            this.rentalId = rentalId;
            this.bookId = bookId;
            this.returnDate = returnDate;
            this.open = open;
        }

        public void SetRentalId(int rentalId)
        {
            this.rentalId = rentalId;
        }

        public void SetBookId(int bookId)
        {
            this.bookId = bookId;
        }

        public void SetReturnDate(string rentalDate)
        {
            this.returnDate = rentalDate;
        }

        public void SetOpen(char open)
        {
            this.open = open;
        }

        public int GetRentalId()
        {
            return rentalId;
        }

        public int GetBookId()
        {
            return bookId;
        }

        public string GetReturnDate()
        {
            return returnDate;
        }

        public char GetOpen()
        {
            return open;
        }
   
        public void AddRentalItem()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            String strSQL = "INSERT INTO rentalItems VALUES ('" + GetRentalId().ToString() + "','" + GetBookId().ToString() + "','" + GetReturnDate().ToUpper() + "','" + open + "')";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

        public static DataSet FindOpenRentalItemsByBookId(int BookId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            DataSet DS = new DataSet();

            conn.Open();

            String strSQL = "SELECT * FROM RentalItems WHERE BookId =" + BookId + " AND Open = 'o' ORDER BY bookId";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();
            return DS;
        }

        public static DataSet FindOpenRentalItemsByRentalId(int RentalId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            DataSet DS = new DataSet();

            conn.Open();

            String strSQL = "SELECT * FROM RentalItems WHERE RentalId =" + RentalId + " AND Open = 'o' ORDER BY RentalId";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();
            return DS;
        }

        public static DataSet FindBooksByRentalItemId(int rentalId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            DataSet DS = new DataSet();

            conn.Open();

            String strSQL = "SELECT RentalItems.BookId, Books.Title, Books.Author FROM RentalItems INNER JOIN Books ON RentalItems.BookId = Books.BookId WHERE RentalId =" + rentalId + " AND Open = 'o' ORDER BY RentalId";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "RentalItem_books");

            conn.Close();
            return DS;
        }

        public static void CloseRental(int bookId, string returnDate)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "UPDATE RentalItems SET Open = 'c' WHERE bookId = " + bookId;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            String strSQL2 = "UPDATE RentalItems SET returnDate = '" + returnDate + "' WHERE bookId = " + bookId;

            OracleCommand cmd2 = new OracleCommand(strSQL2, myConn);
            cmd2.ExecuteNonQuery();

            myConn.Close();
        }
    }
}
