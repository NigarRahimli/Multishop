using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MultiShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multishop.DataAccess.Concrete.EntityFramework
{
    public class AppDbContext:IdentityDbContext<User>
    {
        //It is derived from the IdentityDbContext<User> class,
        //where "User" represents the user entity class used for authentication and authorization purposes.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {  
            optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;Database=K401MultiShop; User Id=SA; Password=yourStrong(!)Password;TrustServerCertificate=True;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet <CategoryLanguage> CategoryLanguages{ get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductLanguage> ProductLanguages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Picture> Pictures { get; set; }

        /*The "Categories" property is declared as a DbSet<Category>. 
         * This property represents a collection of entities of type "Category" in the database. 
         * DbSet provides a way to query, insert, update, and delete entities in the corresponding database table.*/
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().ToTable("Users");
            // method call configures the "User" entity to be mapped to a database table named "Users" instead of the default table name.
            builder.Entity<IdentityRole>().ToTable("Roles");
        }

    }
}
