using System.Data;
using System.Data.SqlClient;

namespace JudgeSystem
{
    public static class DataAccess
    {
        private static readonly SqlConnection _sqlConnection = new SqlConnection(Helper.CnnVal("DBConnection"));

        public static SqlConnection SqlCon
        {
            get
            {
                if (_sqlConnection.State == ConnectionState.Closed)
                {
                    _sqlConnection.Open();
                }

                return _sqlConnection;
            }
        }

        public static SqlDataReader GetData(string queryString)
        {
            SqlCommand cmd = new SqlCommand(queryString, SqlCon);
            return cmd.ExecuteReader();
        }

        public static int UpdateDelete(string queryString)
        {
            SqlCommand cmd = new SqlCommand(queryString, SqlCon);
            return cmd.ExecuteNonQuery();
        }
    }
}