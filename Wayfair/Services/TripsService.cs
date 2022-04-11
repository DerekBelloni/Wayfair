using Wayfair.Models;
using Wayfair.Repositories;

namespace Wayfair.Services
{

  public class TripsService
  {
    private readonly TripsRepository _tRepo;

    public TripsService(TripsRepository tRepo)
    {
      _tRepo = tRepo;
    }

    internal Trip Create(Trip tripData)
    {
      return _tRepo.Create(tripData);
    }
  }
}