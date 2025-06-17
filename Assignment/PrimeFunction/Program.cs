namespace PrimeFunction
{
    internal class Program
    {

        static string CheckPN(int num)
        {
            if (num >= 0)
                return "Positive";
            else
                return "Negative";
        }


        static void Prime(int num)
        {
            if (num <= 1)
            {
                Console.WriteLine(num + " is not a prime number.");
                return;
            }

            bool isPrime = true;

            for (int i = 2; i*i <= num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.WriteLine(num + " is a prime number.");
            else
                Console.WriteLine(num + " is not a prime number.");
        }



        static void Main(string[] args)
        {
            int number;
            string status;

            do
            {
                Console.Write("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());

                status = CheckPN(number);

                if (status == "Negative")
                {
                    Console.WriteLine("Please enter a positive number.");
                }
            } while (status == "Negative");

            Console.WriteLine("You entered a positive number: " + number);
            Prime(number);
        }

        
       
    }
}
