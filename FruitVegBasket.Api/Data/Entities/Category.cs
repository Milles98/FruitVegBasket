namespace FruitVegBasket.Api.Data.Entities;

public class Category
{
    public short Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public short ParentId { get; set; }
    public string? Credit { get; }
}