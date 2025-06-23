namespace TaskProgrammingExamples;

internal class Program
{
    static void Main(string[] args)
    {
        List<Customer> customers = new List<Customer>()
        {
            new Customer(){CustomerId = 1,ContactName="John Mark", City="London"},
            new Customer(){CustomerId = 2,ContactName="Alicia Mark", City="London"},
            new Customer(){CustomerId = 3,ContactName="Maria Andrus", City="London"},
            new Customer(){CustomerId = 4,ContactName="Manish K.", City="Bangalore"},
            new Customer(){CustomerId = 5,ContactName="Danny Hingus", City="Berlin"},
        };
        Console.WriteLine($"Training Arrangement - Main Thread Id is - {Thread.CurrentThread.ManagedThreadId} !");
        Task<List<Customer>> customersTask = Task<List<Customer>>.Run(() =>
        {
            return customers;
        }).ContinueWith<List<Customer>>(allCityCustomer =>
        {
            var LondonCustomersOnly = allCityCustomer.Result.Where(customer => customer.City == "London");
            foreach (var customer in LondonCustomersOnly)
            {
                Console.WriteLine($"Customer {customer.ContactName} is from city {customer.City}!");
            }
            Console.WriteLine("");
            return LondonCustomersOnly.ToList();
        }).ContinueWith(allLondonCustomers =>
        {
            foreach (var customer in allLondonCustomers.Result)
            {
                customer.City = "New York";
            }
            return allLondonCustomers.Result;
        });
        foreach(var customer in customersTask.Result)
        {
            Console.WriteLine($"Customer {customer.ContactName} is from city {customer.City}!");
        }
        Console.WriteLine("Main Thread Ended!");
    }
    //static void Main(string[] args)
    //{
    //    Console.WriteLine($"Training Arrangement - Main Thread Id is - {Thread.CurrentThread.ManagedThreadId} !");
    //    string trainerName = "Alisha C.";
    //    string city = "Mumbai";
    //    string travellingCity = "Delhi";

    //    Task<bool> trainerArrangement = Task<bool>.Run(() =>
    //    {
    //        if (travellingCity == "Bangalore")
    //        {
    //            Console.WriteLine($"Trainer {trainerName} from {city} is travelling to {travellingCity}!");
    //            return true;
    //        }
    //        else
    //        {
    //            Console.WriteLine("Task Aborted!");
    //            return false;
    //        }
    //    }).ContinueWith<bool>(task1 =>
    //    {
    //        if (task1.Result == true)
    //        {
    //            Console.WriteLine($"Flight Tickets are booked for {travellingCity} for {trainerName}!");
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }).ContinueWith<bool>(task2 =>
    //    {
    //        if (task2.Result == true)
    //        {
    //            Console.WriteLine($"Hotels are booked in {travellingCity} for {trainerName}!");
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    });

    //    Console.WriteLine($"Task Value is {trainerArrangement.Result}");
    //    Console.WriteLine("Main Thread Ended!");
    //}
    //static void Main(string[] args)
    //{
    //    Console.WriteLine($"Task Programming Examples - Main Thread Id is - {Thread.CurrentThread.ManagedThreadId} !");
    //    Task t1 = new Task(() =>
    //    {
    //        Console.WriteLine($"Task - 1 Thread Id is - {Thread.CurrentThread.ManagedThreadId} !");
    //        for (int i = 0; i < 10; i++)
    //        {
    //            Console.WriteLine($"Task - 1 - Counter - {i}");
    //        }
    //    });

    //    Task t2 = new Task(() =>
    //    {
    //        Console.WriteLine($"Task - 2 Thread Id is - {Thread.CurrentThread.ManagedThreadId} !");
    //        for (int i = 0; i < 10; i++)
    //        {
    //            Console.WriteLine($"Task - 2 - Counter - {i}");
    //        }
    //    });
    //    t1.Start();
    //    t2.Start();
    //    t1.Wait();
    //    t2.Wait();
    //    Console.WriteLine("Main Thread Ended!");
    //}
}
