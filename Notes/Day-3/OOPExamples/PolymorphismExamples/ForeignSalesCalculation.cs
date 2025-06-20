namespace PolymorphismExamples;

internal class ForeignSalesCalculation : SalesCalculation
{
    public double SalesNetProfit(double cogs, double expense, double actualSales, int gstPercentage, double shippingCharges)
    {
        double gstAmount = actualSales * gstPercentage / 100;
        return actualSales - (cogs + expense + gstAmount + shippingCharges);
    }
}
