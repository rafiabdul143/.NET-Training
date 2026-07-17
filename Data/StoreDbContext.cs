using Microsoft.EntityFrameworkCore;
using GeneralStoreApp.Models;


namespace GeneralStoreApp.Data
{
    // This class represents a "session" with the database.
    // It inherits from EF Core's base DbContext class, which gives it
    // ALL the machinery for tracking, querying, and saving data.
    public class StoreDbContext : DbContext
    {
        // The constructor receives configuration (like the connection string)
        // from OUTSIDE this class — specifically from Program.cs, via
        // Dependency Injection. We don't hardcode the connection string HERE
        // on purpose (explained below).
        public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options)
        {
        }

        // This DbSet represents the ENTIRE "Products" table.
        // EF Core uses this property to know:
        // 1. Which C# class maps to which table (Product -> Products)
        // 2. This is the entry point for all queries: _context.Products...
        public DbSet<Product> Products { get; set; }
    }
}