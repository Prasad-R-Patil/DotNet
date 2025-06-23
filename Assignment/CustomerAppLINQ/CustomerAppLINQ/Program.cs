using System.Runtime.CompilerServices;
using System.Xml.Linq;
using CustomerAppLINQ.Models;

namespace CustomerAppLINQ;

internal class Program
{
   

    static void Main(string[] args)
    {
        Console.WriteLine("===========================================================================================================================================================");
        Console.WriteLine("                                                                Shopping Application...!");
        Console.WriteLine("===========================================================================================================================================================");


        /*
                var CityWiseCustomersCount = from customer in GetAllXmlCustomers()
                                             group customer by customer.City into k
                                             select new { Count = k.Count(), City = k.Key };
                foreach (var item in CityWiseCustomersCount)
                {
                    Console.WriteLine($"In city {item.City}, there is/are {item.Count} number of customers!");
                }
                Console.WriteLine("-------------------------------------------------------------------------------" );
        */

        /*
            var Query1 = from Customer in GetAllXmlCustomers()
                         select Customer;

            foreach (var customer in Query1)
            {
                Console.WriteLine($"Customer {customer.CustomerName} lives in city {customer.City}!");
            }
        

        var Query2 = from Customer in GetAllXmlCustomers()
                     where Customer.City == "Pune"
                     select Customer;

        foreach (var customer in Query2)
        {
            Console.WriteLine($"Customer {customer.CustomerName} lives in city {customer.City}!");
        }
           

        var Query3 = from Customer in GetAllXmlCustomers()
                     orderby Customer.City descending, Customer.CustomerName ascending
                     select Customer;

        foreach (var customer in Query3)
        {
            Console.WriteLine($"Customer {customer.CustomerName} lives in city {customer.City}!");
        }
          */



        var details = from customer in GetAllXmlCustomers()
                      join order in GetAllXmlOrders()
                      on customer.CustomerId equals order.CustomerId
                      join product in GetAllXmlProduct()
                      on order.ProductId equals product.ProductId
                      join employee in GetAllXmlEmployee()
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
        Console.WriteLine("===========================================================================================================================================================");
        foreach (var item in details)
        {
            Console.WriteLine($"Customer {item.CustomerName} has ordered product {item.ProductName} from city {item.City} " +
                $"with total price of {item.Total} , order managed by employee {item.EmployeeName} \n");
        }
        Console.WriteLine("===========================================================================================================================================================");




    }





    private static List<Customer> GetAllXmlCustomers()
    {
        var Customers = from Customer in XElement.Load(@"C:\Users\group024\Desktop\SP\CustomerAppLINQ\CustomerAppLINQ\CustomerData.xml").Elements()

                        select new Customer()
                        {
                            CustomerId = int.Parse(Customer.Attribute("CustomerId").Value),
                            CustomerName = Customer.Attribute("CustomerName").Value,
                            City = Customer.Attribute("City").Value


                        };
        return Customers.ToList();

    }

    private static List<Employee> GetAllXmlEmployee()
    {
        var Employees = from Employee in XElement.Load(@"C:\Users\group024\Desktop\SP\CustomerAppLINQ\CustomerAppLINQ\EmployeeData.xml").Elements()

                        select new Employee()
                        {
                            EmployeeId = int.Parse(Employee.Attribute("EmployeeId").Value),
                            EmployeeName = Employee.Attribute("EmployeeName").Value,
                            Salary = float.Parse(Employee.Attribute("Salary").Value)

                        };

        return Employees.ToList();

    }


    private static List<Product> GetAllXmlProduct()
    {
        var Products = from Product in XElement.Load(@"C:\Users\group024\Desktop\SP\CustomerAppLINQ\CustomerAppLINQ\ProductData.xml").Elements()

                        select new Product()
                        {
                            ProductId = int.Parse(Product.Attribute("ProductId").Value),
                            ProductName = Product.Attribute("ProductName").Value,
                            Price = float.Parse(Product.Attribute("Price").Value)
                        };

        return Products.ToList();

    }

    private static List<Order> GetAllXmlOrders()
    {
        var orders = from order in XElement.Load(@"C:\Users\group024\Desktop\SP\CustomerAppLINQ\CustomerAppLINQ\OrderData.xml")
                                         .Elements("order")
                     select new Order
                     {
                         OrderId = int.Parse(order.Attribute("OrderId")?.Value ?? "0"),
                         OrderDate = DateTime.Parse(order.Attribute("OrderDate")?.Value ?? DateTime.MinValue.ToString()),
                         RequiredDate = DateTime.Parse(order.Attribute("RequiredDate")?.Value ?? DateTime.MinValue.ToString()),
                         Quantity = int.Parse(order.Attribute("Quantity")?.Value ?? "0"),
                         CustomerId = int.Parse(order.Attribute("CustomerId")?.Value ?? "0"),
                         EmployeeId = int.Parse(order.Attribute("EmployeeId")?.Value ?? "0"),
                         ProductId = int.Parse(order.Attribute("ProductId")?.Value ?? "0")
                     };

        return orders.ToList();
    }


}
