using System.ComponentModel;

namespace ASCII_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Display Ascii Value in Range (0-255)");
            int cnt = 1;
            for (int i = 0; i <= 255; i++)
            {
                Console.Write($"{i,3} = {(char)i}   ");

                if (i==(9*cnt))
                {
                    Console.WriteLine(); 
                    Console.Write("Press Enter to continue...");
                    Console.ReadLine();
                    cnt++;
                }
            }

        }
    }
}
