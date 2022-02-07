using Application.Common;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[Route("api/travel")]
[ApiController]
public class TravelController : ControllerBase
{
    private readonly ITravelService _travelService;

    public TravelController(ITravelService travelService)
    {
        _travelService = travelService;
    }

    [HttpGet("citizentocountry")]
    public async Task<IActionResult> CanTravel([FromQuery] string citizen, [FromQuery] string country)
    {
        return Ok(await _travelService.CanTravelAsync(citizen, country));
    }
}
