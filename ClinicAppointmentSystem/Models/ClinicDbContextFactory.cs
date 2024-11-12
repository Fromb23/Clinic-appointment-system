using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ClinicAppointmentSystem.Models
{
    public class ClinicDbContextFactory : IDesignTimeDbContextFactory<ClinicDbContext>
    {
        public ClinicDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ClinicDbContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Database=clinicdb;Username=fromb;Password=fromb123");

            return new ClinicDbContext(optionsBuilder.Options);
        }
    }
}