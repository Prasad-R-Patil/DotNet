namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number To check Number Is Prime No or Not");
            int num = int.Parse(Console.ReadLine());

            if (num < 1)
            {
                Console.WriteLine("Number Is Not Prime");
            }

            Boolean flag = false;
            for(int i = 2; i < num/2;i++)
            {
                if (num % i == 0)
                {
                    flag = true;
                    break;
                }

                    

            }
            if (flag == false) {
                Console.WriteLine("It is prime number");
                    }
            else
            {
                Console.WriteLine("It is Not A Prime Number");
            }

            
        }
    }
}
