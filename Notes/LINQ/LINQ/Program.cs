using LINQ.Models;

namespace LINQ;


internal class Program
{
    static void Main(string[] args)
    {
        /*foreach (var customer in GetAllCustomers())
        {
            Console.WriteLine($"Customer {customer.CustomerName} lives in City {customer.City}");
        }*/

        /*var CityWiseCount = from customer in GetAllCustomers()
                            group customer by customer.City into k
                            select new { Count  = k.Count(), City = k.Key };*/

        /*foreach (var item in CityWiseCount)
         {
            Console.WriteLine($"In city {item.City} there are/is {item.Count} number of customers");
         }*/


        var details = from customer in GetAllCustomers()
                      join order in GetAllOrders()
                      on customer.CustomerId equals order.CustomerId
                      join product in GetAllProducts()
                      on order.ProductId equals product.ProductId
                      join employee in GetAllEmployee()
                      on order.EmployeeId equals employee.EmployeeId
                      select new
                      {
                          CustomerName = customer.CustomerName,
                          City = customer.City,
                          DelieveryDate = order.RequiredDate,
                          Total = order.Quantity * product.Price,
                          ProductName = product.ProductName,
                          EmployeeName = employee.EmployeeName
                      };

        foreach (var item in details)
        {
            Console.WriteLine($"Customer {item.CustomerName} has ordered product {item.ProductName} from city {item.City} " +
                $"with total price of {item.Total} , order managed by employee {item.EmployeeName} \n");
        }





    }

    private static List<Customer> GetAllCustomers()
    {
        return new List<Customer>
                {
                    new Customer { CustomerId = 1, CustomerName = "Yash", City = "Pune" },
                    new Customer { CustomerId = 2, CustomerName = "Prasad", City = "Buldhana" },
                    new Customer { CustomerId = 3, CustomerName = "Yogesh", City = "Pune" },
                    new Customer { CustomerId = 4, CustomerName = "Sagar", City = "Sangli" },
                    new Customer { CustomerId = 5, CustomerName = "Harsh", City = "Mumbai" }
                };
    }

    private static List<Order> GetAllOrders()
    {
        return new List<Order>
        {
            new Order { OrderId = 1, CustomerId = 2, EmployeeId = 1, ProductId=1, Quantity=125, OrderDate = DateTime.Now, RequiredDate= DateTime.Now.AddDays(3) },
            new Order { OrderId = 2, CustomerId = 2, EmployeeId = 2, ProductId=2, Quantity=12, OrderDate = DateTime.Now, RequiredDate= DateTime.Now.AddDays(2) },
            new Order { OrderId = 3, CustomerId = 5, EmployeeId = 2, ProductId=1, Quantity=25, OrderDate = DateTime.Now, RequiredDate= DateTime.Now.AddDays(4) },
            new Order { OrderId = 4, CustomerId = 1, EmployeeId = 2, ProductId=3, Quantity=15, OrderDate = DateTime.Now, RequiredDate= DateTime.Now.AddDays(5) },
            new Order { OrderId = 5, CustomerId = 1, EmployeeId = 1, ProductId=2, Quantity=225, OrderDate = DateTime.Now, RequiredDate= DateTime.Now.AddDays(1) },

        };
    }

    private static List<Product> GetAllProducts()
    {
        return new List<Product>
        {
            new Product { ProductId = 1, ProductName = "Mobile", Price=27000.99 },
            new Product { ProductId = 2, ProductName = "Laptop", Price = 72000.99 },
            new Product { ProductId = 3, ProductName = "Keyboard", Price = 3000.50}
        };

    }

    private static List<Employee> GetAllEmployee()
    {
        return new List<Employee>
        {
            new Employee { EmployeeId = 1, EmployeeName = "Pawan", Salary = 120050 },
            new Employee { EmployeeId = 2, EmployeeName="Himanshu", Salary = 500041 }
        };
    }
}


     


