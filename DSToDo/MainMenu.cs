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
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.Text = "ToDo - Logged in as: " + Session.fullname + "    Logged in at: " + Session.loggedInTime;
        }


        private void populateTasks()
        {
            SqlConnection conn = new SqlConnection(Connection.ConnectionString);

            //TODO CHANGE WHERE STATEMENT
            using (SqlCommand cmd = new SqlCommand("Select [Due Date], [Created Date],[Set By],[Detail] Priority FROM dbo.view_task_list where setForID = @setForID", conn))
            {
                cmd.Parameters.AddWithValue("@setForID", Session.userID);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                dgTasks.DataSource = dt;

                conn.Close();

            }
        }

        private void newTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTask n = new NewTask();
            n.ShowDialog();
            populateTasks();
        }
    }
}
