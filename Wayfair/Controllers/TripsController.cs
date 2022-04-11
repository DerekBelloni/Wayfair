using System.Threading.Tasks;
using CodeWorks.Auth0Provider;
using Microsoft.AspNetCore.Mvc;
using Wayfair.Models;
using Wayfair.Services;

namespace Wayfair.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  public class TripsController : ControllerBase
  {
    private readonly TripsService _tripsService;

    public TripsController(TripsService tripsService)
    {
      _tripsService = tripsService;
    }

    [HttpPost]
    public async Task<ActionResult<Trip>> Create([FromBody] Trip tripData)
    {
      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
        Trip trip = _tripsService.Create(tripData);
        return Ok(trip);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}