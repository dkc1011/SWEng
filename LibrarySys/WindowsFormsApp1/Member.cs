using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    class Member
    {
        // instance variables

        private int memberId;
        private string surname;
        private string forename;
        private string date_of_birth;
        private string street;
        private string town;
        private string phone;
        private string email;
        private float late_fees;
        private char status;

        //No argument constructor
        public Member()
        {
            memberId = 0;
            surname = "";
            forename = "";
            date_of_birth = "DD MMM YY";
            street = "";
            town = "";
            phone = "";
            email = "";

            //d = default
            status = 'd';
        }

        //Argument constructor
        public Member(int mID, string sname, string fname, string dob, string street, string town, string phonenum, string emailadd, char status)
        {
            memberId = mID;
            surname = sname;
            forename = fname;
            date_of_birth = dob;
            this.street = street;
            this.town = town;
            phone = phonenum;
            email = emailadd;
            this.status = status;
        }

        //Setters

        public void setStatus(char status)
        {
            this.status = status;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public void setForename(string forename)
        {
            this.forename = forename;
        }

        public void setDateOfBirth(string date_of_birth)
        {
            this.date_of_birth = date_of_birth;
        }

        public void setStreet(string street)
        {
            this.street = street;
        }

        public void setTown(string town)
        {
            this.town = town;
        }

        public void setPhone(string phone)
        {
            this.phone = phone;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }


        //Setters

        public string getSurname()
        {
            return this.surname;
        }

        public string getForename()
        {
            return this.forename;
        }

        public string getDOB()
        {
            return this.date_of_birth;
        }

        public string getStreet()
        {
            return this.street;
        }

        public string getTown()
        {
            return this.town;
        }

        public string getPhone()
        {
            return this.phone;
        }

        public string getEmail()
        {
            return this.email;
        }

        public float GetLateFees()
        {
            return late_fees;
        }


        //Other Methods

        //DataSet method
        public static DataSet getAllMembers(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT MemberId, Surname, Forename FROM Members ORDER BY MemberId";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public void findById(int memberId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT * FROM Members WHERE MemberId =" + memberId;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            this.memberId = dr.GetInt32(0);
            this.surname = dr.GetString(1);
            this.forename = dr.GetString(2);
            this.date_of_birth = dr.GetString(3);
            this.street = dr.GetString(4);
            this.town = dr.GetString(5);
            this.phone = dr.GetString(6);
            this.email = dr.GetString(7);

            conn.Close();
        }

        public static DataSet findBySurname(string surname)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            DataSet DS = new DataSet();

            String strSQL = "SELECT * FROM Members WHERE surname LIKE '" + surname + "%' ORDER BY MemberId";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public static DataSet FindActiveBySurname(string surname)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            DataSet DS = new DataSet();

            String strSQL = "SELECT * FROM Members WHERE surname LIKE '" + surname + "%' AND status = 'a' ORDER BY MemberId";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "ss");

            conn.Close();

            return DS;
        }

        public static int nextMemberId()
        {
            int intNextMemberId = 1;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(MemberId) FROM Members";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if(!dr.IsDBNull(0))
            {
                intNextMemberId = dr.GetInt32(0) + 1;
            }

            return intNextMemberId;
        }

        public void addMember()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
            String strSQL = "INSERT INTO Members VALUES ('" + memberId + "','" + surname.ToUpper() + "','" + forename.ToUpper() + "','" + date_of_birth + "','" + street.ToUpper()
                + "','" + town.ToUpper() + "','" + phone + "','" + email.ToUpper() + "','" + late_fees + "','" + 'a' + "')";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close(); 
        }

        public void updMember()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "UPDATE Members SET Surname = '" + this.surname.ToUpper() + "', Forename = '" + this.forename + "', Date_of_birth = '" + this.date_of_birth + "', Street = '" + this.street + "', Town = '" + this.town + "', Phone = '" + this.phone + "', Email = '" + this.email + "' WHERE MemberId = " + this.memberId;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }


        //Overloaded removeMembers method
        public static void removeMember(int mno)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "UPDATE Members SET Status = s'" + 'i' + "' WHERE memberId = " + mno;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

        public void removeMember(string Surname)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "DELETE FROM Members WHERE Surname = '" + Surname + "'";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

    }
}
