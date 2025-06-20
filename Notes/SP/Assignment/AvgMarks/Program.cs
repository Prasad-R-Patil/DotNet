namespace AvgMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Marks in 5 subjects");
            Console.Write("sub1 :-> ");
            int sub1= int.Parse(Console.ReadLine());
            Console.Write("sub2 :-> ");
            int sub2 = int.Parse(Console.ReadLine());
            Console.Write("sub3 :-> ");
            int sub3 = int.Parse(Console.ReadLine());
            Console.Write("sub4 :-> ");
            int sub4 = int.Parse(Console.ReadLine());
            Console.Write("sub5 :-> ");
            int sub5 = int.Parse(Console.ReadLine());

            int avg= (sub1 + sub2 + sub3 + sub4 + sub5)/5;

            Console.WriteLine($"Average of 5 sub is {avg}");
        }
    }
}
