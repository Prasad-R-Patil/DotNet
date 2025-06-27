using FirstMvcApp.Models;

namespace FirstMvcApp.ViewModels;

public class CustomersOrdersVM
{
    public List<Customer> Customers { get; set; }
    public List<Order> Orders { get; set; }
}
