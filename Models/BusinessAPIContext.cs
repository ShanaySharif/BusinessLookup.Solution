using Microsoft.EntityFrameworkCore;


namespace BusinessAPI.Models
{
  public class BusinessAPIContext : DbContext
  {
    public DbSet<Business> Businesses { get; set; }

    public BusinessAPIContext(DbContextOptions<BusinessAPIContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>()
        .HasData(
          new Business { BusinessId = 1, RestaurantName = "Fox in the Snow Cafe", LocationName = "New Albany", Review = "Best Cafe Art in town", Rating = 10}, 

          new Business { BusinessId = 2, RestaurantName = "Kitchen Social", LocationName = "WesterVille", Review = "Amazing chicken and waffles", Rating = 9}, 

          new Business { BusinessId = 3, RestaurantName = "Kitchen Social", LocationName = "Dublin", Review = "Amazing chicken and waffles", Rating = 8}, 

          new Business { BusinessId = 4, RestaurantName = "Zencha Cafe", LocationName = "High St", Review = "Masala Chai waffles were the lightest crispiest waffles ever chicken dumping looked ordinary but tasted heavenly", Rating = 8}, 


          new Business { BusinessId = 5, RestaurantName = "Mozart's", LocationName = "Columbus", Review = "Authentic Tea Experience in Columbus", Rating = 3},


           new Business { BusinessId = 6, RestaurantName = " Northstar Café ", LocationName = "TownsFair Way", Review = "This place has some of the best healthy food that I have ever tasted.", Rating = 10},

           new Business { BusinessId = 7, RestaurantName = " Mitchell's Ocean Club", LocationName = "Easton Station", Review = "Best Seafood in town", Rating = 9},

           new Business { BusinessId = 8, RestaurantName = " The Morning Ritual", LocationName = "Gahanna,", Review = "Great coffee & pastries, baked apple cinnamon roll is a must!", Rating = 7},


           new Business { BusinessId = 9, RestaurantName = " Java Central Café", LocationName = "Westerville", Review = "Best cold brew nitro in town! Everything is awesome, especially the people.", Rating = 6},


           new Business { BusinessId = 10, RestaurantName = " Safari Coffee House", LocationName = "Cleavland", Review = "One of the best Somali restaurants In Columbus", Rating = 10},


           new Business { BusinessId = 11, ShopName = "Tigertree", LocationName = "Kossuth St", Review = "Popular mall. Good selection of stores. Clean.", Rating = 8},

           new Business { BusinessId = 12, ShopName = "Lennox Town Center", LocationName = "Olenrangy River Rd", Review = "Nice shops, but the traffic and parking are awful.", Rating = 4},

           new Business { BusinessId = 13, ShopName = "Vernacular - Grandview", LocationName = "Grandview Ave", Review = "Fantastic assortment of unique pieces, and a friendly group of associates!", Rating = 6},


           new Business { BusinessId = 14, ShopName = "Heritage Square Antique Mall", LocationName = "Channingway Center Dr", Review = "Large antique mall with many different sellers and reasonable pricing.", Rating = 7},

           new Business { BusinessId = 15, ShopName = "North Market Downtown", LocationName = "Grandview Ave,", Review = "Upscale market. Huge variety.", Rating = 5}
        );

    }
  }
}