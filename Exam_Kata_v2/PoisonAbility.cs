namespace Exam_Kata_v2;

public class PoisonAbility : IAbility
{
    public string Name => "Poison";

    public void Execute(ICharacter source, ICharacter target)
    {
        if (source.Mana >= 25)
        {
            var poisonEffect = new StatusEffect("Poison", 3, character => character.Health -= 10);
            target.ApplyStatusEffect(poisonEffect);
            source.Mana -= 25;
            LogExecution(source, target, 10);
        }
        else
        {
            Logger.Log($"{source.Name} doesn't have enough mana to cast Poison.");
        }
    }

    public void LogExecution(ICharacter source, ICharacter target, int damagePerTurn)
    {
        Logger.Log($"{source.Name} poisons {target.Name}, dealing {damagePerTurn} damage per turn for 3 turns!");
    }
}