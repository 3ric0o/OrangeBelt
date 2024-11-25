namespace Kata_5;

public class Mage : Character, ICastSpell
{
    private readonly int _damage;
    public Mage(string name, int health, ILogger logger) : base(name, health, logger)
    {
        _damage = 25;
    }

    public void CastSpell(Character target)
    {
        Logger.Log($"{Name} casts a fireball on {target.Name} ,doing {_damage} damage!");
        target.Health -= _damage;
        
        EventSystem.NotifyHealthChanged(target.Name, target.Health);
    }
}