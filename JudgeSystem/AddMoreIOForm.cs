using JudgeSystem.Models;
using System;
using System.Windows.Forms;

namespace JudgeSystem
{
    public partial class AddMoreIOForm : Form
    {
        public AddMoreIOForm()
        {
            InitializeComponent();
        }

        private bool IsValidInput()
        {
            return !String.IsNullOrEmpty(rtxtOutput.Text);
        }

        private void ClearInputFields()
        {
            rtxtInput.Text = "";
            rtxtOutput.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidInput() == false)
            {
                MessageBox.Show("Required fields are empty");
                return;
            }

            TempData.inputOutputs.Add(new InputOutput { Input = rtxtInput.Text, Output = rtxtOutput.Text });
            ClearInputFields();
            btnAdd.Text = "Add More";
        }
    }
}