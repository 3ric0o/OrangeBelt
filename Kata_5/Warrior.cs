namespace Kata_5;

public class Warrior : Character, IAttack
{
    public Warrior(string name, int health, ILogger logger) : base(name, health, logger)
    {
    }

    
    public void Attack(Character target, int damage)
    {
        Logger.Log($"{Name} attacks {target.Name} for {damage} damage!");
        target.Health -= damage;
        
        EventSystem.NotifyHealthChanged(target.Name, target.Health);
    }
    public void PerformSpecialAction()
    {
        string action = "Cleave!";
        Logger.Log($"{Name} performs {action}!");
        
        EventSystem.NotifySpecialActionPerformed(Name, action);
    }
}