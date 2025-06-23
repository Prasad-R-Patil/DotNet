namespace LinkedList;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("LinkedList Operation!");

        LinkedList ll = new LinkedList();

        ll.InsertFirst(5);
        ll.InsertFirst(4);
        ll.InsertFirst(3);

       

        ll.InsertLast(6);
        ll.InsertLast(7);

        ll.Display();

        ll.DeleteFirst();

        ll.Display();

        ll.DeleteLast();

        ll.Display();


    }
}
