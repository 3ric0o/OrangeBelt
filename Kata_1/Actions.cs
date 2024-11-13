namespace OrangeBelt;

public static class Actions
{
    
    public static readonly Action<string>? Attack = name =>
    {
        Console.WriteLine($"{name} performs a powerful attack!");
    };
    
    
    public static readonly Action<string>? Heal = name =>
    {
        Console.WriteLine($"{name} performs a powerful healing spell!");
    };
    
}