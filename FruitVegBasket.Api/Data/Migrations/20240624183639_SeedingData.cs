using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FruitVegBasket.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Image", "Name", "ParentId" },
                values: new object[,]
                {
                    { (short)1, "fruits.jpg", "Fruits", (short)0 },
                    { (short)2, "seasonal_fruits.jpg", "Seasonal Fruits", (short)1 },
                    { (short)3, "exotic_fruits.jpg", "Exotic Fruits", (short)1 },
                    { (short)4, "vegetables.jpg", "Vegetables", (short)0 },
                    { (short)5, "green_vegetables.jpg", "Green Vegetables", (short)4 },
                    { (short)6, "leafy_vegetables.jpg", "Leafy Vegetables", (short)4 },
                    { (short)7, "salads.jpg", "Salads", (short)4 },
                    { (short)8, "dairy.jpg", "Dairy", (short)0 },
                    { (short)9, "milk_curd_yoghurt.jpg", "Milk, Curd & Yoghurts", (short)1 },
                    { (short)10, "butter_cheese.jpg", "Butter & Cheese", (short)1 },
                    { (short)11, "eggs_meat.jpg", "Eggs & Meat", (short)0 },
                    { (short)12, "eggs.jpg", "Eggs", (short)1 },
                    { (short)13, "meat.jpg", "Meat", (short)1 },
                    { (short)14, "seafood.jpg", "Seafood", (short)1 }
                });

            migrationBuilder.InsertData(
                table: "Offer",
                columns: new[] { "Id", "BgColor", "Code", "Description", "IsActive", "Title" },
                values: new object[,]
                {
                    { 1, "FRT30", "#ffff00", "Enjoy up to 30% off on all fruits", false, "Up to 30% off" },
                    { 2, "VEG50", "#d0f200", "Enjoy our big offer of 50% off all green vegetables", false, "Green Veg Big Sale 50% OFF" },
                    { 3, "EXT100", "#d0f200", "Flat Rs. 100 off on all exotic fruits and vegetables", false, "Flat 100 OFF" },
                    { 4, "FRT25", "#e28083", "Enjoy 25% off on all seasonal fruits", false, "25% OFF on Seasonal Fruits" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)6);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)7);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)8);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)9);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)10);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)11);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)12);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)13);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: (short)14);

            migrationBuilder.DeleteData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
