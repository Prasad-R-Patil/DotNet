namespace ClassesExamples;

internal static class Counter
{
    public static int Count { get; set; } = 0;
    public static int IncrementCounter()
    {
        return Count++;
    }
}
