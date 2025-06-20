namespace ClassesExamples;

internal sealed class PrimeCustomer : Customer
{
    public PrimeCustomer()
    {
        Console.WriteLine("Prime Customer Class Constructor Executed!");
    }
    public double PrimeFees { get; set; } = 1499;
}
