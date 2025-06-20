namespace DDMMYY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Date In DD/MM/YY");
            String datestr= Console.ReadLine();
            int month = int.Parse(datestr.Split('/')[1]);

            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            Console.WriteLine($"month name is {months[month - 1]}");


            if (month % 2 != 0)
            {
                Console.WriteLine("Total no. of days in months is 31");
            }
            else if (month == 2)
            {
                Console.WriteLine("Total no. of days in months is 28 or 29");
            }
            else
            {
                Console.WriteLine("Total no. of days in months is 30");
            }
        }
    }
}
