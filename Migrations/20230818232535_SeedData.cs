using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    BusinessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RestaurantName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LocationName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShopName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Review = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.BusinessId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "LocationName", "Rating", "RestaurantName", "Review", "ShopName" },
                values: new object[,]
                {
                    { 1, "New Albany", 10, "Fox in the Snow Cafe", "Best Cafe Art in town", null },
                    { 2, "WesterVille", 9, "Kitchen Social", "Amazing chicken and waffles", null },
                    { 3, "Dublin", 8, "Kitchen Social", "Amazing chicken and waffles", null },
                    { 4, "High St", 8, "Zencha Cafe", "Masala Chai waffles were the lightest crispiest waffles ever chicken dumping looked ordinary but tasted heavenly", null },
                    { 5, "Columbus", 3, "Mozart's", "Authentic Tea Experience in Columbus", null },
                    { 6, "TownsFair Way", 10, " Northstar Café ", "This place has some of the best healthy food that I have ever tasted.", null },
                    { 7, "Easton Station", 9, " Mitchell's Ocean Club", "Best Seafood in town", null },
                    { 8, "Gahanna,", 7, " The Morning Ritual", "Great coffee & pastries, baked apple cinnamon roll is a must!", null },
                    { 9, "Westerville", 6, " Java Central Café", "Best cold brew nitro in town! Everything is awesome, especially the people.", null },
                    { 10, "Cleavland", 10, " Safari Coffee House", "One of the best Somali restaurants In Columbus", null },
                    { 11, "Kossuth St", 8, null, "Popular mall. Good selection of stores. Clean.", "Tigertree" },
                    { 12, "Olenrangy River Rd", 4, null, "Nice shops, but the traffic and parking are awful.", "Lennox Town Center" },
                    { 13, "Grandview Ave", 6, null, "Fantastic assortment of unique pieces, and a friendly group of associates!", "Vernacular - Grandview" },
                    { 14, "Channingway Center Dr", 7, null, "Large antique mall with many different sellers and reasonable pricing.", "Heritage Square Antique Mall" },
                    { 15, "Grandview Ave,", 5, null, "Upscale market. Huge variety.", "North Market Downtown" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Businesses");
        }
    }
}
