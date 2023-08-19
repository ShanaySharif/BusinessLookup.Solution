using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BusinessClient.Models
{
  public class Business
  {
    public int BusinessId { get; set; }

    public string RestaurantName { get; set; }
    public string LocationName { get; set; }
    public string Review { get; set; }
    public int Rating { get; set; }
    
    public static List<Business> GetBusinesses()
    {
        var apiCallTask = ApiHelper.GetAll();
        var result = apiCallTask.Result;

        JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
        List<Business> businessList = JsonConvert.DeserializeObject<List<Business>>(jsonResponse.ToString());

        return businessList;
    }
    public static Business GetDetails(int id)
    {
        var apiCallTask = ApiHelper.Get(id);
        var result = apiCallTask.Result;

        JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
        Business business = JsonConvert.DeserializeObject<Business>(jsonResponse.ToString());

        return business;
    }
    public static void Post(Business business)
    {
      string jsonDestination = JsonConvert.SerializeObject(business);
      ApiHelper.Post(jsonBusiness);
    }
    public static void Put(Business business)
    {
      string jsonBusiness = JsonConvert.SerializeObject(business);
      ApiHelper.Put(business.BusinessId, jsonBusiness);
    }
    public static void Delete(int id)
    {
      ApiHelper.Delete(id);
    }
  }
}