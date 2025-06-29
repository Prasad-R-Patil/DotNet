using System.ComponentModel.DataAnnotations;

namespace Infoway.Api.Models;

public class Customer
{
    [Key]
    public int CustomerId { get; set; }
    [Required(ErrorMessage ="Contact Name is a required field!")]
    [MaxLength(100)]    
    public string ContactName { get; set; } = string.Empty;
    [Required(ErrorMessage = "City is a required field!")]
    [MaxLength(100)]
    public string City { get; set; } = string.Empty;
    [Required(ErrorMessage = "Contact # is a required field!")]
    [MaxLength(20)]
    public string Phone { get; set; } = string.Empty;
    [EmailAddress(ErrorMessage ="Please enter valid email Id!")]
    [Required(ErrorMessage = "Email is a required field!")]
    [MaxLength(100)]
    public string Email { get; set; } = string.Empty;
    public int Pincode { get; set; }
}
