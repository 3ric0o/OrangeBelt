namespace Exam_Kata_v2;

public class AbilityContainer<T> where T : IAbility
{
    private readonly List<T> _abilities = [];

    public void AddAbility(T ability)
    {
        _abilities.Add(ability);
    }

    public IEnumerable<T> GetAbilities()
    {
        return _abilities;
    }
}