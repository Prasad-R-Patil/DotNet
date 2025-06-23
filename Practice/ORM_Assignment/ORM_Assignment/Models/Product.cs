using System.ComponentModel.DataAnnotations;


namespace ORM_Assignment.Models.Models;

internal class Product
{
    [Key]
    public int ProductId { get; set; }

    [Required(ErrorMessage = "Product name is required.")]
    [MaxLength(150)]
    public string ProductName { get; set; } = string.Empty;

    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public int SupplierId { get; set; }
    public Supplier Supplier { get; set; }

    public int ShipperId { get; set; }
    public Shipper Shipper { get; set; }
}
