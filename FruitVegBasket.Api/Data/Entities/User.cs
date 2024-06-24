using System.Drawing;
using FruitVegBasket.Shared.Enumerations;

namespace FruitVegBasket.Api.Data.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
    public short RoleId { get; set; }
    //will remove password not good but using for simplicity
    public string Password { get; set; }
    public virtual Role Role { get; set; }
    public virtual ICollection<Address> Addresses { get; set; }
}

public class Role
{
    public short Id { get; set; }
    public string Name { get; set; }
}

public class Category
{
    public short Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public short ParentId { get; set; }
    public string? Credit { get; }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public decimal Price { get; set; }

    public short CategoryId { get; set; }
    public virtual Category Category { get; set; }
}

public class Order
{
    public long Id { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public decimal TotalAmount { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.Placed;
    public ICollection<OrderItem> OrderItems { get; set; }
}

public class OrderItem
{
    public Guid Id { get; set; }
    public long OrderId { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }
    public decimal Amount { get; set; }
    public virtual Product Product { get; set; }
    public virtual Order Order { get; set; }
}

public class Offer
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Code { get; set; }
    public string BgColor { get; set; }
}

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