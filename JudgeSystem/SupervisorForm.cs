using JudgeSystem.Data;
using JudgeSystem.ViewModel;
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
    public partial class SupervisorForm : Form
    {
        public SupervisorForm()
        {
            InitializeComponent();
        }

        private void PopulateGridView()
        {
            dgvSubmittedDetails.DataSource = SubmissionDetailsData.GetDetails();
            if (dgvSubmittedDetails.Rows.Count > 0)
            {
                dgvSubmittedDetails.Columns["ProblemId"].Visible = false;
                dgvSubmittedDetails.Columns["ProblemBody"].Visible = false;
                dgvSubmittedDetails.Columns["ProblemTestInput"].Visible = false;
                dgvSubmittedDetails.Columns["ProblemTestOutput"].Visible = false;
                dgvSubmittedDetails.Columns["SubmissionId"].Visible = false;
                dgvSubmittedDetails.Columns["UserId"].Visible = false;
            }
        }

        private void SupervisorForm_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            SubmissionDetails selected = (SubmissionDetails)dgvSubmittedDetails.CurrentRow.DataBoundItem;
            TempData.VerifySubmissionDetails = selected;

            ManageForm.VerifySubmission = new VerifySubmission();
            ManageForm.VerifySubmission.Show();
            this.Hide();
        }

        private void dgvSubmittedDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnVerify.Enabled = true;
        }

        private void SupervisorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
