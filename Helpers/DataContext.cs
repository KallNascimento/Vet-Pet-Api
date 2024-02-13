using Microsoft.EntityFrameworkCore;
using Vet_Pet_Api.Entities;

namespace Vet_Pet_Api.Helpers
{
    public class DataContext:DbContext
    {
        protected readonly IConfiguration Configuration;
        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //Connect to postgres  with connectionstring  from app settings
            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("Default"));
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Product> Products { get; set; }


    }
}
