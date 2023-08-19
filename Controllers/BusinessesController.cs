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

//search
[HttpPost] 
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
    //create
    [HttpPost]
    public async Task<ActionResult<Business>> Post([FromBody] Business business)
    {
      _db.Businesses.Add(business);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetBusiness), new { id = business.BusinessId }, business);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Business business)
    {
      if (id != business.BusinessId)
      {
        return BadRequest();
      }

      _db.Businesses.Update(business);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!BusinessExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool BusinessExists(int id)
    {
      return _db.Businesses.Any(e => e.BusinessId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBusiness(int id)
    {
      Business business = await _db.Businesses.FindAsync(id);
      if (business == null)
      {
        return NotFound();
      }

      _db.Businesses.Remove(business);
      await _db.SaveChangesAsync();

      return NoContent();
    }
}

}