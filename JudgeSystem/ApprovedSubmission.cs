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
    public partial class ApprovedSubmission : Form
    {
        public ApprovedSubmission()
        {
            InitializeComponent();
        }

        private void PopulateGridView()
        {
            dgvApprovedSub.DataSource = ApprovedSubData.GetDetails(ManageUser.CurrentUser.Id);
            dgvApprovedSub.ClearSelection();

            //List<ApprovedSub> data = ApprovedSubData.GetDetails(ManageUser.CurrentUser.Id);

            //foreach(var d in data)
            //{
            //    MessageBox.Show(d.Title);
            //}
        }


        private void ApprovedSubmission_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void ApprovedSubmission_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManageForm.ProblemListsForm = new ProblemListsForm();
            ManageForm.ProblemListsForm.Show();
            this.Hide();
        }
    }
}
