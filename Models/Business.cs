using System.ComponentModel.DataAnnotations;
//Resturants and Shops in town.
namespace BusinessAPI.Models
{
  public class Business
  {
    public int BusinessId { get; set; }
    public string RestaurantName { get; set; }
    public string LocationName { get; set; }
    public string Review { get; set; }
    public int Rating { get; set; }

  }
}