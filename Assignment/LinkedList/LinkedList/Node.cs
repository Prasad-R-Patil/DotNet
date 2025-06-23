namespace LinkedList;

internal class Node
{
    public int Data {  get; set; }
    public Node next { get; set; }

    public Node()
    {
        next = null;
    }

    public Node(int d)
    {
        Data = d;
        next = null;
    }


}
