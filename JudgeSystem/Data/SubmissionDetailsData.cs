using JudgeSystem.Models;
using JudgeSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace JudgeSystem.Data
{
    public class SubmissionDetailsData
    {
        public static List<SubmissionDetails> GetDetails()
        {
            List<SubmissionDetails> submissionDetails = new List<SubmissionDetails>();

            string query = $@"SELECT name, code, [result], [time], title,
                body, testinput, testoutput,
                Submissions.id AS sid,
                Problems.id AS pid,
                Users.id AS uid
                FROM Submissions
                JOIN Problems ON
                    Submissions.problem_id = Problems.id
                JOIN Users ON
                    Submissions.user_id = Users.id;";
            SqlDataReader reader = DataAccess.GetData(query);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    submissionDetails.Add(ConvertDataToSubmissionDetails(reader));
                }

                reader.Close();
                return submissionDetails;
            }

            reader.Close();
            return null;
        }

        private static SubmissionDetails ConvertDataToSubmissionDetails(SqlDataReader reader)
        {
            return new SubmissionDetails
            {
                ProblemId = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("pid"))),
                UserId = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("uid"))),
                SubmissionId = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("sid"))),
                UserName = reader.GetValue(reader.GetOrdinal("name")).ToString(),
                SubmittedCode = reader.GetValue(reader.GetOrdinal("code")).ToString(),
                ProblemTitle = reader.GetValue(reader.GetOrdinal("title")).ToString(),
                ProblemBody = reader.GetValue(reader.GetOrdinal("body")).ToString(),
                ProblemTestInput = reader.GetValue(reader.GetOrdinal("testinput")).ToString(),
                ProblemTestOutput = reader.GetValue(reader.GetOrdinal("testoutput")).ToString(),
                SubmissionTime = DateTime.Parse(reader.GetValue(reader.GetOrdinal("time")).ToString()),
            };
        }
    }
}