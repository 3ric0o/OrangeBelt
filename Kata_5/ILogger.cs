namespace Kata_5;

public interface ILogger
{
    void Log(string message);
}

public class Logger : ILogger
{
    public void Log(string message) => Console.WriteLine(message);
}