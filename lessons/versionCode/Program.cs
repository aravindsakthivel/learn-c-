namespace lessons.versionCode;

public class Program
{
    public static void learn()
    {
        Console.WriteLine("C# Version Check");

#if NET7_0
        Console.WriteLine("C# 11 or later");
#elif NET6_0
        Console.WriteLine("C# 10");
#elif NET5_0
        Console.WriteLine("C# 9");
#elif NETCOREAPP3_1
        Console.WriteLine("C# 8");
#else
        Console.WriteLine("Older than C# 8");
#endif
    }
    
    public static void test()
    {
#if DEBUG
            
            Console.WriteLine("Debug mode");
#else
            Console.WriteLine("Not in debug mode");
#endif
            Console.WriteLine("Test not in debug mode");
    }
}