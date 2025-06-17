namespace Ascii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter character to know ASCII");
            char ch = char.Parse(Console.ReadLine());

            int ascii = (int)ch;

            Console.WriteLine($"Ascii avlue of given charater is {ascii}");
            




        }
    }
}
