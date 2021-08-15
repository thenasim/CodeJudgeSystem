namespace JudgeSystem.Models
{
    public class Problem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string TestInput { get; set; }
        public string TestOutput { get; set; }
    }
}