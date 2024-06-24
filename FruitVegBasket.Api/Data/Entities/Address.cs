namespace FruitVegBasket.Api.Data.Entities;

public class Address
{
    public long Id { get; set; }
    public int UserId { get; set; }
    public string Address1 { get; set; }
    public string? Address2 { get; set; }
    public string Zip { get; set; }
    public string? Name { get; set; }
    public bool IsPrimary { get; set; }
    public virtual User User { get; set; }
}