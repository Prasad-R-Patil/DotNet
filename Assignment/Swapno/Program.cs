namespace Swapno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers");
            Console.Write("Num1 :-> ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Num2 :-> ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Num1 = {num1} Num2 = {num2}");
            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"after swapping Num1 = {num1} Num2 = {num2}");

        }
    }
}
