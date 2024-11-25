namespace Exam_Kata_v2;

public class FireballAbility : IAbility
{
    public string Name => "Fireball";

    public void Execute(ICharacter source, ICharacter target)
    {
        if (source.Mana >= 30)
        {
            int damage = source.Damage * 2;
            target.Health -= damage;
            source.Mana -= 30;
            LogExecution(source, target, damage);
        }
        else
        {
            Logger.Log($"{source.Name} doesn't have enough mana to cast Fireball.");
        }
    }

    public void LogExecution(ICharacter source, ICharacter target, int damage)
    {
        Logger.Log($"{source.Name} casts Fireball on {target.Name} for {damage} damage!");
    }
}