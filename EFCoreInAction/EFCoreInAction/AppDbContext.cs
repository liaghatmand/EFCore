using EFCoreInAction.Data;
using Microsoft.EntityFrameworkCore;

namespace EFCoreInAction
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"Server=DESKTOP-HQTJSPJ;
                Database=MyFirstEfCoreDb;
                User Id=sa;
                Password=123;
                TrustServerCertificate=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Book> Books { get; set; }
    }
}
