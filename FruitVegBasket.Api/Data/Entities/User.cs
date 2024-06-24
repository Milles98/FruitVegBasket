using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using FruitVegBasket.Api.Constants;
using Microsoft.EntityFrameworkCore;

namespace FruitVegBasket.Api.Data.Entities;

[Table(nameof(User))]
public class User
{
    [Key] public int Id { get; set; }
    [Required, MaxLength(20)] public string Name { get; set; }
    [Required, MaxLength(30)] public string Email { get; set; }
    [Required, MaxLength(30)] public string Mobile { get; set; }
    public short RoleId { get; set; }

    [Required, MaxLength(50)]
    [Comment("Will remove password not good but using for simplicity")]
    public string Password { get; set; }

    public virtual Role Role { get; set; }
    public virtual ICollection<Address> Addresses { get; set; }

    public static IEnumerable<User> GetInitialUsers() =>
        new List<User>
        {
            new User
            {
                Id = 1,
                Name = "Mille Elfver",
                Email = "mille.elfver98@gmail.com",
                Mobile = "1234567890",
                Password = "123456",
                RoleId = DatabaseConstants.Roles.Admin.Id
            }
        };
}