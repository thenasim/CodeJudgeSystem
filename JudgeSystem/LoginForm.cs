using JudgeSystem.Data;
using JudgeSystem.Models;
using System;
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
            }
            else
            {
                ManageUser.CurrentUser = user;

                if (ManageUser.IsAdmin(user))
                {
                    ManageForm.AdminForm = new AdminForm();
                    ManageForm.AdminForm.Show();
                    this.Hide();
                }
                else if (ManageUser.IsJudge(user) || ManageUser.IsParticpant(user))
                {
                    ManageForm.ProblemListsForm = new ProblemListsForm();
                    ManageForm.ProblemListsForm.Show();
                    this.Hide();
                }
                else if (ManageUser.IsSupervisor(user))
                {
                    ManageForm.SupervisorForm = new SupervisorForm();
                    ManageForm.SupervisorForm.Show();
                    this.Hide();
                }
            }
        }
    }
}