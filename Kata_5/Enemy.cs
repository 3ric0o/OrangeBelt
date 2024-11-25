namespace Kata_5;

public class Enemy : Character, IAttack
{
    private readonly int _damage;
    public Enemy(string name, int health, ILogger logger) : base(name, health, logger)
    {
        _damage = 25;
    }

    public void Attack(Character target)
    {
        Logger.Log($"{Name} swings his mace over {target.Name} ,doing {_damage} damage!");
        target.Health -= _damage;
        
        EventSystem.NotifyHealthChanged(target.Name, target.Health);
    }
}