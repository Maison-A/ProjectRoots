using Microsoft.EntityFrameworkCore;
using System;

// 1. Namespace declaration: Adjust this to whatever your project namespace is.
namespace ProjectRoots.Models
{
    // 2. Your ProjectRootsDb class extends the DbContext class provided by EntityFramework
    public class ProjectRootsDb : DbContext
    {
        // 3. Constructor that takes options: These options can include your connection string, database provider details, etc.
        public ProjectRootsDb(DbContextOptions<ProjectRootsDb> options) : base(options) { }

        // 4. DbSets: Each DbSet represents a table in database
        // For now, I'm just adding a placeholder for a "User" entity.
        public DbSet<User> Users { get; set; }
        
        // add more DbSets for other entities

        // 5. Fluent API configurations (optional and advanced): 
        // If you decide to go deep with EF configurations, this method is where you'd put them.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Example: If you want to set up a composite key for the User entity.
            // modelBuilder.Entity<User>().HasKey(u => new { u.SomeKey, u.AnotherKey });
        }
    }
    
    // define entities that represent the data I want to store
    public class User
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string userEmail {get; set;}
        public string userPassword {get; set;}
        public string userRole {get; set;}
        // any other properties related to the User
    }
    
}
