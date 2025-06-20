using System.Collections;

namespace StronglyTypedCollectionExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Why should you not use weakly typed collections! Because of Boxing and Unboxing Problem!");
            //ArrayList items=new ArrayList();
            //items.Add(100);
            //int firstItem = items[0];
            List<string> items= new List<string>();
            items.Add("First");
            items.Add("Second");
            items.Add("Third");
            //string firstItem = items[0];
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            Stack<string> books=new Stack<string>();
            books.Push("Book-1");
            books.Push("Book-2");
            books.Push("Book-3");

            Console.WriteLine(books.Peek());

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
