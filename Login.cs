using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        newDataContext db = new newDataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            int result = db.pro_login(username.Text, password.Text).Count();
            if (result == 1)
            {
                if (db.acc_type(username.Text, password.Text) == 0)
                {
                    MessageBox.Show("Welcome Admin!");
                }
                else
                {
                    MessageBox.Show("Welcome Staff!");
                }
            }
            else
            {
                MessageBox.Show("Login Failed");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}