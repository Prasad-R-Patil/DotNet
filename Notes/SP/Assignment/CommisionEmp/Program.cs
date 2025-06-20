namespace CommisionEmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Salary Of Employee");
            int sal = int.Parse(Console.ReadLine());    
            Console.WriteLine("enter Sales of Empoyee ");
            int sel = int.Parse(Console.ReadLine());

            if (sel < 5000)
            {
                Console.WriteLine($"Total Salary of employee is {sal}");
            }
            else if((sel>=5000) && (sel<=7500)){

                int comm = sel * 3 / 100;
                int total = sal + comm;

                Console.WriteLine($"Total Salary of employee is {total}");
            }
            else if ((sel >= 7501) && (sel <= 10500))
            {

                int comm = sel * 8 / 100;
                int total = sal + comm;

                Console.WriteLine($"Total Salary of employee is {total}");
            }
            else if ((sel >= 10501) && (sel <= 15000))
            {

                int comm = sel * 11 / 100;
                int total = sal + comm;

                Console.WriteLine($"Total Salary of employee is {total}");
            }
            else if ((sel > 15000))
            {

                int comm = sel * 15 / 100;
                int total = sal + comm;

                Console.WriteLine($"Total Salary of employee is {total}");
            }
        }
    }
}
