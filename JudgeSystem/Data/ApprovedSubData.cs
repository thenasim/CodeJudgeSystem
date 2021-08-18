using JudgeSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace JudgeSystem.Data
{
    public class ApprovedSubData
    {
        public static List<ApprovedSub> GetDetails(int userId)
        {
            List<ApprovedSub> approvedSubs = new List<ApprovedSub>();

            string query = $@"SELECT title, [time], code 
                FROM Submissions
                JOIN Problems ON
                    Submissions.problem_id = Problems.id
                WHERE user_id = {userId} AND [result] = 2;";
            SqlDataReader reader = DataAccess.GetData(query);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    approvedSubs.Add(ConvertDataToSubmissionDetails(reader));
                }

                reader.Close();
                return approvedSubs;
            }

            reader.Close();
            return null;
        }

        private static ApprovedSub ConvertDataToSubmissionDetails(SqlDataReader reader)
        {
            return new ApprovedSub
            {
                Title = reader.GetValue(reader.GetOrdinal("title")).ToString(),
                Code = reader.GetValue(reader.GetOrdinal("code")).ToString(),
                Time = DateTime.Parse(reader.GetValue(reader.GetOrdinal("time")).ToString()),
            };
        }
    }
}