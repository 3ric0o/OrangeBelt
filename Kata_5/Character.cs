namespace Kata_5;

public class Character
{
    public string Name { get; private set; }
    public int Health;
    protected readonly ILogger Logger;
        
    protected Character(string name, int health, ILogger logger)
    {
        Name = name;
        Health = health;
        Logger = logger;
            
         EventSystem.SubscribeToHealthChanged(OnHealthChanged);
         EventSystem.SubscribeToSpecialAction(OnSpecialActionPerformed);
    }

    private void OnHealthChanged(string characterName, int newHealth)
    {
        if (characterName == Name)
        {
            Logger.Log($"[Event] {Name}'s health changed to {newHealth}.\n");
        }
    }
    private void OnSpecialActionPerformed(string characterName, string action)
    {
        if (characterName == Name)
        {
            Logger.Log($"[Event] {Name} performed special action: {action}.\n");
        }
    }
}