using Microsoft.EntityFrameworkCore;
using ClinicAppointmentSystem.Models;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ClinicAppointmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up dependency injection for the DbContext
            var serviceProvider = new ServiceCollection()
                .AddDbContext<ClinicDbContext>(options =>
                    options.UseNpgsql("Host=localhost;Database=clinicdb;Username=your_username;Password=your_password"))
                .BuildServiceProvider();

            // Initialize the database context and perform any necessary operations
            using (var context = serviceProvider.GetRequiredService<ClinicDbContext>())
            {
                try
                {
                    context.Database.EnsureCreated();  // Ensures that the database is created if not already
                    Console.WriteLine("Database connected successfully!");
                    // You can add other database operations here, such as data retrieval or seed data
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting to the database: " + ex.Message);
                }
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}