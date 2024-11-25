namespace Exam_Kata_v2;

public class Character : ICharacter
{
    private readonly IEventSystem _eventSystem;
    
    private int _health;
    private int _mana;
    
    public string Name { get; }
    public int MaxHealth { get; }
    public int MaxMana { get; }
    public int Damage { get; }
    
    public int Mana
    {
        get => _mana;
        set => _mana = Math.Max(0, Math.Min(value, MaxMana));
    }
    public int Health
    {
        get => _health;
        set
        {
            int oldHealth = _health;
            _health = Math.Max(0, Math.Min(value, MaxHealth));
            if (oldHealth != _health)
            {
                _eventSystem.RaiseCharacterHealthChanged(this, oldHealth, _health);
            }
        }
    }
    
    public AbilityContainer<IAbility> Abilities { get; } = new();
    public List<StatusEffect> StatusEffects { get; } = [];

    public Character(string name, int maxHealth, int maxMana, int damage, IEventSystem eventSystem)
    {
        Name = name;
        MaxHealth = maxHealth;
        _health = maxHealth;
        MaxMana = maxMana;
        _mana = maxMana;
        Damage = damage;
        _eventSystem = eventSystem;
    }

    public void ExecuteAbility(IAbility ability, ICharacter target)
    {
        ability.Execute(this, target);
    }
    public void ApplyStatusEffect(StatusEffect effect)
    {
        StatusEffects.Add(effect);
    }
    public void ApplyStatusEffects()
    {
        foreach (var effect in StatusEffects.ToList())
        {
            effect.Effect(this);
            effect.Duration--;
            if (effect.Duration <= 0)
            {
                StatusEffects.Remove(effect);
            }
        }
    }
}