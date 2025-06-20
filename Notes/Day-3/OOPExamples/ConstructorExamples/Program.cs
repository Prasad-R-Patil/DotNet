namespace ConstructorExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Child child = new Child(238923892);
            child.ChildId = 9090909;
            Child anotherChild=new Child(child);
            Console.WriteLine($"{anotherChild.ParentId}   {anotherChild.ChildId}");
            Child oneMoreChild = new Child(2372992);
        }
    }
}
