namespace WhyLinq.Models;

internal class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime RequiredDate { get; set; }
    public int Quantity { get; set; }
    public double UnitPrice { get; set; }
    public int CustomerId { get; set; }
    public int EmployeeId { get; set; }
    public int ProductId { get; set; }
}
