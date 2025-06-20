namespace ClassesExamples;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Classes Examples!");
        PrimeCustomer customer = new PrimeCustomer();

        //customer.SocialId = 238492323;
        customer.CustomerId = 1001;
        customer.ContactName = "Alisha C.";
        customer.Address = "MoonCity";
        customer.City = "Mumbai";
        customer.Email = "alisha.c@infoway.com";
        customer.Phone = "(+91) 7737737737";
        Console.WriteLine(customer.ChangeAddress(customer.Address, "SunCity"));
        A a = new A();
        InfowayMath math = new InfowayMath();
        //Anonymous Class

        var CustomerOrderDetails = new { CustomerName = customer.ContactName, LivingCity = customer.City, OrderId = 2389, Qty = 10, UnitPrice = 170.90 };

        Console.WriteLine(Counter.IncrementCounter());
        Console.WriteLine(Counter.IncrementCounter());
        Console.WriteLine(Counter.IncrementCounter());
        Console.WriteLine(Counter.IncrementCounter());

    }
}
