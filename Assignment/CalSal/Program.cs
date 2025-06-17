namespace CalSal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Basic Salary of Employee");
            int sal = int.Parse(Console.ReadLine());

            int hra = sal * 20 / 100;
            int da = sal * 40 / 100;

            int gross= sal + da + hra;

            Console.WriteLine($"Gross salary of Employee is {gross}");

            int pf = gross * 10 / 100;

            Console.WriteLine($"Net Salary of Employee is {pf}");
        }
    }
}
