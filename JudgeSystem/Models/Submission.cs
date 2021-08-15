using System;

namespace JudgeSystem.Models
{
    public class Submission
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int Result { get; set; }
        public DateTime Time { get; set; }
        public int ProblemId { get; set; }
        public int UserId { get; set; }
    }
}