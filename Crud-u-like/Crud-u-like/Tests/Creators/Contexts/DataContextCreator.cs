using Crud_u_like.Data;
using Microsoft.EntityFrameworkCore;

namespace Crud_u_like.Tests.Creators.Contexts
{
    internal static class DataContextCreator
    {
        internal static DataContext CreateDataContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlServer($"Server=(localdb)\\MSSQLLocalDB;Database=CrudULikeTests;Trusted_Connection=True;");
            return new DataContext(optionsBuilder.Options);
        }
    }
}
