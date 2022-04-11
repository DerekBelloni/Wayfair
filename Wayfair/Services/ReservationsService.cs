using Wayfair.Models;
using Wayfair.Repositories;

namespace Wayfair.Services
{
  public class ReservationsService
  {
    private readonly ReservationsRepository _rRepo;

    public ReservationsService(ReservationsRepository rRepo)
    {
      _rRepo = rRepo;
    }

    internal Reservation Create(Reservation reservationData)
    {
      return _rRepo.Create(reservationData);
    }
  }
}