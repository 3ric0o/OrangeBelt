namespace Exam_Kata_v2;

public class AttackAbility : IAbility
{
    public string Name => "Attack";

    public void Execute(ICharacter source, ICharacter target)
    {
        var damage = source.Damage;
        target.Health -= damage;
        LogExecution(source, target, damage);
    }

    public void LogExecution(ICharacter source, ICharacter target, int damage)
    {
        Logger.Log($"{source.Name} attacks {target.Name} for {damage} damage!");
    }
}