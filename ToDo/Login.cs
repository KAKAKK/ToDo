using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public partial class Login : Form
    {
  



        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        
        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Commit_Click(object sender, EventArgs e)
        {
            if(name.Text=="admin"&&password.Text=="123456")
            {
                Home home = new Home();
                home.Show();

                this.Visible = false;   

            }
            else
            {
                MessageBox.Show("用户或密码输入错误");
            }
        }

    
    }
}
