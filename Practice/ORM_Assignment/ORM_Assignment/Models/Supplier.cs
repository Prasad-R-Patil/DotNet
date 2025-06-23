using System.ComponentModel.DataAnnotations;
using ORM_Assignment.Models.Models;


namespace ORM_Assignment.Models;

internal class Supplier
{
    [Key]
    public int SupplierId { get; set; }

    [Required(ErrorMessage = "Contact Name is a required field!")]
    [MaxLength(100)]
    public string ContactName { get; set; } = string.Empty;

    [Required(ErrorMessage = "City is a required field!")]
    [MaxLength(80)]
    public string City { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email Id is a required field!")]
    [MaxLength(100)]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    public ICollection<Product> Products { get; set; } = new List<Product>();
}
