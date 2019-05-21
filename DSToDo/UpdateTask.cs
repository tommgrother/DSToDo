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
    public partial class UpdateTask : Form
    {

        public double _taskID { get; set; }
        public UpdateTask(double taskID)
        {
            InitializeComponent();

            Task t = new Task();
            t.getTask(taskID);

            _taskID = t._taskID;
            lblTaskID.Text = "Task ID: " + t._taskID;

            txtSubject.Text = t.taskSubject;
            txtDetail.Text = t.taskDetail;

            //Fill Notes grid
            fillNote();
            formatGrid();

        }

        private void UpdateTask_Load(object sender, EventArgs e)
        {

        }

        private void formatGrid()
        {

            DataGridViewColumn column0 = dgNotes.Columns[0];
            column0.Width = 50;
            DataGridViewColumn column1 = dgNotes.Columns[1];
            column1.Width = 100;
            DataGridViewColumn column2 = dgNotes.Columns[2];
            column2.Width = 100;
            DataGridViewColumn column3= dgNotes.Columns[3];
            column3.Width = 365;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task t = new Task();
            t.updateTaskStatus(_taskID, cmbStatus.Text);
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            NewNote n = new NewNote(_taskID);
            n.ShowDialog();
            fillNote();


        }

        private void fillNote()
        {
            SqlConnection conn = new SqlConnection(Connection.ConnectionString);

            using (SqlCommand cmd = new SqlCommand("Select [Note ID], [Note Date],[Note By],Detail FROM dbo.view_task_notes where [Task ID] = @taskID order by [Note Date] desc", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@taskID", _taskID);

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                ad.Fill(dt);

                dgNotes.DataSource = dt;


                conn.Close();

            }


        }
    }
}
