namespace FileClassExamples;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("File Class Introduction!");
        string path = @"C:\Dotnet-Jun-2025\InfowayLog.txt";
        if (!File.Exists(path))
        {
            var FS = File.Create(path);
            FS.Close();
        }
        else
        {
            
            File.WriteAllText(path, $"Infoway Log Date and Time - {DateTime.Now}");
            var logs = File.ReadAllText(path);
            foreach (var log in logs) {
                Console.Write(log);
            }
            //File.Delete(path);
        }
    }
}
