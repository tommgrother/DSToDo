using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DSToDo
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            populateTasks();
            populateTasksSent();
           
           
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.Text = "ToDo - Logged in as: " + Session.fullname + "    Logged in at: " + Session.loggedInTime;
            formatGrid();
            formatGridSent();
          
        }


        private void populateTasks()
        {
            SqlConnection conn = new SqlConnection(Connection.ConnectionString);

            //FILTERS DIFFERENTLY BASED ON WHETHER THE SHOW COMPLETES CHECKBOX IS TICKED
            if(chkShowCompletes.Checked == false)
            {
                using (SqlCommand cmd = new SqlCommand("Select [Task ID],[Created Date],[Set By],[Subject],[Details], [Due Date],[Task Status],[Date Complete], Priority FROM dbo.view_task_list where ([Task Status]=@taskStatus1 or [Task Status] = @taskStatus2) and setForID = @setForID", conn))
                {
                    cmd.Parameters.AddWithValue("@setForID", Session.userID);
                    cmd.Parameters.AddWithValue("@taskStatus1", "Pending");
                    cmd.Parameters.AddWithValue("@taskStatus2", "In Progress");
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dgTasks.DataSource = dt;
                    conn.Close();

                }
            }
            else
            {
                using (SqlCommand cmd = new SqlCommand("Select [Task ID],[Created Date],[Set By],[Subject],[Details], [Due Date],[Task Status],[Date Complete], Priority FROM dbo.view_task_list where setForID = @setForID", conn))
                {
                    cmd.Parameters.AddWithValue("@setForID", Session.userID);
                
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dgTasks.DataSource = dt;
                    conn.Close();

                }
            }
            
        }


        private void formatGrid()
        {
            DataGridViewColumn column0 = dgTasks.Columns[0];
            column0.Width = 30;
            DataGridViewColumn column1 = dgTasks.Columns[1];
            column1.Width = 65;
            DataGridViewColumn column2 = dgTasks.Columns[2];
            column2.Width = 65;
            DataGridViewColumn column3 = dgTasks.Columns[3];
            column3.Width = 100;
            DataGridViewColumn column4 = dgTasks.Columns[4];
            column4.Width = 350;

            //sent
            

           


        }

        private void formatGridSent()
        {
            DataGridViewColumn column0s = dgTasksSent.Columns[0];
            column0s.Width = 30;
            DataGridViewColumn column1s = dgTasksSent.Columns[1];
            column1s.Width = 65;
            DataGridViewColumn column2s = dgTasksSent.Columns[2];
            column2s.Width = 65;
            DataGridViewColumn column3s = dgTasksSent.Columns[3];
            column3s.Width = 100;
            DataGridViewColumn column4s = dgTasksSent.Columns[4];
            column4s.Width = 350;
        }

        private void populateTasksSent()
        {
            SqlConnection conn = new SqlConnection(Connection.ConnectionString);

            //TODO CHANGE WHERE STATEMENT
            using (SqlCommand cmd = new SqlCommand("Select [Task ID],[Created Date],[Task For],[Subject],[Details], [Due Date],[Task Status],[Date Complete], Priority FROM dbo.view_task_list where setByID = @setByID", conn))
            {
                cmd.Parameters.AddWithValue("@setByID", Session.userID);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                dgTasksSent.DataSource = dt;

                conn.Close();

            }
        }

        private void newTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTask n = new NewTask();
            n.ShowDialog();
            populateTasks();
            populateTasksSent();
        }

        private void dgTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dgTasks.CurrentCell.RowIndex;
            int columnindex = 0;

            double taskID = Convert.ToDouble(dgTasks.Rows[rowindex].Cells[columnindex].Value.ToString());

            UpdateTask ut = new UpdateTask(taskID);

            ut.ShowDialog();
            populateTasks();
            populateTasksSent();
        }

        private void chkShowCompletes_CheckedChanged(object sender, EventArgs e)
        {
            populateTasks();
        }

        private void refreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            populateTasks();
            populateTasksSent();
        }

        private void allOutstandingToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(Connection.ConnectionString);



            string command = "usp_email_outstanding";

            using (SqlCommand cmd = new SqlCommand(command, conn))
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userID", SqlDbType.Int).Value = Session.userID;


                cmd.ExecuteNonQuery();

                conn.Close();

            }




            
        }
    }
}
