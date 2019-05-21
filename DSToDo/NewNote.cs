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

        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            Note n = new Note();
            n.addNote(_taskID, txtNote.Text);
            this.Close();
        }
    }
}
