using System.ComponentModel.DataAnnotations;

namespace IcecreamMAUI.Api.Data.Entities;

public class Order
{
    [Key]
    public long Id { get; set; }

    public DateTime OrderdAt { get; set; } = DateTime.Now;

    public Guid CustomerId { get; set; }

    [Required, MaxLength(30)]
    public string CustomerName { get; set; }

    [Required, MaxLength(100)]
    public string CustomerEmail { get; set; }

    [Required, MaxLength(150)]
    public string CustomerAddress { get; set; }

    [Range(0.1, double.MaxValue)]
    public double TotalPrice { get; set; }

    public virtual ICollection<OrderItem> Items { get; set; }
}
