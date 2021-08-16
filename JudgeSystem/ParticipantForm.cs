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

        }

        private void ParticipantForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}