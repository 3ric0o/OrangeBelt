namespace Kata_2;

public class Warrior : Character, IAttack
{
    public Warrior(string name, int health) : base(name, health)
    {
    }

    
    public void Attack(Character target, int damage)
    {
        Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage!");
        target.Health -= damage;
        
        EventSystem.NotifyHealthChanged(target.Name, target.Health);
    }
    public void PerformSpecialAction()
    {
        string action = "Cleave!";
        Console.WriteLine($"{Name} performs {action}!");
        
        EventSystem.NotifySpecialActionPerformed(Name, action);
    }
}