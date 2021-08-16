using JudgeSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace JudgeSystem.Data
{
    public class ProblemData
    {
        public static Problem GetProblem(int id)
        {
            string query = $@"SELECT * FROM Problems WHERE id = {id};";
            SqlDataReader reader = DataAccess.GetData(query);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Problem p = ConvertDataToProblem(reader);

                    reader.Close();
                    return p;
                }
            }

            reader.Close();
            return null;
        }

        public static List<Problem> GetUsers()
        {
            List<Problem> problems = new List<Problem>();

            string query = $@"SELECT * FROM Problems";
            SqlDataReader reader = DataAccess.GetData(query);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    problems.Add(ConvertDataToProblem(reader));
                }

                reader.Close();
                return problems;
            }

            reader.Close();
            return null;
        }

        public static bool UpdateProblem(Problem p)
        {
            string query = $@"UPDATE Problems SET title = '{p.Title}', body = '{p.Body}',
                testinput = '{p.TestInput}', testoutput = '{p.TestOutput}' WHERE id = {p.Id};";
            var row = DataAccess.UpdateDelete(query);

            return row == 1;
        }

        public static bool DeleteProblem(int id)
        {
            string query = $@"DELETE FROM Problems WHERE id = {id};";
            var row = DataAccess.UpdateDelete(query);

            return row == 1;
        }

        private static Problem ConvertDataToProblem(SqlDataReader reader)
        {
            return new Problem
            {
                Id = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("id"))),
                Title = reader.GetValue(reader.GetOrdinal("title")).ToString(),
                Body = reader.GetValue(reader.GetOrdinal("body")).ToString(),
                TestInput = reader.GetValue(reader.GetOrdinal("testinput")).ToString(),
                TestOutput = reader.GetValue(reader.GetOrdinal("testoutput")).ToString(),
            };
        }
    }
}