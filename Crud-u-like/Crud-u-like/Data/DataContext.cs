using Crud_u_like.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crud_u_like.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ConveyanceCase> ConveyanceCase { get; set; }
        public DbSet<Client> Client { get; set; }
    }
}
