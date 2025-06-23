using System.ComponentModel.DataAnnotations;

namespace POOrmExample.Models;

public class Customer
{
    [Key]
    public int CustomerId { get; set; }
    [Required(ErrorMessage ="Contact Name is a required field!")]
    [MaxLength(100)]
    public string ContactName { get; set; } = string.Empty;
    [Required(ErrorMessage = "City is a required field!")]
    [MaxLength(80)]
    public string City { get; set; } = string.Empty;
    [Required(ErrorMessage = "Email Id is a required field!")]
    [MaxLength(100)]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    public ICollection<Order> Orders { get; set; }
}
