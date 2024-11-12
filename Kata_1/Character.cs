namespace OrangeBelt;

public class Character
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public string Role { get; private set; }
    
    
    public Action<string> PrimaryAction { get; private set; }
    

    public Character(string name, int health, string role, Action<string> primaryAction)
    {
        Name = name;
        Health = health;
        Role = role;
        PrimaryAction = primaryAction;
    }
}