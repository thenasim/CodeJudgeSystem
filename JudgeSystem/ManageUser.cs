using JudgeSystem.Models;

namespace JudgeSystem
{
    public static class ManageUser
    {
        public static User CurrentUser { get; set; }

        public static bool IsAdmin(User u)
        {
            return u.Role == "ADMIN";
        }
        
        public static bool IsJudge(User u)
        {
            return u.Role == "JUDGE";
        }

        public static bool IsParticpant(User u)
        {
            return u.Role == "PARTICIPANT";
        }
    }
}