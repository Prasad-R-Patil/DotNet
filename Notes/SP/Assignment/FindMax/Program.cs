namespace FindMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Three Numbers");
            Console.Write("Num1 => ");
            int num1= int.Parse(Console.ReadLine());
            Console.Write("Num2 => ");
            int num2= int.Parse(Console.ReadLine());
            Console.Write("Num3 => ");
            int num3 = int.Parse(Console.ReadLine());

            //if (num1 > num2 && num1 > num3)
            //{
            //    Console.WriteLine($"Maximum value is {num1}");
            //}
            //else if (num2 > num1 && num2 > num3)
            //{
            //    Console.WriteLine($"Maximum value is {num2}");
            //}
            //else
            //{
            //    Console.WriteLine($"Maximum value is {num3}");
            //}
            int temp;
            temp = (num1 > num2) ? num1 :  num2;
            temp = (temp > num3) ? temp :  num3;

            Console.WriteLine($"Maximum value is {temp}");

        }
    }
}

