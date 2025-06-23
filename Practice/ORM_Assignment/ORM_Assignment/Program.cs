using ORM_Assignment.Models;
using ORM_Assignment.Models.Models;
using ProductOrderORM.DAL;

namespace ORM_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Spare Part Insert Example");

            using (var context = new PurchaseOrderDbContext())
            {
                
                if (!context.Categories.Any())
                {
                    var category = new Category
                    {
                        CategoryId = 1,
                        CategoryName = "Engine Parts",
                        Description = "Spare parts for car engines"
                    };

                    var supplier = new Supplier
                    {
                        SupplierId = 1,
                        ContactName = "AutoSupplies Pvt Ltd",
                        City = "Pune",
                        Email = "contact@autosupplies.com"
                    };

                    var shipper = new Shipper
                    {
                        ShipperId = 1,
                        CompanyName = "QuickShip Logistics",
                        Phone = "9876543210"
                    };

                    var product = new Product
                    {
                        ProductId = 1,
                        ProductName = "Oil Filter",
                        CategoryId = 1,
                        SupplierId = 1,
                        ShipperId = 1
                    };

                    context.Categories.Add(category);
                    context.Suppliers.Add(supplier);
                    context.Shippers.Add(shipper);
                    context.Products.Add(product);

                    context.SaveChanges();

                    Console.WriteLine("Sample spare part data inserted successfully.");
                }
                else
                {
                    Console.WriteLine("Sample data already exists. Skipping insertion.");
                }
            }
        }
    }
}
