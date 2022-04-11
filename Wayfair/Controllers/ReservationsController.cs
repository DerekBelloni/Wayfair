using System.Threading.Tasks;
using CodeWorks.Auth0Provider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Wayfair.Models;
using Wayfair.Services;

namespace Wayfair.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ReservationsController : ControllerBase
  {
    private readonly ReservationsService _reservationsService;


    public ReservationsController(ReservationsService reservationsService)
    {
      _reservationsService = reservationsService;
    }

    [HttpPost]
    [Authorize]
    public async Task<ActionResult<Reservation>> Create([FromBody] Reservation reservationData)
    {
      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
        reservationData.CreatorId = userInfo.Id;
        Reservation reservation = _reservationsService.Create(reservationData);
        return Ok(reservation);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}