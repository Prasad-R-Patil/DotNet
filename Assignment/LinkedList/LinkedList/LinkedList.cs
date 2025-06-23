using System.ComponentModel.DataAnnotations;

namespace LinkedList;

internal class LinkedList
{
    public Node Head { get; set; }



    public LinkedList()
    {
        Head = null;
    }

    public void InsertFirst(int d)
    {
        Node newNode = new Node(d);

        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            newNode.next = Head;
            Head = newNode;
        }

    }

    public void InsertLast(int d)
    {
        Node newNode = new Node(d);

        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node iter = Head;

            while (iter.next != null)
            {
                iter = iter.next;
            }

            iter.next = newNode;
        }
    }

    public int DeleteFirst()
    {
        int res = 0;

        if(Head == null)
        {
            Console.WriteLine("Linked List Empty");
            return res;
        }

        res = Head.Data;

        Head = Head.next;
        return res;

    }

    public int DeleteLast()
    {
        int res = 0;

        if (Head == null)
        {
            Console.WriteLine("Linked List Empty");
            return res;
        }
        if (Head.next == null)
        {
            res = Head.Data;

            Head = null;

            return res;
        }

        Node iter = Head;

        while(iter.next.next != null)
        {
            iter = iter.next;
        }

        res = iter.next.Data;
        iter.next = null;
        return res;

    }




    public void Display()
    {
        Node iter = Head;

        while (iter != null)
        {
            Console.Write($"   {iter.Data} => ");

            iter = iter.next;
        }

        Console.WriteLine( );

    }
    
}
