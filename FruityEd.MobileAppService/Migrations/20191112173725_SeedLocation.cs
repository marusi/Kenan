using Microsoft.EntityFrameworkCore.Migrations;

namespace FruityEd.MobileAppService.Migrations
{
    public partial class SeedLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Mombasa')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Kwale')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Kilifi')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Tana River')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Lamu')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Taita-Taveta')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Garissa')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Wajir')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Mandera')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Isiolo')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Meru')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Tharaka-Nithi')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Embu')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Kitui')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Machakos')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Makueni')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Nyandarua')");

            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Nyeri')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Kirinyaga')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Muranga')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Kiambu')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Turkana')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('West Pokot')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Samburu')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Trans-Nzoia')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Uasin Gishu')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Elgeyo-Marakwet')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Nandi')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Baringo')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Laikipia')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Nakuru')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Narok')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Kajiado')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Kericho')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Bomet')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Kakamega')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Vihiga')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Bungoma')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Busia')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Siaya')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Kisumu')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Homa Bay')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Migori')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Kisii')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Nyamira')");
            migrationBuilder.Sql("INSERT INTO Locations (Name) VALUES ('Nairobi')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
            name: "Locations");
        }
    }
}
