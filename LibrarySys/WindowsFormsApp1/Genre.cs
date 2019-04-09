using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace WindowsFormsApp1
{
    class Genre
    {
        private string genreName;

        public void setGenreName(string genreName)
        {
            this.genreName = genreName;
        }

        public static DataSet getAllGenres(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT GenreId, Genre_Name FROM Genres ORDER BY GenreId";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }
    }
}
