namespace InterfaceExamples;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Interface Examples!");
        IPhysics science1=new ScienceDepartment();
        Console.WriteLine(science1.PhysicsCalci());
        Console.WriteLine(science1.HodName());
        IChemistry science2 = new ScienceDepartment();
        Console.WriteLine(science2.ChemistryCalci());
        Console.WriteLine(science2.HodName());
        IBiology science3 = new ScienceDepartment();
        Console.WriteLine(science3.BiologyCalci());
        Console.WriteLine(science3.HodName());
        IScience scienceHod = new ScienceDepartment();
        
    }
}
