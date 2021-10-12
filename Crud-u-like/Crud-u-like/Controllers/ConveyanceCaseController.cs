using Crud_u_like.Entities;
using Crud_u_like.Services;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Crud_u_like.Models;

namespace Crud_u_like.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConveyanceCaseController : ControllerBase
    {
        private readonly IConveyanceCaseService _conveyanceCaseService;

        public ConveyanceCaseController(IConveyanceCaseService conveyanceCaseService)
        {
            _conveyanceCaseService = conveyanceCaseService;
        }

        [HttpGet]
        [Route("/[action]")]
        public IEnumerable<ConveyanceCase> GetAll()
        {
            return _conveyanceCaseService.GetAll();
        }

        [HttpGet("/[action]{id}")]
        public ConveyanceCase Get(int id)
        {
            return _conveyanceCaseService.Get(id);
        }

        [HttpPost]
        [Route("/[action]")]
        public void Post([FromBody] CreateConveyanceCaseModel conveyanceCaseModel)
        {
            _conveyanceCaseService.Post(conveyanceCaseModel);
        }

        [HttpPut]
        [Route("/[action]")]
        public void Put([FromBody] ConveyanceCase conveyanceCase)
        {
            _conveyanceCaseService.Put(conveyanceCase);
        }

        [HttpDelete]
        [Route("/[action]")]
        public void Delete(int id)
        {
            _conveyanceCaseService.Delete(id);
        }
    }
}
