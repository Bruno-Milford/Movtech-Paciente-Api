using Microsoft.EntityFrameworkCore;
using PacienteDLL.Patients;

namespace PacienteDLL.SqlConn
{
    internal class SqlServerConn
    {
        public DbSet<Patient> Patients { get; set; }

        private static string server = @"DESKTOP-VRGVGLR\SQLEXPRESSSERVER";
        private static string database = "Hospital";
        private static string user = "sa";
        private static string password = "sa12345";

        public static string StrCon
        {
            get
            {
                return $"Data Source = {server}; Integrated Security = false; Initial Catalog = {database}; User ID = {user}; Password = {password}";
            }
        }
    }
}
