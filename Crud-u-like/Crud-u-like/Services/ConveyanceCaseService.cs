using Crud_u_like.Entities;
using System.Collections.Generic;
using Crud_u_like.Repositories;
using Crud_u_like.Models;

namespace Crud_u_like.Services
{
    public class ConveyanceCaseService : IConveyanceCaseService
    {
        private readonly IConveyanceCaseRepository _conveyanceCaseRepository;

        public ConveyanceCaseService(IConveyanceCaseRepository conveyanceCaseRepository)
        {
            _conveyanceCaseRepository = conveyanceCaseRepository;
        }
        public ConveyanceCase Get(int id)
        {
            return _conveyanceCaseRepository.Get(id);
        }
        public IEnumerable<ConveyanceCase> GetAll(){
            return _conveyanceCaseRepository.GetAll();
        }
        public int Post(CreateConveyanceCaseModel conveyanceCaseModel){
            var conveyancecase = CreateCaseModelMapper.Map(conveyanceCaseModel);
            return _conveyanceCaseRepository.Post(conveyancecase);
        }
        public void Put(ConveyanceCase conveyanceCase){
            _conveyanceCaseRepository.Put(conveyanceCase);
        }
        public void Delete(int id){
            _conveyanceCaseRepository.Delete(id);
        }
    }
}
