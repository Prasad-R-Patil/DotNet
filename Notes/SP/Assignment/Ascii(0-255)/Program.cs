namespace Ascii_0_255_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ASCII 0-255");
            int cnt = 1;
            for (int i = 0; i <=255; i++)
            { 
             
                if(i == 10*cnt)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Plese Enter to continue ");
                    Console.ReadLine();
                    cnt++;
                }
                char c = (char)i;
                Console.WriteLine(i+" <=> "+c);

            }
        }
    }
}
