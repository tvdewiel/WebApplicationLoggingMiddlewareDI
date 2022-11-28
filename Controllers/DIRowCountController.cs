using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationLoggingMiddlewareDI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DIRowCountController : ControllerBase
    {
        private readonly DIDatabaseContext _context;
        private readonly DIRepository _repository;
        private readonly ILogger _logger;

        public DIRowCountController(/*DIDatabaseContext context, */DIRepository repository, ILogger<DIRowCountController> logger)
        {
            _context = new DIDatabaseContext(); //context;
            _repository = repository;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Get()
        {
            string msg = $"context : {_context.RowCount}, repo:{_repository.RowCount}";
            _logger.LogInformation(msg);
            return Ok(msg);
        }
    }
}
