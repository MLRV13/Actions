using BL;
using DL;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace CountryScript
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up Dependency Injection
            var serviceProvider = new ServiceCollection()
                // Register DbContext with an in-memory database or your actual database
                .AddDbContext<DBContext>(options => options.UseSqlServer("Server=localhost;Database=CRUD;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=True"))
                .AddScoped<ICountryServices, CountryServices>() // Register the service
                .BuildServiceProvider();

            // Get the service from the DI container
            var countryService = serviceProvider.GetService<ICountryServices>();

            // Create a new country object
            var newCountry = new Country
            {
                Name = "TestAction3",
            };

            // Call the service to add the country
            if (countryService != null)
            {
                countryService.AddCountry(newCountry);
                Console.WriteLine("Country added successfully!");
            }
            else
            {
                Console.WriteLine("Country service not found!");
            }

            Console.ReadLine();
            return; // This will stop the script

        }
    }
}
