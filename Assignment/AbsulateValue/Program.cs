namespace AbsulateValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number :- ");

            int iNo = int.Parse(Console.ReadLine());

            int iAbs = 0;

            if (iNo < 0)
            {
                iAbs = -iNo;
            }
            else
            {
                iAbs = iNo;
            }
            Console.WriteLine($"Absolute value of {iNo} is {iAbs}");
        }
    }
}
