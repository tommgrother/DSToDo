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


            string command = "INSERT INTO DBO.TASK (setByID,setforID,dueDate,createdDate,priorityLevel,taskDetail) " +
                "VALUES (@setByID,@setForID,@dueDate,@createdDate,@priorityLevel,@taskDetail)";

            using (SqlCommand cmd = new SqlCommand(command,conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@setByID", currentUserID);
                cmd.Parameters.AddWithValue("@setForID", setForID);
                cmd.Parameters.AddWithValue("@dueDate", dueDate);
                cmd.Parameters.AddWithValue("@createdDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@priorityLevel", priorityLevel);
                cmd.Parameters.AddWithValue("@taskDetail", taskDetail);
                cmd.ExecuteNonQuery();

                conn.Close();

            }
        }




    }
}
