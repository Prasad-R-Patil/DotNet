namespace FirstMvcApp.Models;

public class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public int Quantity { get; set; }
    public double UnitPrice { get; set; }
    public int CustomerId { get; set; }
}
