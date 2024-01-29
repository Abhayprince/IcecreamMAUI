using System.ComponentModel.DataAnnotations;

namespace IcecreamMAUI.Api.Data.Entities;

public class OrderItem
{
    [Key]
    public long Id { get; set; }

    public long OrderId { get; set; }

    public int IcecreamId { get; set; }

    [Required, MaxLength(50)]
    public string Name { get; set; }

    [Range(0.1, double.MaxValue)]
    public double Price { get; set; }

    [Range(1, 100)]
    public int Quantity { get; set; }

    [Required, MaxLength(50)]
    public string Flavor { get; set; }

    [Required, MaxLength(50)]
    public string Topping { get; set; }

    [Range(0.1, double.MaxValue)]
    public double TotalPrice { get; set; }

    public virtual Order Order { get; set; }
}