using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using BusinessAPI.Models;



namespace BusinessAPI.Controllers
{

    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessesController : ControllerBase
    {
    private readonly BusinessAPIContext _db;

        public BusinessesController(BusinessAPIContext db)
        {
            _db = db;
        }

       [HttpGet]
public async Task<ActionResult<IEnumerable<Business>>> Get(int businessId, string restaurantName, string shopName, string locationName, string review, int rating)
{
    IQueryable<Business> query = _db.Businesses.AsQueryable();

    if (restaurantName != null)
    {
        query = query.Where(entry => entry.RestaurantName == restaurantName);
    }

    if (locationName != null)
    {
        query = query.Where(entry => entry.LocationName == locationName); 
    }

    if (shopName != null)
    {
        query = query.Where(entry => entry.ShopName == shopName);
    }

    if (rating > 0)
    {
        query = query.Where(entry => entry.Rating == rating);
    }

    var businesses = await query.ToListAsync();

    if (businesses.Count == 0)
    {
        return NotFound();
    }

    return Ok(businesses);
}
[HttpPost("Search")]
    public IActionResult Get()
    {
      List<Business> businesses = _db.Businesses.ToList();
      return Ok(businesses);
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Business>> GetBusiness(int id)
    {
      Business business = await _db.Businesses.FindAsync(id);

      if (business == null)
      {
        return NotFound();
      }

      return business;
    }
    [HttpPost("Create")]
    public async Task<ActionResult<Business>> Post([FromBody] Business business)
    {
      _db.Businesses.Add(business);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetBusiness), new { id = business.BusinessId }, business);
    }
 



    }

}