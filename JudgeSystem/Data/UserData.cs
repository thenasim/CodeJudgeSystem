using JudgeSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace JudgeSystem.Data
{
    public static class UserData
    {
        public static User GetUser(string email, string pass)
        {
            string query = $@"SELECT * FROM Users WHERE email = '{email}' AND password = '{pass}';";
            SqlDataReader reader = DataAccess.GetData(query);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    User u = ConvertDataToUser(reader);

                    reader.Close();
                    return u;
                }
            }

            reader.Close();
            return null;
        }

        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();

            string query = $@"SELECT * FROM Users";
            SqlDataReader reader = DataAccess.GetData(query);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    users.Add(ConvertDataToUser(reader));
                }

                reader.Close();
                return users;
            }

            reader.Close();
            return null;
        }

        public static bool UpdateUser(User u)
        {
            string query = $@"UPDATE Users SET name = '{u.Name}',
                address = '{u.Address}', email = '{u.Email}',
                password = '{u.Password}', [role] = '{u.Role}' WHERE id = {u.Id};";
            var row = DataAccess.UpdateDelete(query);

            return row == 1;
        }

        public static bool DeleteUser(int id)
        {
            string query = $@"DELETE FROM Users WHERE id = {id};";
            var row = DataAccess.UpdateDelete(query);

            return row == 1;
        }

        private static User ConvertDataToUser(SqlDataReader reader)
        {
            return new User
            {
                Id = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("id"))),
                Name = reader.GetValue(reader.GetOrdinal("name")).ToString(),
                Address = reader.GetValue(reader.GetOrdinal("address")).ToString(),
                Email = reader.GetValue(reader.GetOrdinal("email")).ToString(),
                Password = reader.GetValue(reader.GetOrdinal("password")).ToString(),
                Role = reader.GetValue(reader.GetOrdinal("role")).ToString()
            };
        }
    }
}