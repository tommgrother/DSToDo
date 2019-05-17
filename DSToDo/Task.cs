using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DSToDo
{
    class Task
    {

        public int setByID  { get; set; }
        public int setForID { get; set; }
        public DateTime dueDate { get; set; }
        public DateTime createdDate { get; set; }
        public int priorityLevel { get; set; }
        public string taskDetail { get; set; }



        public Task()
        {

        }

        public void createTask(int setForID, DateTime dueDate, string priorityLevel,string taskDetail)
        {
            SqlConnection conn = new SqlConnection(Connection.ConnectionString);

            int currentUserID = Session.userID;


            string command = "usp_add_task";

            using (SqlCommand cmd = new SqlCommand(command,conn))
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@setByID", SqlDbType.Int).Value = Session.userID;
                cmd.Parameters.AddWithValue("@setForID", SqlDbType.Int).Value = setForID;
                cmd.Parameters.AddWithValue("@dueDate", SqlDbType.DateTime).Value = dueDate;
                cmd.Parameters.AddWithValue("@createdDate",SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.AddWithValue("@priorityLevel", SqlDbType.NVarChar).Value = priorityLevel;
                cmd.Parameters.AddWithValue("@taskDetail", SqlDbType.NVarChar).Value = taskDetail;
                cmd.ExecuteNonQuery();

                conn.Close();

            }
        }




    }
}
