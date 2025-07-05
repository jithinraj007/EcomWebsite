using Microsoft.EntityFrameworkCore;
using BulkyWebRazor_Temp.Models;

namespace BulkyWebRazor_Temp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSet properties go here
        public DbSet<Category> Category { get; set; }
    }
}
