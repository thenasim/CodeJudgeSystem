using JudgeSystem.Data;
using JudgeSystem.Models;
using System;
using System.Windows.Forms;

namespace JudgeSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void PopulateGridView()
        {
            dgvUserData.DataSource = UserData.GetUsers();
            if (dgvUserData.Rows.Count > 0)
            {
                dgvUserData.Columns["Id"].Visible = false;
            }

            dgvSubmissionData.DataSource = SubmissionData.GetRecentSubmissions();
            if (dgvSubmissionData.Rows.Count > 0)
            {
                dgvSubmissionData.Columns["Id"].Visible = false;
                dgvSubmissionData.Columns["ProblemId"].Visible = false;
                dgvSubmissionData.Columns["UserId"].Visible = false;
            }

            dgvUserData.ClearSelection();
            dgvSubmissionData.ClearSelection();

            dgvUserData.Refresh();
            dgvSubmissionData.Refresh();
        }

        private bool IsValidInput()
        {
            return !(String.IsNullOrEmpty(txtUserName.Text)
                && String.IsNullOrEmpty(txtUserEmail.Text)
                && String.IsNullOrEmpty(txtUserPassword.Text)
                && String.IsNullOrEmpty(txtUserAddress.Text));
        }

        private void ClearInputFields()
        {
            txtUserName.Text = "";
            txtUserAddress.Text = "";
            txtUserEmail.Text = "";
            txtUserPassword.Text = "";
            cmbUserRole.SelectedIndex = -1;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValidInput() == false)
            {
                MessageBox.Show("One or more fields are empty");
                return;
            }

            User u = new User
            {
                Name = txtUserName.Text,
                Address = txtUserAddress.Text,
                Email = txtUserEmail.Text,
                Password = txtUserPassword.Text,
                Role = cmbUserRole.Text,
            };

            UserData.CreateUser(u);
            ClearInputFields();
            PopulateGridView();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (IsValidInput() == false)
            {
                MessageBox.Show("One or more fields are empty");
                return;
            }

            User u = new User
            {
                Name = txtUserName.Text,
                Address = txtUserAddress.Text,
                Email = txtUserEmail.Text,
                Password = txtUserPassword.Text,
                Role = cmbUserRole.Text,
            };
            User selected = (User)dgvUserData.CurrentRow.DataBoundItem;
            u.Id = selected.Id;

            UserData.UpdateUser(u);
            ClearInputFields();
            PopulateGridView();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            User u = (User)dgvUserData.CurrentRow.DataBoundItem;
            UserData.DeleteUser(u.Id);
            PopulateGridView();
        }

        private void dgvUserData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeleteUser.Enabled = true;

            if (ManageUser.CurrentUser != null)
            {
                MessageBox.Show(ManageUser.CurrentUser.Name);
            }
        }

        private void dgvUserData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdateUser.Enabled = true;

            User u = (User)dgvUserData.CurrentRow.DataBoundItem;

            txtUserName.Text = u.Name;
            txtUserAddress.Text = u.Address;
            txtUserEmail.Text = u.Email;
            txtUserPassword.Text = u.Password;
            cmbUserRole.Text = u.Role;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}