using System;

namespace JudgeSystem.ViewModel
{
    public class SubmissionDetails
    {
        public int ProblemId { get; set; }
        public int SubmissionId { get; set; }
        public int UserId { get; set; }
        public string ProblemTitle { get; set; }
        public string ProblemBody { get; set; }
        public string ProblemTestInput { get; set; }
        public string ProblemTestOutput { get; set; }
        public string UserName { get; set; }
        public string SubmittedCode { get; set; }
        public DateTime SubmissionTime { get; set; }
    }
}