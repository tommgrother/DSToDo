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
        }


        private void populateTasks()
        {
            SqlConnection conn = new SqlConnection(Connection.ConnectionString);

            //TODO CHANGE WHERE STATEMENT
            using (SqlCommand cmd = new SqlCommand("Select [Due Date], [Created Date],[Set By], Priority,[Detail] FROM dbo.view_task_list where setForID = @setForID", conn))
            {
                cmd.Parameters.AddWithValue("@setForID", Session.userID);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                dgTasks.DataSource = dt;

                //TODO NEEDS WORK ON WIDTHS
                //DataGridViewColumn column = dgTasks.Columns[0];
                //column.Width = 60;
                //DataGridViewColumn column2 = dgTasks.Columns[1];
                //column2.Width = 20;
                //DataGridViewColumn column3 = dgTasks.Columns[3];
                //column3.Width = 20;

                conn.Close();

            }
        }

        private void populateTasksSent()
        {
            SqlConnection conn = new SqlConnection(Connection.ConnectionString);

            //TODO CHANGE WHERE STATEMENT
            using (SqlCommand cmd = new SqlCommand("Select [Due Date], [Created Date],[Task For], Priority,[Detail] FROM dbo.view_task_list where setByID = @setByID", conn))
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
    }
}
