using HospitalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalApi.Data
{
    public class PatientsContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }

        public PatientsContext(DbContextOptions<PatientsContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ServerConnection"));
        }
    }
}
