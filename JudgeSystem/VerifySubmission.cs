using JudgeSystem.Data;
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
    public partial class VerifySubmission : Form
    {
        public VerifySubmission()
        {
            InitializeComponent();
        }

        private void LoadSuperVisorForm()
        {
            ManageForm.SupervisorForm = new SupervisorForm();
            ManageForm.SupervisorForm.Show();
            this.Hide();
        }

        private void VerifySubmission_Load(object sender, EventArgs e)
        {
            rtxtProblemTitle.Text = TempData.VerifySubmissionDetails.ProblemTitle;
            rtxtProblemBody.Text = TempData.VerifySubmissionDetails.ProblemBody;
            rtxtTestInput.Text = TempData.VerifySubmissionDetails.ProblemTestInput;
            rtxtTestOutput.Text = TempData.VerifySubmissionDetails.ProblemTestOutput;
            rtxtSubmittedCode.Text = TempData.VerifySubmissionDetails.SubmittedCode;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (SubmissionData.ApproveSubmission(TempData.VerifySubmissionDetails.SubmissionId))
            {
                MessageBox.Show("Approved code");
                LoadSuperVisorForm();
            }
        }

        private void VerifySubmission_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadSuperVisorForm();
        }
    }
}
