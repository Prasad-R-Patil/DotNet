namespace ConstructorExamples;

internal class Parent
{
    public Parent()
    {
        Console.WriteLine("Parent Class Default Constrcutor Executed!");
    }
    public Parent(int socialId):this()
    {
        Console.WriteLine("Parent Class Parameterised Constrcutor Executed!");
        ParentId = socialId;
    }
    public int ParentId{ get; set; }
}
