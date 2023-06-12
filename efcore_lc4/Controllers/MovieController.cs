using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace efcore_lc4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public readonly ImovieService _movieService;
    }
}
