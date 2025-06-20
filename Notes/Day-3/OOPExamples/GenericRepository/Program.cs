namespace GenericRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics Example!");
            //Object Initializer
            Customer customer1 = new Customer() { CustomerId = 1, ContactName = "Alisha C.", City = "Mumbai" };
            Customer customer2 = new Customer() { CustomerId = 2, ContactName = "Yash P. D.", City = "Pune" };
            ICommonRespository<Customer> customerCrud = new CommonRespository<Customer>();
            customerCrud.Insert(customer1);
            customerCrud.Insert(customer2);

            foreach (var customer in customerCrud.GetAll())
            {
                Console.WriteLine($"Customer Name {customer.ContactName} lives in city {customer.City}!");
            }
            Console.WriteLine("");
            Product product1 = new Product() { ProductId = 1, ProductName = "Mobile1", UnitPrie = 19000 };
            Product product2 = new Product()
            {
                ProductId = 2,
                ProductName = "Mobile2",
                UnitPrie = 56000
            };
            ICommonRespository<Product> productCrud=new CommonRespository<Product>();
            productCrud.Insert(product1);
            productCrud.Insert(product2);
            foreach (var product in productCrud.GetAll())
            {
                Console.WriteLine($"Product Name {product.ProductName} and unit price {product.UnitPrie}!");
            }
        }

    }
}