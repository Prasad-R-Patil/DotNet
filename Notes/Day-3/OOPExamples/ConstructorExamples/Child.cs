namespace ConstructorExamples;

internal class Child : Parent
{
    static Child()
    {
        Console.WriteLine("Child Class Static Constrcutor Executed!");
    }
    public Child(int socialId):base(socialId)
    {
        Console.WriteLine("Child Class Default Constrcutor Executed!");
    }
    public Child(Child child)
    {
        ParentId=child.ParentId;
        ChildId=child.ChildId;
    }
    public int ChildId { get; set; }
}
