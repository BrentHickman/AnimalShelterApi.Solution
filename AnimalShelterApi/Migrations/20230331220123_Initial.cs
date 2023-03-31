using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Species = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AgeYears = table.Column<int>(type: "int", nullable: false),
                    AgeMonths = table.Column<int>(type: "int", nullable: false),
                    Sex = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Breed = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Coloring = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateAvailable = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "AgeMonths", "AgeYears", "Breed", "Coloring", "DateAvailable", "Description", "Name", "Sex", "Species", "Weight" },
                values: new object[,]
                {
                    { 1, 6, 0, "Domestic Short Hair", "Orange/White", "4/10/2023", "Playful orange kitten Matilda came to us with her brother Rexie", "Matilda", "Female", "Cat", 3 },
                    { 2, 6, 0, "Domestic Short Hair", "Gray/White", "4/10/2023", "Mellow kitten Rexie came to us with his sister Matilda", "Rexie", "Male", "Cat", 4 },
                    { 3, 6, 2, "Boxer/Mix", "Brown/White", "4/15/2023", "Fun guy Danny loves chasing bugs and taking naps", "Danny", "Male", "Dog", 60 },
                    { 4, 9, 0, "Labrador", "Yellow", "4/16/2023", "Mary is a sweet puppy who loves playing with kittens Matilda and Rexie", "Mary", "Female", "Dog", 35 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
