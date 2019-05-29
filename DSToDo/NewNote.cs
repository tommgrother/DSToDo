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
    public partial class NewNote : Form
    {
        public double _taskID { get; set; }
        public NewNote(double taskID)
        {
            InitializeComponent();
            _taskID = taskID;
           
        }

        private void NewNote_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user_infoDataSet2.view_current_users_with_email' table. You can move, or remove it, as needed.
            this.view_current_users_with_emailTableAdapter.Fill(this.user_infoDataSet2.view_current_users_with_email);

        }


        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            Note n = new Note();
            n.addNote(_taskID, txtNote.Text);
            this.Close();
        }

 
    }
}
