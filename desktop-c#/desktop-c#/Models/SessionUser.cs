using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop_c_.Models
{
    public static class SessionUser
    {
        public static int IdPetugas { get; set; }
        public static string Username { get; set; }
        public static string NamaPetugas { get; set; }
        public static string Level { get; set; }
        public static bool IsLoggedIn { get;  set; }

        public static void SetSession(int id, string user, string nama, string level)
        {
            IdPetugas = id;
            Username = user;
            NamaPetugas = nama;
            Level = level;
            IsLoggedIn = true;
        }

        public static void ClearSession()
        {
            IdPetugas = 0;
            Username = "";
            NamaPetugas = "";
            Level = "";
            IsLoggedIn = false;
        }

        public static bool IsAdmin() => Level == "admin";
    }
}
