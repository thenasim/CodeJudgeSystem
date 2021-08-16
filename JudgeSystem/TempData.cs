﻿using JudgeSystem.Models;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace JudgeSystem
{
    public static class TempData
    {
        public static List<InputOutput> inputOutputs = new List<InputOutput>();
        public static Problem SolvingProblem { get; set; }
        public static CompilerErrorCollection cmpErr { get; set; }
        public static string CodeOutput { get; set; }
    }
}