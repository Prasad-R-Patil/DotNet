namespace PrimeNo
{
    internal class Program
    {
        static void Main(string[] args)
        {



           /* Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            bool isPrime = true;

            if (num <= 1)
                isPrime = false;
            else
            {
                for (int i = 2; i*i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isPrime ? "It is a Prime Number" : "Not a Prime Number");*/








            int count = 0;
            int number = 2;

            Console.WriteLine("First 25 prime numbers:");

            while (count < 25)
            {
                bool isPrime = true;

                for (int i = 2; i * i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(number + " ");
                    count++;
                }

                number++;
            }
        }
    }
}
