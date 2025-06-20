namespace PolymorphismExamples;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Polymorphism Examples!");
        ForeignSalesCalculation salesCalculation = new ForeignSalesCalculation();
        Console.WriteLine($"Sales Net Profit without GST is INR {salesCalculation.SalesNetProfit(12000, 13000, 150000)}");
        Console.WriteLine($"Sales Net Profit with GST is INR {salesCalculation.SalesNetProfit(12000, 13000, 150000, 18)}");
        Console.WriteLine($"Foreign Sales Net Profit with GST is INR {salesCalculation.SalesNetProfit(12000, 13000, 150000, 18, 10000)}");

        //SalesCalculation indianFood=new IndianFoodSalesCalculation();
        IndianFoodSalesCalculation indianFood = new IndianFoodSalesCalculation();
        Console.WriteLine(indianFood.GetGstPercent());
        Console.WriteLine(indianFood.GovtGstChangeNote());
    }
}
