namespace Exam_Kata_v2;

public class HealAbility : IAbility
{
    public string Name => "Heal";

    public void Execute(ICharacter source, ICharacter target)
    {
        int healAmount = source.Damage * 2;
        target.Health = Math.Min(target.Health + healAmount, target.MaxHealth);
        LogExecution(source, target, healAmount);
    }

    public void LogExecution(ICharacter source, ICharacter target, int healAmount)
    {
        Logger.Log($"{source.Name} heals {target.Name} for {healAmount} health!");
    }
}