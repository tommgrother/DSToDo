using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void UpdateTask_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task t = new Task();
            t.updateTaskStatus(_taskID, cmbStatus.Text);
            this.Close();
        }
    }
}
