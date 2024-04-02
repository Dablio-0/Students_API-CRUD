using Microsoft.EntityFrameworkCore;
using API_CRUD.Students;

namespace API_CRUD.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=databaseStudent-CRUD.sqlite");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);

            base.OnConfiguring(optionsBuilder);

        }
    }
}
