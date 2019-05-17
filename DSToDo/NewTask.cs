﻿using System;
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
    public partial class NewTask : Form
    {
        public NewTask()
        {
            InitializeComponent();
        }

        private void NewTask_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user_infoDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.user_infoDataSet.user);

        }
    
        private void btnSave_Click(object sender, EventArgs e)
        {
            Task t = new Task();
            t.createTask(Convert.ToInt32(cmbSetForID.SelectedValue), Convert.ToDateTime(dteDueDate.Text), cmbPriority.SelectedText, txtDetail.Text);
            this.Close();
        }
    }
}