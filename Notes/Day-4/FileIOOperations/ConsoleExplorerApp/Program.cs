namespace ConsoleExplorerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Explorer!");
            Console.WriteLine("Available Drives are - ");
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType!=DriveType.Network)
                {
                    Console.WriteLine($"{drive.Name}"); DirectoryInfo directoryInfo = new DirectoryInfo(drive.Name);
                    foreach (var directory in directoryInfo.GetDirectories())
                    {
                        Console.WriteLine($"\t {directory.Name}");
                        try
                        {
                            foreach (var fileInfo in directory.GetFiles())
                            {
                                Console.WriteLine($"\t\t {fileInfo.Name}");


                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                
            }
        }
    }
}
