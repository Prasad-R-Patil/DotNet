using System.ComponentModel.DataAnnotations;

namespace Infoway.Api.Models;

public class Employee
{
    public int EmployeeId { get; set; }
    [Required(ErrorMessage = "Contact Name is a required field!")]
    [MaxLength(100)]
    public string EmployeeName { get; set; }=string.Empty;
    [Required(ErrorMessage = "City is a required field!")]
    [MaxLength(100)]
    public string City { get; set; } = string.Empty;
}
