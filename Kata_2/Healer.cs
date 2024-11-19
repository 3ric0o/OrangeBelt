namespace Kata_2;

public class Healer : Character, IHeal
{
    public Healer(string name, int health) : base(name, health)
    {
    }
    
    public void Heal(Character target, int healAmount)
    {
        Console.WriteLine($"{Name} heals {target.Name} for {healAmount}!");
        target.Health += healAmount;
        
        EventSystem.NotifyHealthChanged(target.Name, target.Health);
    }
    public void PerformSpecialAction()
    {
        string action = "Healing Aura";
        Console.WriteLine($"{Name} performs {action}!");
        
        EventSystem.NotifySpecialActionPerformed(Name, action);
    }
}