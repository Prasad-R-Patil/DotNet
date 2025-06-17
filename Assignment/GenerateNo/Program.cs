namespace GenerateNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            Console.WriteLine("--------------------------------------");

            for (int i = 0; i < 3; i++)  // 1
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("--------------------------------------");

            for (int i = 0; i < 3; i++)      // 2
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i != j)
                        Console.WriteLine($"{arr[i]} - {arr[j]}");
                }
            }

            Console.WriteLine("--------------------------------------");

            for (int i = 0; i < 3; i++)      // 3
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (i != j && j != k && i != k)
                            Console.WriteLine($"{arr[i]} - { arr[j]} - { arr[k]}");
                    }
                }
            }

            Console.WriteLine("--------------------------------------");
        }
    }
}
