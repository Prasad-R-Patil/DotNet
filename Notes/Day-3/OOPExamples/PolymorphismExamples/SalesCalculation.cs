using System.Transactions;

namespace PolymorphismExamples;

//Sales Net Profit = Incoming Money - Outgoing Money

//Incoming Money - actualSales
//Outgoing - expense, cogs [Cost of Godds and Services], Gst

internal class SalesCalculation
{
    public double SalesNetProfit(double cogs, double expense, double actualSales)
    {
        return actualSales - (cogs + expense);
    }
    public double SalesNetProfit(double cogs, double expense, double actualSales, int gstPercentage)
    {
        double gstAmount = actualSales * gstPercentage / 100;
        return actualSales - (cogs + expense + gstAmount);
    }
    public virtual int GetGstPercent()
    {
        return 18;
    }

    public string GovtGstChangeNote()
    {
        return "There are no changes in GST for the year 2025-26!";
    }

}
