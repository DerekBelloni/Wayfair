using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Wayfair.Interfaces;
using Wayfair.Models;

namespace Wayfair.Repositories
{
  public class TripsRepository : IRepository<Trip, int>
  {

    private readonly IDbConnection _db;

    public TripsRepository(IDbConnection db)
    {
      _db = db;
    }
    public Trip Create(Trip tripData)
    {
      string sql = @"
      INSERT INTO trips
      (tripName, creatorId)
      VALUES
      (@TripName, @CreatorId);
      ";
      int id = _db.ExecuteScalar<int>(sql, tripData);
      tripData.Id = id;
      return tripData;
    }

    public string Delete(int id)
    {
      throw new NotImplementedException();
    }

    public Trip Edit(Trip data)
    {
      throw new NotImplementedException();
    }

    public List<Trip> GetAll()
    {
      throw new NotImplementedException();
    }

    public Trip GetById(int id)
    {
      throw new NotImplementedException();
    }
  }
}