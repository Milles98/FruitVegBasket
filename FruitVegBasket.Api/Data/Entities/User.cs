using System.Drawing;

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