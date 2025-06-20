namespace ClassesExamples;

abstract class Person
{
    protected Person()
    {
        Console.WriteLine("Person Class Constructor Executed!");
    }
    protected int SocialId { get; set; }
    public string ContactName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string City { get; set; }=string.Empty;
    public string State { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; }=string.Empty;
    public abstract string ChangeAddress(string oldAddress, string newAddress);

}
