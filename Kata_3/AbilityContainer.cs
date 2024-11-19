namespace Kata_3;


public class AbilityContainer<T> : IAbilityExecutor where T : IAbility
{
    private readonly List<T> _abilities = [];
    
    public void AddAbility(T ability)
    {
        _abilities.Add(ability);
    }

    public void RemoveAbility(T ability)
    {
        _abilities.Remove(ability);
    }

    public bool RetrieveAbility(T ability)
    {
        return _abilities.Contains(ability);
    }

    public void DisplayAbilities()
    {
        foreach (var abilities in _abilities)
        {
            Console.WriteLine($"{abilities.AbilityName} ({abilities.AbilityDescription})");
        }
    }

    public void Execute(IAbility ability)
    {
        if (_abilities.Contains((T)ability))
        {
            ability.AbilityAction();
        }
        else
        {
            Console.WriteLine($"Ability '{ability.AbilityName}' is not in the container.");
        }
    }
}