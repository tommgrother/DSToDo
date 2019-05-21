using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DSToDo
{
    class Note
    {


        public void addNote(double taskID, string noteDetail)
        {
            ///CODE NEEDED ON NEW FORM
            SqlConnection conn = new SqlConnection(Connection.ConnectionString);

            string command = "usp_add_task_note";

            using (SqlCommand cmd = new SqlCommand(command, conn))
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@taskID", SqlDbType.Int).Value = taskID;
                cmd.Parameters.AddWithValue("@noteByID", SqlDbType.Int).Value = Session.userID;
                cmd.Parameters.AddWithValue("@noteDetail", SqlDbType.NVarChar).Value = noteDetail;

                cmd.ExecuteNonQuery();

                conn.Close();

            }
        }



    }
}
