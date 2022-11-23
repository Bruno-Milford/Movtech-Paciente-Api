using HospitalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalApi.Data
{
    public class Context : DbContext
    {
        public DbSet<Patient> Patients { get; set; }

        public DbSet<Hospitalization> Hospitalizations { get; set; }

        public DbSet<Movement> Movements { get; set; }

        public DbSet<CostCenter> costCenters { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) { }

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
