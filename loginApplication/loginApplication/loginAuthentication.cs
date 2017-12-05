using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace loginApplication
{
    class loginAuthentication
    {
        public string givenID { get; set; }
        public string givenPass { get; set; }

        public OleDbConnection connect ()
        {
            string conString;
            conString = @"provider = microsoft.ace.oledb.12.0;data source = C:\Users\SuperUser\source\repos\loginApplication\database\users.accdb";
            OleDbConnection con = new OleDbConnection(conString);
            con.Open();
            return con;
        }
        public string checklogin()
        {
            string query;
            query = "select * from userLogin where userID= '" + givenID + "' and userPass = '" + givenPass + "'";
            OleDbCommand cmd = new OleDbCommand(query, connect());
            OleDbDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                return "Login Successfully";
            }
            else
            {
                return "Login Failed!!!";
            }
        }
    }

}
