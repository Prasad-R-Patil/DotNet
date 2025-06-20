namespace WorkingWithStreams;

internal class UnManagedClass : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("Disposing the UnManaged Memory!");
    }
}
