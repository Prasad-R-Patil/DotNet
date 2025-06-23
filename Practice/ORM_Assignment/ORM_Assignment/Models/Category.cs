using System.ComponentModel.DataAnnotations;
using ORM_Assignment.Models.Models;



namespace ORM_Assignment.Models;

internal class Category
{
    [Key]
    public int CategoryId { get; set; }

    [Required(ErrorMessage = "Category name is required.")]
    [MaxLength(100)]
    public string CategoryName { get; set; } = string.Empty;

    [MaxLength(250)]
    public string? Description { get; set; }

    public ICollection<Product> Products { get; set; } = new List<Product>();
}
