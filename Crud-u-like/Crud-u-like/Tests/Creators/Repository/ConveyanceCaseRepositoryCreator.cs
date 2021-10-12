using Crud_u_like.Repositories;
using Crud_u_like.Tests.Creators.Contexts;
using Crud_u_like.Entities;
using System.Linq;

namespace Crud_u_like.Tests.Creators.Repository
{
    public class ConveyanceCaseRepositoryCreator
    {
        internal static ConveyanceCaseRepository CreateRepository()
        {
            
            return new ConveyanceCaseRepository(DataContextCreator.CreateDataContext());
        }

        internal static ConveyanceCase GetConveyanceCase(int id)
        {
            var dataContext = DataContextCreator.CreateDataContext();
            return dataContext.ConveyanceCase.FirstOrDefault(it=>it.Id == id);
        }
    }
}
