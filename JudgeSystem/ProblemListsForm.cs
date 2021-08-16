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

        private void txtSearchProblem_TextChanged(object sender, EventArgs e)
        {
            // TODO: Search Problem
        }

        private void ProblemListsForm_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (ManageForm.ParticipantForm == null)
            {
                ManageForm.ParticipantForm = new ParticipantForm();
            }

            Problem selected = (Problem)dgvProblemLists.CurrentRow.DataBoundItem;
            TempData.SolvingProblem = selected;

            ManageForm.ParticipantForm.Show();
            this.Hide();
        }

        private void dgvProblemLists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSolve.Enabled = true;
        }

        private void ProblemListsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}