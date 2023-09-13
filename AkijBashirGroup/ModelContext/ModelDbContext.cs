using AkijBashirGroup.Models;
using Microsoft.EntityFrameworkCore;

namespace AkijBashirGroup.ModelContext
{
   

    public class ModelDbContext : DbContext
    {
        public ModelDbContext(DbContextOptions options) : base(options)
        {
        }
       
        public DbSet<User>? Users { get; set; }
       
    }
}
