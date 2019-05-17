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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            loadLogo();
        }


        private void loadLogo()
        {
            pictureBox1.Image = Image.FromFile(@"S:\Design and Supply CSharp\LogoIcon\ToDo-list-icon.png");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User u = new User(txtUsername.Text, txtPassword.Text);

            if (u._isValid == true)
            {
                MainMenu m = new MainMenu();
                m.Show();
            }
            else
            {
                MessageBox.Show("Invalid login credential, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
