using JudgeSystem.Models;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JudgeSystem
{
    public static class CodeJudge
    {
        private static string _codePath = Path.GetTempPath();

        public static (bool result, string output) Verify(List<InputOutput> inputOutputs, in string exePath)
        {
            bool result = true;

            foreach (InputOutput io in inputOutputs)
            {
                string codeOutput = RunExecutable(exePath, io.Input.Trim());
                string trimmedCodeOutput = codeOutput.Trim();
                string trimmedIoOut = io.Output.Trim();

                trimmedCodeOutput = Regex.Replace(trimmedCodeOutput, @"\n|\r\n", Environment.NewLine);
                trimmedIoOut = Regex.Replace(trimmedIoOut, @"\n|\r\n", Environment.NewLine);

                result = (trimmedCodeOutput == trimmedIoOut);

                if (result == false)
                {
                    return (result, trimmedCodeOutput);
                }
            }

            return (result, "");
        }

        public static (string exePath, CompilerErrorCollection cmpErr) IsCodeCompiled(string code)
        {
            const string fileName = "CodeJudge.cs";
            string fullFilePath = Path.Combine(_codePath, fileName);

            File.WriteAllText(fullFilePath, AddLibraryToCode(code));

            (string exePath, CompilerErrorCollection cmpErr) = CompileExecutable(fullFilePath);

            return (exePath, cmpErr);
        }

        private static string AddLibraryToCode(string code)
        {
            string lib = "using System;\nusing System.Collections.Generic;\npublic class Program {";
            return $"{lib}\n\n{code}\n}}";
        }

        private static string RunExecutable(string exePath, string input)
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.FileName = exePath;
            process.Start();

            StreamWriter streamWriter = process.StandardInput;
            streamWriter.WriteLine(input);

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit(2000);

            return output;
        }

        private static (string exePath, CompilerErrorCollection cmpErr) CompileExecutable(String filePath)
        {
            FileInfo sourceFile = new FileInfo(filePath);
            CodeDomProvider provider = null;
            string compiledExeBinary = null;
            CompilerErrorCollection cmpErr = null;

            if (sourceFile.Extension.ToUpper(CultureInfo.InvariantCulture) == ".CS")
            {
                provider = CodeDomProvider.CreateProvider("CSharp");
            }
            else if (sourceFile.Extension.ToUpper(CultureInfo.InvariantCulture) == ".VB")
            {
                provider = CodeDomProvider.CreateProvider("VisualBasic");
            }
            else
            {
                MessageBox.Show("Source file must have a .cs or .vb extension");
            }

            if (provider != null)
            {
                String exeName = String.Format(@"{0}\{1}.exe",
                    System.Environment.CurrentDirectory,
                    sourceFile.Name.Replace(".", "_"));

                CompilerParameters cp = new CompilerParameters
                {
                    GenerateExecutable = true,
                    OutputAssembly = exeName,
                    GenerateInMemory = false,
                    TreatWarningsAsErrors = false
                };

                CompilerResults cr = provider.CompileAssemblyFromFile(cp,
                    filePath);

                if (cr.Errors.Count > 0)
                {
                    cmpErr = cr.Errors;
                }
                else
                {
                    compiledExeBinary = cr.PathToAssembly;
                }
            }

            return (compiledExeBinary, cmpErr);
        }
    }
}