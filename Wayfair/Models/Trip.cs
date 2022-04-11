namespace Wayfair.Models
{
  public class Trip : Virtual<int>
  {
    public string TripName { get; set; }

    public string CreatorId { get; set; }


  }
}