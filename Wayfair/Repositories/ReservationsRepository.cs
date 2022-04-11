using System.Collections.Generic;
using System.Data;
using Dapper;
using Wayfair.Interfaces;
using Wayfair.Models;
namespace Wayfair.Repositories
{
  public class ReservationsRepository : IRepository<Reservation, int>
  {

    private readonly IDbConnection _db;

    public ReservationsRepository(IDbConnection db)
    {
      _db = db;
    }
    public Reservation Create(Reservation reservationData)
    {
      string sql = @"
      INSERT INTO reservations
      (reservationType, reservationName, confirmationKey, reservationAddress, tripId, creatorId, cost)
      VALUES
      (@ReservationType, @ReservationName, @ConfirmationKey, @ReservationAddress, @TripId, @CreatorId, @Cost);
      SELECT LAST_INSERT_ID;";
      int id = _db.ExecuteScalar<int>(sql, reservationData);
      reservationData.Id = id;
      return reservationData;
    }

    public string Delete(int id)
    {
      throw new System.NotImplementedException();
    }

    public Reservation Edit(Reservation data)
    {
      throw new System.NotImplementedException();
    }


    public List<Reservation> GetAll()
    {
      throw new System.NotImplementedException();
    }

    public Reservation GetById(int id)
    {
      throw new System.NotImplementedException();
    }

    List<Reservation> IRepository<Reservation, int>.GetAll()
    {
      throw new System.NotImplementedException();
    }

    Reservation IRepository<Reservation, int>.GetById(int id)
    {
      throw new System.NotImplementedException();
    }
  }
}