namespace InterfaceExamples;

internal class ScienceDepartment : IScience
{
    string IBiology.BiologyCalci()
    {
        return "Biology Calculator!";
    }

    string IChemistry.ChemistryCalci()
    {
        return "Chemistry Calculator!";
    }

    string IPhysics.HodName()
    {
        return "John Mark";
    }

    string IChemistry.HodName()
    {
        return "Anjala Johns";
    }

    string IBiology.HodName()
    {
        return "Alicica Andrus";
    }

    string IPhysics.PhysicsCalci()
    {
        return "Physics Calculator!";
    }
}
