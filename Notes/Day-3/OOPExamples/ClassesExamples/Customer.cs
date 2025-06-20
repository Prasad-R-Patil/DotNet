namespace ClassesExamples;

internal class Customer : Person
{
    public Customer()
    {
        Console.WriteLine("Customer Class Constructor Executed!");
    }
    public int CustomerId { get; set; }
    public override string ChangeAddress(string oldAddress, string newAddress)
    {
        return $"Customer {ContactName} has changed his/her address from {oldAddress} to {newAddress}!";
    }
}
class A
{
    public int No1 { get; set; }
    protected int No2 { get; set; }
    private int No3 { get; set; }
}
class B:A
{
    public B()
    {
        
    }
}
class C:B
{

}