namespace Absulate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Number");
            int num = int.Parse(Console.ReadLine());

            //int abs= -num;
            int absnum = Math.Abs(num);

            //if (num < 0)
            //{
            //    num = num * -1;
            //}

            Console.WriteLine($"The Absulate Number is {abs}");
        }
    }
}
