using JudgeSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace JudgeSystem.Data
{
    public class InputOutputData
    {
        public static InputOutput GetInputOutput(int id)
        {
            string query = $@"SELECT * FROM InputOutput WHERE id = '{id}';";
            SqlDataReader reader = DataAccess.GetData(query);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    InputOutput io = ConvertDataToInputOutput(reader);

                    reader.Close();
                    return io;
                }
            }

            reader.Close();
            return null;
        }

        public static List<InputOutput> GetInputOutputsByProblemId(int id)
        {
            List<InputOutput> inputOutputs = new List<InputOutput>();

            string query = $@"SELECT * FROM InputOutput WHERE problem_id = {id}";
            SqlDataReader reader = DataAccess.GetData(query);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    inputOutputs.Add(ConvertDataToInputOutput(reader));
                }

                reader.Close();
                return inputOutputs;
            }

            reader.Close();
            return null;
        }

        public static bool CreateInputOutput(InputOutput io)
        {
            string query = $@"INSERT INTO InputOutput ([input], [output], problem_id)
                VALUES ('{io.Input}', '{io.Output}', {io.ProblemId});";
            var row = DataAccess.UpdateDelete(query);

            return row == 1;
        }

        public static bool UpdateInputOutput(InputOutput io)
        {
            string query = $@"UPDATE InputOutput SET [input] = '{io.Input}', [output] = '{io.Output}',
                problem_id = {io.ProblemId} WHERE id = {io.Id};";
            var row = DataAccess.UpdateDelete(query);

            return row == 1;
        }

        public static bool DeleteInputOutput(int id)
        {
            string query = $@"DELETE FROM InputOutput WHERE id = {id};";
            var row = DataAccess.UpdateDelete(query);

            return row == 1;
        }

        private static InputOutput ConvertDataToInputOutput(SqlDataReader reader)
        {
            return new InputOutput
            {
                Id = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("id"))),
                Input = reader.GetValue(reader.GetOrdinal("input")).ToString(),
                Output = reader.GetValue(reader.GetOrdinal("output")).ToString(),
                ProblemId = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("problem_id"))),
            };
        }
    }
}