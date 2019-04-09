using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    class Book
    {
        private int bookID;
        private string title;
        private string author;
        private string ISBN;
        private char available;
        private int genreID;

        public Book()
        {
            bookID = 0;
            title = "";
            author = "";
            ISBN = "";
            available = 'n';
            genreID = 0;
        }

        public Book(int bookID, string title, string author, string isbn, char available, int genreId)
        {
            this.bookID = bookID;
            this.title = title;
            this.author = author;
            ISBN = isbn;
            this.available = available;
            genreID = genreId;
        }

        public void SetBookId(int bookID)
        {
            this.bookID = bookID;
        }

        public void SetGenreId(int genreID)
        {
            this.genreID = genreID;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public void SetAuthor(string author)
        {
            this.author = author;
        }

        public void SetISBN(string ISBN)
        {
            this.ISBN = ISBN;
        }

        public void SetAvailable(char available)
        {
            this.available = available;
        }

        public int GetBookID()
        {
            return bookID;
        }

        public int GetGenreID()
        {
            return genreID;
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }

        public string GetISBN()
        {
            return ISBN;
        }

        public char GetAvailable()
        {
            return available;
        }

        public static int NextBookId()
        {
            int intNextBookId = 1;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(BookId) FROM Books";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (!dr.IsDBNull(0))
            {
                intNextBookId = dr.GetInt32(0) + 1;
            }

            return intNextBookId;
        }

        public void addBook()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            String strSQL = "INSERT INTO Books VALUES ('" + NextBookId().ToString() + "','" + title.ToUpper() + "','" + author.ToUpper() + "','" + ISBN.ToUpper() + "','" + available + "','" + genreID + "')";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

        public void updBook()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "UPDATE Books SET Title = '" + this.title.ToUpper() + "', author = '" + this.author + "', ISBN = '" + this.ISBN + "', genreId = " + this.genreID + " WHERE BookId = " + this.bookID;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

        public static DataSet FindBookByName(string name)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            DataSet DS = new DataSet();

            String strSQL = "SELECT * FROM Books WHERE title LIKE '" + name + "%' ORDER BY BookId";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public void FindById(int BookId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT * FROM Books WHERE BookId = " + BookId;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            this.bookID = dr.GetInt32(0);
            this.title = dr.GetString(1);
            this.author = dr.GetString(2);
            this.ISBN = dr.GetString(3);
            //this.available = dr.GetChar(4);
            this.genreID = dr.GetInt32(5);

            conn.Close();
        }

        public static DataSet FindBooksById(int BookId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            DataSet DS = new DataSet();
            conn.Open();

            String strSQL = "SELECT * FROM Books WHERE BookId = " + BookId + " ORDER BY BookId";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public static DataSet FindAvailableBookByName(string name)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            DataSet DS = new DataSet();

            String strSQL = "SELECT * FROM Books WHERE title LIKE '" + name + "%' AND Available = 'a' ORDER BY BookId";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public static void removeBook(int bno)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "UPDATE Books SET available = 'r' WHERE BookID = " + bno;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

        public static void makeBookUnavailable(int bno)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "UPDATE Books SET available = 'u' WHERE BookID = " + bno;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

        public static void SetAvailable(int bookId)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "UPDATE Books SET available = 'a' WHERE BookID = " + bookId;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

    }
}
