using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Assignment_3_Ellie_Tew.Models;

namespace Assignment_3_Ellie_Tew.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Assignment_3_Ellie_Tew.Models.Movies>? Movies { get; set; }
        public DbSet<Assignment_3_Ellie_Tew.Models.Actors>? Actors { get; set; }
        public DbSet<Assignment_3_Ellie_Tew.Models.MoviesActors>? MoviesActors { get; set; }

    }
}