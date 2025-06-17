namespace DateAccept
{
    internal class Program
    {
        static void getDate(out int day, out int month, out int year)
        {
            Console.Write("Enter day: ");
            day = int.Parse(Console.ReadLine());

            Console.Write("Enter month: ");
            month = int.Parse(Console.ReadLine());

            Console.Write("Enter year: ");
            year = int.Parse(Console.ReadLine());
        }

        static void Main(String[] args)
        {
            int day, month, year;
            getDate(out day, out month, out year);

            Console.WriteLine($"\nDate Entered: {day:D2}/{month:D2}/{year}");
        }
    }
}
