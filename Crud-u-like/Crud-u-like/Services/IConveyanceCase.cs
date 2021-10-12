using Crud_u_like.Entities;
using System.Collections.Generic;
using Crud_u_like.Models;

namespace Crud_u_like.Services
{
    public interface IConveyanceCaseService
    {
        ConveyanceCase Get(int id);
        IEnumerable<ConveyanceCase> GetAll();
        int Post(CreateConveyanceCaseModel conveyanceCaseModel);
        void Put(ConveyanceCase conveyanceCase);
        void Delete(int id);
    }
}
