using System.ComponentModel.DataAnnotations;

namespace ProductOrderORM.Models;

internal class Order
{

    [Key]
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime RequiredDate { get; set; }
    public int CustomerId { get; set; }

    public Customer Customer { get; set; }
}
