using JudgeSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static Problem GetProblemLastId()
        {
            string query = $@"SELECT TOP 1 * FROM Problems ORDER BY id DESC;";
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

        public static List<Problem> GetProblems()
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

        public static (bool created, int lastId) CreateProblem(Problem p)
        {
            string query = $@"INSERT INTO Problems (title, body, testinput, testoutput)
                VALUES (@title, @body, @testinput, @testoutput)";
            SqlCommand cmd = new SqlCommand(query, DataAccess.SqlCon);

            cmd.Parameters.AddWithValue("@title", p.Title);
            cmd.Parameters.AddWithValue("@body", p.Body);
            cmd.Parameters.AddWithValue("@testinput", p.TestInput);
            cmd.Parameters.AddWithValue("@testoutput", p.TestOutput);

            var row = cmd.ExecuteNonQuery();

            return (row == 1, GetProblemLastId().Id);
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