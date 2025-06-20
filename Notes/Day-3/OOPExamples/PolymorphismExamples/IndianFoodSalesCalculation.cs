namespace PolymorphismExamples;

internal class IndianFoodSalesCalculation:SalesCalculation
{
    public override int GetGstPercent()
    {
        return 5;
    }

    //Shadowing
    public new string GovtGstChangeNote()
    {
        return "There is 3% change in GST for the year 2026-27!";
    }
}
