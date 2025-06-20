namespace ArrayExamples;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Array Examples!");
        string[] names = new string[] { "First", "Second", "Third" };
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
        Console.WriteLine("");
        int[,] numbers = new int[2, 2] { { 0, 1 }, { 1, 1 } };
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine($"{numbers[i, j]}");
            }
        }
        Console.WriteLine("");
        int[][] marks = new int[3][];
        marks[0] = new int[3] { 100, 200, 300 };
        marks[1] = new int[5] { 400, 500, 600, 700, 800 };
        marks[2] = new int[2] { 1001, 1002 };
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Row - {i} ");
            for (int j = 0; j < marks[i].Length; j++)
            {
                Console.Write($"\t{marks[i][j]}");
            }
            Console.WriteLine("");
        }
    }
}
