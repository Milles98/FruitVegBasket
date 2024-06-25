using System.Net.Http.Json;
using System.Text.Json;
using FruitVegBasket.Constants;
using FruitVegBasket.Models;

namespace FruitVegBasket.Services;

public class CategoryService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private IEnumerable<Category>? _categories;

    public CategoryService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async ValueTask<IEnumerable<Category>> GetCategoriesAsync()
    {
        if (_categories is null)
        {
            var httpClient = _httpClientFactory.CreateClient(AppConstants.HttpClientName);
            var response = await httpClient.GetAsync("/masters/categories");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(content))
                {
                    _categories = JsonSerializer.Deserialize<IEnumerable<Category>?>(content);
                }
            }
            else
            {
                return Enumerable.Empty<Category>();
            }


            // var categories = new List<Category>();
            //
            // var fruits = new List<Category>
            // {
            //     new(1, "Fruits", 0, "fruits.jpg",
            //         "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  "),
            //     new(2, "Seasonal Fruits", 1, "seasonal_fruits.jpg",
            //         "Photo by <a href=\"https://unsplash.com/@thisisnando?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Fernando Andrade</a> on <a href=\"https://unsplash.com/photos/ripe-pineapple-fruit-nAOZCYcLND8?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  "),
            //     new(3, "Exotic Fruits", 1, "exotic_fruits.jpg",
            //         "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  ")
            // };
            // categories.AddRange(fruits);
            //
            // var vegetables = new List<Category>
            // {
            //     new(4, "Vegetables", 0, "vegetables.jpg",
            //         "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  "),
            //     new(5, "Green Vegetables", 4, "green_vegetables.jpg",
            //         "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  "),
            //     new(6, "Leafy Vegetables", 4, "leafy_vegetables.jpg",
            //         "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  "),
            //     new(7, "Salads", 4, "salads.jpg",
            //         "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  ")
            // };
            // categories.AddRange(vegetables);
            //
            // var dairy = new List<Category>
            // {
            //     new(8, "Dairy", 0, "dairy.jpg",
            //         "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  "),
            //     new(9, "Milk, Curd & Yoghurts", 1, "milk_curd_yoghurt.jpg",
            //         "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  "),
            //     new(10, "Butter & Cheese", 1, "butter_cheese.jpg",
            //         "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  ")
            // };
            // categories.AddRange(dairy);
            //
            // var eggsMeat = new List<Category>
            // {
            //     new(11, "Eggs & Meat", 0, "eggs_meat.jpg",
            //         "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  "),
            //     new(12, "Eggs", 1, "eggs.jpg",
            //         "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  "),
            //     new(13, "Meat", 1, "meat.jpg",
            //         "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  "),
            //     new(14, "Seafood", 1, "seafood.jpg",
            //         "Photo by <a href=\"https://unsplash.com/@jkakaroto?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Jonas Kakaroto</a> on <a href=\"https://unsplash.com/photos/red-apple-fruit-beside-green-apple-and-yellow-fruit-on-brown-woven-basket-5JQH9Iqnm9o?utm_content=creditCopyText&utm_medium=referral&utm_source=unsplash\">Unsplash</a>\n  ")
            // };
            // categories.AddRange(eggsMeat);
            // _categories = categories;
        }

        return _categories;
    }

    public async ValueTask<IEnumerable<Category>> GetMainCategoriesAsync() =>
        (await GetCategoriesAsync())
        .Where(c => c.ParentId == 0);
}