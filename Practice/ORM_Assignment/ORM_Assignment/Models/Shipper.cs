using System.ComponentModel.DataAnnotations;
using ORM_Assignment.Models.Models;



namespace ORM_Assignment.Models;

internal class Shipper
{
    [Key]
    public int ShipperId { get; set; }

    [Required(ErrorMessage = "Company Name is a required field!")]
    [MaxLength(100)]
    public string CompanyName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Phone number is a required field!")]
    [Phone(ErrorMessage = "Invalid phone number format.")]
    [MaxLength(20)]
    public string Phone { get; set; } = string.Empty;

    public ICollection<Product> Products { get; set; } = new List<Product>();
}
