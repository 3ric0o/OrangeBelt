namespace Exam_Kata_v2;

public interface ICharacter
{
    string Name { get; }
    int Health { get; set; }
    int MaxHealth { get; }
    int Mana { get; set; }
    int MaxMana { get; }
    int Damage { get; }
    AbilityContainer<IAbility> Abilities { get; }
    List<StatusEffect> StatusEffects { get; }
    
    void ExecuteAbility(IAbility ability, ICharacter target);
    void ApplyStatusEffect(StatusEffect effect);
    void ApplyStatusEffects();
}