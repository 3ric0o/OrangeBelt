namespace Kata_5;

public class Character
{
    public string Name { get; }
    private int _health;
    private readonly int _maxHealth;
    protected readonly ILogger Logger;
        
    public int Health
    {
        get => _health;
        set => _health = value > _maxHealth ? _maxHealth : value;
    }
    protected Character(string name, int health, ILogger logger)
    {
        Name = name;
        _maxHealth = health;
        _health = health;
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