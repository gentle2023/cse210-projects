public static class ActivityLog
{
    public static int BreathingCount { get; private set; }
    public static int ReflectionCount { get; private set; }
    public static int ListingCount { get; private set; }

    public static void LogBreathing()
    {
        BreathingCount++;
    }

    public static void LogReflection()
    {
        ReflectionCount++;
    }

    public static void LogListing()
    {
        ListingCount++;
    }

    public static void DisplayLog()
    {
        Console.WriteLine();
        Console.WriteLine("Activity Log:");
        Console.WriteLine($"Breathing Activity: {BreathingCount} times");
        Console.WriteLine($"Reflection Activity: {ReflectionCount} times");
        Console.WriteLine($"Listing Activity: {ListingCount} times");
    }
}
