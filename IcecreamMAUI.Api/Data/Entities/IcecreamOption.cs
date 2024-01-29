using System.ComponentModel.DataAnnotations;

namespace IcecreamMAUI.Api.Data.Entities;

public class IcecreamOption
{
    public int IcecreamId { get; set; }

    [Required, MaxLength(50)]
    public string Flavor { get; set; }

    [Required, MaxLength(50)]
    public string Topping { get; set; }

    public virtual Icecream Icecream { get; set; }
}
