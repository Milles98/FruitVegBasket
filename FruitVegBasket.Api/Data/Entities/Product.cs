using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FruitVegBasket.Api.Data.Entities;

[Table(nameof(Product))]
public class Product
{
    [Key]
    public int Id { get; set; }
    [Required, MaxLength(50)]
    public string Name { get; set; }
    [Required, MaxLength(150)]
    public  string Image { get; set; }
    [Required]
    public decimal Price { get; set; }

    public short CategoryId { get; set; }
    public virtual Category Category { get; set; }
}