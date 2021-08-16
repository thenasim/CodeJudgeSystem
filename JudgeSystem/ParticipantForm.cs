using JudgeSystem.Data;
using JudgeSystem.Models;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JudgeSystem
{
    public partial class ParticipantForm : Form
    {
        public ParticipantForm()
        {
            InitializeComponent();
        }

        private void ParticipantForm_Load(object sender, System.EventArgs e)
        {
            if (TempData.SolvingProblem == null)
            {
                MessageBox.Show("No Problem Selected");
                ManageForm.ProblemListsForm.Show();
                this.Hide();
            }

            rtxtProblemTitle.Text = TempData.SolvingProblem.Title;
            rtxtProblemBody.Text = TempData.SolvingProblem.Body;
            rtxtTestInput.Text = TempData.SolvingProblem.TestInput;
            rtxtTestOutput.Text = TempData.SolvingProblem.TestOutput;
        }

        private void btnRun_Click(object sender, System.EventArgs e)
        {
            InputOutput io = new InputOutput
            {
                Input = TempData.SolvingProblem.TestInput,
                Output = TempData.SolvingProblem.TestOutput
            };
            List<InputOutput> inputOutputs = new List<InputOutput>() { io };

            (string exePath, CompilerErrorCollection cmpErr) = CodeJudge.IsCodeCompiled(rtxtYourCode.Text);

            if (exePath == null)
            {
                TempData.cmpErr = cmpErr;
                ManageForm.CodeError = new CodeError();
                ManageForm.CodeError.Show();
            }
            else
            {
                (bool isVerified, string output) = CodeJudge.Verify(inputOutputs, exePath);

                if (isVerified)
                {
                    MessageBox.Show("Test case passed successfully :)");
                }
                else
                {
                    MessageBox.Show("Failed test case :(");
                    TempData.CodeOutput = output;
                    ManageForm.CodeError = new CodeError();
                    ManageForm.CodeError.Show();
                }
            }
        }

        private void btnSubmit_Click(object sender, System.EventArgs e)
        {
            List<InputOutput> inputOutputs = InputOutputData.GetInputOutputsByProblemId(TempData.SolvingProblem.Id);

            (string exePath, CompilerErrorCollection cmpErr) = CodeJudge.IsCodeCompiled(rtxtYourCode.Text);

            if (exePath == null)
            {
                TempData.cmpErr = cmpErr;
                ManageForm.CodeError = new CodeError();
                ManageForm.CodeError.Show();
            }
            else
            {
                (bool isVerified, string output) = CodeJudge.Verify(inputOutputs, exePath);

                Submission sb = new Submission
                {
                    Code = rtxtYourCode.Text,
                    Result = Convert.ToInt32(isVerified),
                    Time = DateTime.Now,
                    UserId = ManageUser.CurrentUser.Id,
                    ProblemId = TempData.SolvingProblem.Id,
                };
                SubmissionData.CreateSubmission(sb);

                if (isVerified)
                {
                    MessageBox.Show("Passed all the tests successfully :)");
                }
                else
                {
                    MessageBox.Show("One or more tests failed :(");
                    TempData.CodeOutput = output;
                    ManageForm.CodeError = new CodeError();
                    ManageForm.CodeError.Show();
                }
            }
        }

        private void ParticipantForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}