namespace Exam_Kata_v2;

public interface ILogger
{
    static abstract void Log(string message);
    static abstract string? Output();
}

public abstract class Logger : ILogger
{
    public static void Log(string message) => Console.WriteLine(message);
    
    private static void LogSeparator() => Console.WriteLine("===============================");
    
    public static void LogHeader(string header)
    {
        LogSeparator();
        Console.WriteLine($"         {header}");
        LogSeparator();
        Console.WriteLine();
    }

    public static string? Output()
    {
        Console.Write("> ");
        string? input = Console.ReadLine();
        Console.WriteLine();
        return input;
    }
    
    public static void Pause()
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(true);
    }

    public static void Clear()
    {
        Console.Clear();
    }
}