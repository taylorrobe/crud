using Crud_u_like.Data;
using Crud_u_like.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Crud_u_like.Repositories
{
    public class ConveyanceCaseRepository : IConveyanceCaseRepository
    {
        private readonly DataContext _dataContext;
        public ConveyanceCaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public ConveyanceCase Get(int id)
        {
            var conveyanceCase = _dataContext.ConveyanceCase.FirstOrDefault(it => it.Id == id);
            if (conveyanceCase == null) throw new Exception($"conveyanceCase with id {id} does not exist");
            return conveyanceCase;
        }
        public IEnumerable<ConveyanceCase> GetAll()
        {
            return _dataContext.ConveyanceCase.ToList();
        }
        public int Post(ConveyanceCase conveyanceCase)
        {
            var entity = _dataContext.ConveyanceCase.Add(conveyanceCase);
            _dataContext.SaveChanges();
            return entity.Entity.Id;
        }
        public void Put(ConveyanceCase conveyanceCase)
        {
            _dataContext.Update(conveyanceCase);
            _dataContext.SaveChanges();
        }
        public void Delete(int id)
        {
            var conveyanceCase = Get(id);
            if (conveyanceCase == null) throw new Exception($"conveyanceCase with id {id} does not exist");
            _dataContext.Remove(conveyanceCase);
            _dataContext.SaveChanges();
        }
    }
}
