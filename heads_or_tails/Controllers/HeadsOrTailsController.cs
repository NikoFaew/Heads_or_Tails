using Microsoft.AspNetCore.Mvc;

namespace heads_or_tails.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeadsOrTailsController : ControllerBase
    {
        private static readonly string[] coinSide = new[]
        {
            "Heads", "Tails"
    };

        private readonly ILogger<HeadsOrTailsController> _logger;

        public HeadsOrTailsController(ILogger<HeadsOrTailsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetHeadsOrTails")]
        public IEnumerable<HeadsOrTails> Get()
        {
            return Enumerable.Range(1, 1).Select(index => new HeadsOrTails
            {
                coinSide = coinSide[Random.Shared.Next(coinSide.Length)]
            })
            .ToArray();
        }
    }
}