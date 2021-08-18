using JudgeSystem.Data;
using JudgeSystem.Models;
using System;
using System.Windows.Forms;

namespace JudgeSystem
{
    public partial class ProblemListsForm : Form
    {
        public ProblemListsForm()
        {
            InitializeComponent();
        }

        private void PopulateGridView()
        {
            dgvProblemLists.DataSource = ProblemData.GetProblems();
            if (dgvProblemLists.Rows.Count > 0)
            {
                dgvProblemLists.Columns["Id"].Visible = false;
                dgvProblemLists.Columns["Body"].Visible = false;
            }

            dgvProblemLists.ClearSelection();
        }

        private void LoadJudgeForm()
        {
            ManageForm.JudgeForm = new JudgeForm();
            ManageForm.JudgeForm.Show();
            this.Hide();
        }

        private void ProblemListsForm_Load(object sender, EventArgs e)
        {
            PopulateGridView();

            if (ManageUser.IsJudge(ManageUser.CurrentUser))
            {
                btnAction.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            Problem selected = (Problem)dgvProblemLists.CurrentRow.DataBoundItem;

            if (ManageUser.IsJudge(ManageUser.CurrentUser))
            {
                TempData.EditingProblem = selected;

                LoadJudgeForm();
                return;
            }

            if (ManageForm.ParticipantForm == null)
            {
                ManageForm.ParticipantForm = new ParticipantForm();
            }

            TempData.SolvingProblem = selected;

            ManageForm.ParticipantForm.Show();
            this.Hide();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            LoadJudgeForm();
        }

        private void dgvProblemLists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAction.Enabled = true;
        }

        private void ProblemListsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}