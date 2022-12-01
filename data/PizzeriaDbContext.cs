using Microsoft.EntityFrameworkCore;
using la_mia_pizzeria_static.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace la_mia_pizzeria_static.data
{
    public class PizzeriaDbContext : IdentityDbContext<IdentityUser>
    {
        //Richiamo Tabella Pizzas
        public DbSet<Pizza> Pizzas { get; set; }

        // Richiamo Tabella Category
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public DbSet<Message> Messages { get; set; }
     

        public PizzeriaDbContext(DbContextOptions<PizzeriaDbContext> options)
      : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

    }
}
