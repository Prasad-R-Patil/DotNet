namespace ThreadsExample;
using System.Threading;


internal class Program
{
    static int Counter = 1;
    static object o=new object();
    static void Main(string[] args)
    {
        Console.WriteLine($"Main Thread Started on - {Thread.CurrentThread.ManagedThreadId}!");
        
        Thread t1 = new Thread(new ThreadStart(Job1));
        Thread t2 = new Thread(new ThreadStart(Job2));
        //t2.Priority= ThreadPriority.Highest;
        //t1.Priority= ThreadPriority.Lowest;
        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();
        Console.WriteLine("Main Thread Ended!");
    }

    private static void Job1()
    {
        Monitor.Enter(o);
        //lock (o)
        {
            Console.WriteLine($"Job-1 Thread Started on - {Thread.CurrentThread.ManagedThreadId}!");
            for (int i = 0; i < 10; i++)
            {
                Counter++;
                Console.WriteLine($"Job - 1 - Counter Value is {Counter}!");
            } 
        }
        Monitor.Exit(o);
    }
    private static void Job2()
    {
        Monitor.Enter(o);
        //lock (o)
        {
            Console.WriteLine($"Job-2 Thread Started on - {Thread.CurrentThread.ManagedThreadId}!");
            for (int i = 0; i < 10; i++)
            {
                Counter++;
                Console.WriteLine($"Job - 2 - Counter Value is {Counter}!");
            } 
        }
        Monitor.Exit(o);
    }
}
