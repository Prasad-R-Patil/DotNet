namespace Leapyear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year To Check year is leap year or not");
            int year= int.Parse(Console.ReadLine());

            if ((year % 4) == 0 && ((year % 400) == 0 || (year % 100) != 0))
            {
                Console.WriteLine("Year is Leap year");
            }
            else
            {
                Console.WriteLine("Year is not leap Year");
            }
        }
    }
}
