namespace AsyncAwaitExample
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            var allCustomers = await GetAllCustomersAsyc();
            var filteredCustomers = await FilteredCustomersAsync(allCustomers, "London");
            var customers = await AlterCustomersAsync(filteredCustomers, "Bangalore");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer {customer.ContactName} has been moved to city {customer.City} !");
            }
        }

        private async static Task<List<Customer>> GetAllCustomersAsyc()
        {

            var customers = Task.Run<List<Customer>>(() =>
             {
                 return new List<Customer>() { new Customer(){CustomerId = 1,ContactName="John Mark", City="London"},
                new Customer(){CustomerId = 2,ContactName="Alicia Mark", City="London"},
                new Customer(){CustomerId = 3,ContactName="Maria Andrus", City="London"},
                new Customer(){CustomerId = 4,ContactName="Manish K.", City="Bangalore"},
                new Customer(){CustomerId = 5,ContactName="Danny Hingus", City="Berlin"},
                 };
             });
            return await customers;
        }
        private async static Task<List<Customer>> FilteredCustomersAsync(List<Customer> customers, string filterCity)
        {
            var filteredCustomer = Task<List<Customer>>.Run<List<Customer>>(() =>
            {
                return customers.Where(c => c.City==filterCity).ToList();
            });
            return await filteredCustomer;
        }
        private async static Task<List<Customer>> AlterCustomersAsync(List<Customer> customers, string changedCity)
        {
            foreach (var customer in customers)
            {
                customer.City = changedCity;
            }
            return await Task.Run(() =>
            {
                return customers;
            });
        }
    }
}
