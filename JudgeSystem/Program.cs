using System;
using System.Windows.Forms;

namespace JudgeSystem
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CodeRunResultForm());
            //Application.Run(new AdminForm());
            //Application.Run(new JudgeForm());
            //Application.Run(new ParticipantForm());
            //Application.Run(new AddMoreIOForm());
            //Application.Run(new LoginForm());
            Application.Run(new ProblemListsForm());
        }
    }
}