namespace Patter1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 10;

            for (int i = 1; i <= rows; i++)
            {
                Console.Write(i + " ");

                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write(j + " ");
                }

                Console.Write(1+" ");

                if (i > 1)
                {
                    Console.Write(i+" ");
                }

                Console.WriteLine();
            }
        }
    }
}
