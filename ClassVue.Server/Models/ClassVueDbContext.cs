using Microsoft.EntityFrameworkCore;
using ClassVue.Shared.Models;

namespace ClassVue.Server.Models
{
    public class ClassVueDbContext : DbContext
    {
        public ClassVueDbContext(DbContextOptions<ClassVueDbContext> options)
        : base(options) { }

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=classvue.db");
            }
        }
    }
}
