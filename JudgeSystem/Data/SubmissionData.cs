using JudgeSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace JudgeSystem.Data
{
    public class SubmissionData
    {
        public static Submission GetSubmission(int id)
        {
            string query = $@"SELECT * FROM Submissions WHERE id = '{id}';";
            SqlDataReader reader = DataAccess.GetData(query);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Submission sb = ConvertDataToSubmission(reader);

                    reader.Close();
                    return sb;
                }
            }

            reader.Close();
            return null;
        }

        public static List<Submission> GetRecentSubmissions()
        {
            List<Submission> submissions = new List<Submission>();

            string query = $@"SELECT * FROM Submissions ORDER BY [time] DESC";
            SqlDataReader reader = DataAccess.GetData(query);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    submissions.Add(ConvertDataToSubmission(reader));
                }

                reader.Close();
                return submissions;
            }

            reader.Close();
            return null;
        }

        public static List<Submission> GetSubmissionsByUserId(int id)
        {
            List<Submission> submissions = new List<Submission>();

            string query = $@"SELECT * FROM Submissions WHERE user_id = {id}";
            SqlDataReader reader = DataAccess.GetData(query);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    submissions.Add(ConvertDataToSubmission(reader));
                }

                reader.Close();
                return submissions;
            }

            reader.Close();
            return null;
        }

        public static List<Submission> GetSubmissionsByProblemId(int id)
        {
            List<Submission> submissions = new List<Submission>();

            string query = $@"SELECT * FROM Submissions WHERE problem_id = {id}";
            SqlDataReader reader = DataAccess.GetData(query);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    submissions.Add(ConvertDataToSubmission(reader));
                }

                reader.Close();
                return submissions;
            }

            reader.Close();
            return null;
        }

        public static bool CreateSubmission(Submission sb)
        {
            string query = $@"INSERT INTO Submissions (code, [result], [time], user_id, problem_id)
                VALUES (@code, @result, @time, @user_id, @problem_id);";
            SqlCommand cmd = new SqlCommand(query, DataAccess.SqlCon);

            cmd.Parameters.AddWithValue("@code", sb.Code);
            cmd.Parameters.AddWithValue("@result", sb.Result);
            cmd.Parameters.AddWithValue("@time", sb.Time);
            cmd.Parameters.AddWithValue("@user_id", sb.UserId);
            cmd.Parameters.AddWithValue("@problem_id", sb.ProblemId);

            var row = cmd.ExecuteNonQuery();

            return row == 1;
        }

        public static bool UpdateSubmission(Submission sb)
        {
            string query = $@"UPDATE Submissions SET code = '{sb.Code}', [result] = {sb.Result},
                [time] = '{sb.Time}', user_id = {sb.UserId},
                problem_id = {sb.ProblemId} WHERE id = {sb.Id};";
            var row = DataAccess.UpdateDelete(query);

            return row == 1;
        }

        public static bool DeleteSubmission(int id)
        {
            string query = $@"DELETE FROM Submissions WHERE id = {id};";
            var row = DataAccess.UpdateDelete(query);

            return row == 1;
        }

        private static Submission ConvertDataToSubmission(SqlDataReader reader)
        {
            return new Submission
            {
                Id = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("id"))),
                Code = reader.GetValue(reader.GetOrdinal("code")).ToString(),
                Result = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("result"))),
                Time = DateTime.Parse(reader.GetValue(reader.GetOrdinal("time")).ToString()),
                UserId = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("user_id"))),
                ProblemId = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("problem_id"))),
            };
        }
    }
}