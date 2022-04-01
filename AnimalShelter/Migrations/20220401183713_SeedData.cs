using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Breed",
                table: "Animals",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 7, "Lab", "Female", "Benson", "Dog" },
                    { 2, 1, "Pit Bull", "Female", "Pops", "Dog" },
                    { 3, 2, "Shiba Inu", "Female", "Trash Boat", "Dog" },
                    { 4, 4, "Spinx", "Male", "Rigby", "Cat" },
                    { 5, 3, "Greyhound", "Male", "Mordechai", "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Breed",
                table: "Animals");
        }
    }
}
