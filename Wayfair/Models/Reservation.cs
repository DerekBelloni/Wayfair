namespace Wayfair.Models
{
  public class Reservation : Virtual<int>
  {
    public string ReservationType { get; set; }

    public string ReservationName { get; set; }

    public string ConfirmationKey { get; set; }

    public string ReservationAddress { get; set; }

    public int TripId { get; set; }
    public string CreatorId { get; set; }

    public string Cost { get; set; }





  }
}