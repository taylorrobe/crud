using Crud_u_like.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Crud_u_like.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConveyanceCaseController : ControllerBase
    {
        private readonly ILogger<ConveyanceCaseController> _logger;

        public ConveyanceCaseController(ILogger<ConveyanceCaseController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ConveyanceCase> Get()
        {
            return new List<ConveyanceCase>();
        }
    }
}
