using API_Basic_Security_ASP.Models;
using API_Basic_Security_ASP.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Basic_Security_ASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BeerController : ControllerBase
    {
        private readonly IBeerService _beerService;

        public BeerController(IBeerService beerService)
        {
            this._beerService = beerService;
        }

        [HttpGet]
        public async Task<IEnumerable<Beer>> Get() => await _beerService.Get();
    }
}
