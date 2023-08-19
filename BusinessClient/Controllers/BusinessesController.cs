using Microsoft.AspNetCore.Mvc;
using BusinessClient.Models;


namespace BusinessClientClient.Controllers;

public class BusinessesController : Controller
{
  public IActionResult Index()
  {
    List<Business> businesses = Business.GetBusinesses();
    return View(businesses);
  }


public IActionResult Get(string restaurantName, string locationName,string review, int rating)
    {
        List<Business> filteredBusinesses = Business.GetBusinesses()
            .Where(d =>
                (d.RestaurantName.Contains(restaurantName)) 
                )
            .ToList();

        ViewBag.restaurantName = locationName;
        return View(filteredBusinesses);
    }

  public IActionResult Details(int id)
  {
    Business business = Business.GetDetails(id);
    return View(business);
  }
   public ActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Create(Business business)
  {
    Business.Post(business);
    return RedirectToAction("Index");
  }
  public ActionResult Edit(int id)
  {
    Business business = Business.GetDetails(id);
    return View(business);
  }

  [HttpPost]
  public ActionResult Edit(Business business)
  {
    Business.Put(business);
    return RedirectToAction("Details", new { id = business.BusinessId});
  }
  public ActionResult Delete(int id)
  {
    Business business = Business.GetDetails(id);
    return View(business);
  }

  [HttpPost, ActionName("Delete")]
  public ActionResult DeleteConfirmed(int id)
  {
    Business.Delete(id);
    return RedirectToAction("Index");
  }
}
