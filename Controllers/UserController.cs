using Microsoft.AspNetCore.Mvc;

namespace FluxoCaixa_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Usuario 1", "Usuario 2", "Chilly", "Cool", "Mild", "Warm"
        };

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetUser")]
        public IEnumerable<User> Get()
        {
            return new User[]
            {
                new User { Name = "Teste", Role = "Comum" }
            };
        }
    }
}

