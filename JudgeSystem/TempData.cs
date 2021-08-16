using JudgeSystem.Models;
using System.Collections.Generic;

namespace JudgeSystem
{
    public static class TempData
    {
        public static List<InputOutput> inputOutputs = new List<InputOutput>();
        public static Problem SolvingProblem;
    }
}