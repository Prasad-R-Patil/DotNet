namespace eCommerce.Models;

public class CartViewModel
{
    public int ProductId { get; set; }                   
    public string ProductName { get; set; } = string.Empty;
    public string CategoryName { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public string Picture { get; set; } = string.Empty;
    public double UnitPrice { get; set; }
    public int Discount { get; set; }
    public double TotalAmount { get; set; }
}