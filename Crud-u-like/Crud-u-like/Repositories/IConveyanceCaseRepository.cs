using Crud_u_like.Entities;
using System.Collections.Generic;

namespace Crud_u_like.Repositories
{
    public interface IConveyanceCaseRepository
    {
        ConveyanceCase Get(int id);
        IEnumerable<ConveyanceCase> GetAll();
        int Post(ConveyanceCase conveyanceCase);
        void Put(ConveyanceCase conveyanceCase);
        void Delete(int id);
    }
}
