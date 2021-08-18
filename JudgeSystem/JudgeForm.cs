using JudgeSystem.Data;
using JudgeSystem.Models;
using System;
using System.Windows.Forms;

namespace JudgeSystem
{
    public partial class JudgeForm : Form
    {
        private bool isUpdating = TempData.EditingProblem != null;

        public JudgeForm()
        {
            InitializeComponent();
        }

        private bool IsValidInput()
        {
            return !(String.IsNullOrEmpty(rtxtProblemTitle.Text)
                && String.IsNullOrEmpty(rtxtProblemBody.Text)
                && String.IsNullOrEmpty(rtxtTestOutput.Text)
                && String.IsNullOrEmpty(rtxtOutput.Text));
        }

        private void ClearInputFields()
        {
            rtxtProblemTitle.Text = "";
            rtxtProblemBody.Text = "";
            rtxtTestInput.Text = "";
            rtxtTestOutput.Text = "";
            rtxtInput.Text = "";
            rtxtOutput.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidInput() == false)
            {
                MessageBox.Show("One or more fields are empty");
                return;
            }

            Problem p = new Problem
            {
                Title = rtxtProblemTitle.Text,
                Body = rtxtProblemBody.Text,
                TestInput = rtxtTestInput.Text,
                TestOutput = rtxtTestOutput.Text,
            };

            if (isUpdating)
            {
                p.Id = TempData.EditingProblem.Id;
                ProblemData.UpdateProblem(p);

                ManageForm.ProblemListsForm = new ProblemListsForm();
                ManageForm.ProblemListsForm.Show();
                this.Hide();

                return;
            }

            (_, int createdId) = ProblemData.CreateProblem(p);

            InputOutput io = new InputOutput
            {
                Input = rtxtInput.Text,
                Output = rtxtOutput.Text,
                ProblemId = createdId
            };

            InputOutputData.CreateInputOutput(io);

            foreach (InputOutput moreIo in TempData.inputOutputs)
            {
                moreIo.ProblemId = createdId;
                InputOutputData.CreateInputOutput(moreIo);
            }

            TempData.inputOutputs.Clear();

            MessageBox.Show("Problem Created Successfully");
            ClearInputFields();
        }

        private void btnAddMoreIO_Click(object sender, EventArgs e)
        {
            if (ManageForm.AddMoreIOForm == null)
            {
                ManageForm.AddMoreIOForm = new AddMoreIOForm();
            }

            ManageForm.AddMoreIOForm.Show();
        }

        private void JudgeForm_Load(object sender, EventArgs e)
        {
            if (isUpdating)
            {
                rtxtProblemTitle.Text = TempData.EditingProblem.Title;
                rtxtProblemBody.Text = TempData.EditingProblem.Body;
                rtxtTestInput.Text = TempData.EditingProblem.TestInput;
                rtxtTestOutput.Text = TempData.EditingProblem.TestOutput;

                btnSave.Text = "Update";
                btnAddMoreIO.Visible = false;
            }
        }

        private void JudgeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManageForm.ProblemListsForm.Show();
            this.Hide();
        }
    }
}