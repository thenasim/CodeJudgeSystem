using System;
using System.CodeDom.Compiler;
using System.Windows.Forms;

namespace JudgeSystem
{
    public partial class CodeError : Form
    {
        public CodeError()
        {
            InitializeComponent();
        }

        private void CodeError_Load(object sender, EventArgs e)
        {
            if (TempData.cmpErr != null)
            {
                foreach(CompilerError compilerError in TempData.cmpErr)
                {
                    rtxtYourOutput.AppendText(Environment.NewLine + compilerError.ToString());
                }

                TempData.cmpErr = null;
                return;
            }

            rtxtYourOutput.Text = TempData.CodeOutput;
            TempData.CodeOutput = "";
        }
    }
}