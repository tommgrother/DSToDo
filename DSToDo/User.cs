using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace DSToDo
{
    class User
    {

        public bool _isValid { get; set; }

        private string _userName { get; set; }
        private string _password { get; set; }



        public User(string userName, string password)
        {
            _userName = userName;
            _password = password;
            validateUser();

        }

        private void validateUser()
        {
            SqlConnection conn = new SqlConnection(Connection.ConnectionStringUser);

            using (SqlCommand cmd = new SqlCommand("select id, forename + ' ' + surname as fullname from dbo.[user] where username=@username and password = @password", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@password", _password);
                cmd.Parameters.AddWithValue("@userName", _userName);

                SqlDataReader rdr = cmd.ExecuteReader();

                
                if (rdr.Read())
                {
                    int userID = Convert.ToInt16(rdr["id"]);
                    Session.userID = userID;
                    Session.fullname = rdr["fullname"].ToString();
                    Session.loggedInTime = DateTime.Now;
                    _isValid = true;
                }
                else
                {
                    _isValid = false;
                }

                conn.Close();

            }
        }


    }
}
