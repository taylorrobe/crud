using Crud_u_like.Services;
using Testify;
using Crud_u_like.Tests.Creators.Repository;

namespace Crud_u_like.Tests.Creators.Service
{
    internal static class ConveyanceCaseServiceCreator
    {
        internal static ConveyanceCaseService CreateService()
        {
            return new ConveyanceCaseService(ConveyanceCaseRepositoryCreator.CreateRepository());
        }
    }
}
