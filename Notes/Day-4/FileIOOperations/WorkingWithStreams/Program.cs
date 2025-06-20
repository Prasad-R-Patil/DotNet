namespace WorkingWithStreams;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Working with Streams!");
        string path = @"C:\Dotnet-Jun-2025\InfowayStudentsLog.txt";
        //using (StreamWriter SW = new StreamWriter(path, true))
        //{
        //    SW.WriteLine("Welcome To Maharashtra!");
        //    SW.Close();
        //}
        using (StreamReader SR=new StreamReader(path))
        {
            //Console.WriteLine(SR.ReadToEnd()); 
            while (SR.Peek()!=-1)
            {
                //Console.WriteLine(SR.ReadLine());
                Console.WriteLine(Convert.ToChar(SR.Read()));
            }
        }
        //UnManagedClass managedClass = new UnManagedClass();
        //managedClass.Dispose();

        //using (UnManagedClass unManaged=new UnManagedClass())
        //{

        //}
    }
}
