using Microsoft.EntityFrameworkCore;
using PacienteDLL.Patients;

namespace PacienteDLL.SqlConn
{
    public class SqlServerConn : DbContext
    {
        public DbSet<Patient> Patients { get; set; }

        private static string server = @"DESKTOP-VRGVGLR\SQLEXPRESSSERVER";
        private static string database = "Hospital";
        private static string user = "sa";
        private static string password = "sa12345";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                $@"Server={server};Database={database};User={user};Pwd={password}");
        }

    }
}
