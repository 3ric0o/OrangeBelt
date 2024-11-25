namespace Kata_5;

public class Warrior : Character, IAttack
{
    private readonly int _damage;
    public Warrior(string name, int health, ILogger logger) : base(name, health, logger)
    {
        _damage = 20;
    }

    
    public void Attack(Character target)
    {
        Logger.Log($"{Name} attacks {target.Name} with his mighty sword, doing {_damage} damage!");
        target.Health -= _damage;
        
        EventSystem.NotifyHealthChanged(target.Name, target.Health);
    }
    public void PerformSpecialAction()
    {
        string action = "Cleave!";
        Logger.Log($"{Name} performs {action}!");
        
        EventSystem.NotifySpecialActionPerformed(Name, action);
    }
}