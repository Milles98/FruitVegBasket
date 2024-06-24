using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FruitVegBasket.Api.Data.Entities;

[Table(nameof(Category))]
public class Category
{
    [Key]
    public short Id { get; set; }
    [Required, MaxLength(30)]
    public string Name { get; set; }
    [Required, MaxLength(150)]
    public string Image { get; set; }
    public short ParentId { get; set; }
    [MaxLength(150)]
    public string? Credit { get; }

    public Category(short id, string name,short parentId, string image, string? credit) : this()
    {
        Id = id;
        Name = name;
        Image = image;
        ParentId = parentId;
        Credit = credit;
    }
    public Category()
    {
    }

    public static IEnumerable<Category> GetInitialCategories()
    {
        var categories = new List<Category>();

            var fruits = new List<Category>
            {
                new(1, "Fruits", 0, "fruits.jpg",
                    "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  "),
                new(2, "Seasonal Fruits", 1, "seasonal_fruits.jpg",
                    "Photo by <a href=\"https://unsplash.com/@thisisnando?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Fernando Andrade</a> on <a href=\"https://unsplash.com/photos/ripe-pineapple-fruit-nAOZCYcLND8?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  "),
                new(3, "Exotic Fruits", 1, "exotic_fruits.jpg",
                    "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  ")
            };
            categories.AddRange(fruits);

            var vegetables = new List<Category>
            {
                new(4, "Vegetables", 0, "vegetables.jpg",
                    "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  "),
                new(5, "Green Vegetables", 4, "green_vegetables.jpg",
                    "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  "),
                new(6, "Leafy Vegetables", 4, "leafy_vegetables.jpg",
                    "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  "),
                new(7, "Salads", 4, "salads.jpg",
                    "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  ")
            };
            categories.AddRange(vegetables);

            var dairy = new List<Category>
            {
                new(8, "Dairy", 0, "dairy.jpg",
                    "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  "),
                new(9, "Milk, Curd & Yoghurts", 1, "milk_curd_yoghurt.jpg",
                    "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  "),
                new(10, "Butter & Cheese", 1, "butter_cheese.jpg",
                    "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  ")
            };
            categories.AddRange(dairy);

            var eggsMeat = new List<Category>
            {
                new(11, "Eggs & Meat", 0, "eggs_meat.jpg",
                    "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  "),
                new(12, "Eggs", 1, "eggs.jpg",
                    "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  "),
                new(13, "Meat", 1, "meat.jpg",
                    "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  "),
                new(14, "Seafood", 1, "seafood.jpg",
                    "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  ")
            };
            categories.AddRange(eggsMeat);
            return categories;
    }
}