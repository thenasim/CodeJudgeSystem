using JudgeSystem.Data;
using JudgeSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JudgeSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = UserData.GetUser(txtLoginId.Text, txtLoginPassword.Text);

            if (user == null)
            {
                MessageBox.Show("Email or Password does not match");
            } else
            {
                MessageBox.Show($"Id: {user.Id}, Name: {user.Name}, Address: {user.Address}");
            }
        }
    }
}
