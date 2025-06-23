namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IO Operation!");


            String path = @"C:\Users\group024\Desktop\SP\io.txt";

            using (StreamWriter sw = new StreamWriter(path,true))
            {

                //sw.WriteLine("Welcome to IO Operation");

                sw.Close();
                
            }

            using (StreamReader sr = new StreamReader(path,true))
            {

                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
                
            }

            String path2 = @"C:\Users\group024\Desktop\SP\Assignment\io.txt";

            //File.Move(path ,path2 );

            String path3 = @"C:\Users\group024\Desktop\SP\Demo\io.txt";
           // File.Copy(path ,path3 );

            File.Delete(path2);
        }
    }
}
