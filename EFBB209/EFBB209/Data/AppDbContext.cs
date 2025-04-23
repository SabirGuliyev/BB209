using EFBB209.Models;
using Microsoft.EntityFrameworkCore;


namespace EFBB209.Data
{
    internal class AppDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=msi;database=BB209EF;trusted_connection=true;integrated security=true;encrypt=false;");
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
