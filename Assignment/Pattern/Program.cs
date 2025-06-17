namespace Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Row Value :- ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("\n-------------------------------------------------------------------------------------");

            for (int i = 1; i <= rows; i++)
            {
                Console.Write(i + " ");

              
                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write(j + " ");
                }

                
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine(i); 
            }

            Console.WriteLine("-------------------------------------------------------------------------------------");
        }
    }
}
