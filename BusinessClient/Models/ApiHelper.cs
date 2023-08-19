using System.Threading.Tasks;
using RestSharp;

namespace BusinessClient.Models
{
  public class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("https://localhost:5001/");
      RestRequest request = new RestRequest($"api/business", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }
    public static async Task<string> GetCity(string restaurantName)
    {
      RestClient client = new RestClient("https://localhost:5001/");
      RestRequest request = new RestRequest($"api/businesses?cityName={restaurantName}", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }
    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/businesses/{id}", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }
    public static async void Post (string newBusiness)
    { 
      RestClient client = new RestClient("http://localhost:5000");
      RestRequest request = new RestRequest($"api/destinations", Method.Post);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newBusiness);
      await client.PostAsync(request);
    }
    public static async void Put(int id, string newBusiness)
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/businesses/{id}", Method.Put);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newBusiness);
      await client.PutAsync(request);
    }
    public static async void Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/");
      RestRequest request = new RestRequest($"api/businesses/{id}", Method.Delete);
      request.AddHeader("Content-Type", "application/json");
      await client.DeleteAsync(request);
    }
  }
}