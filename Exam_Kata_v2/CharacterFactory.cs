namespace Exam_Kata_v2;

public class CharacterFactory : ICharacterFactory
{
    private readonly IEventSystem _eventSystem;

    public CharacterFactory(IEventSystem eventSystem)
    {
        _eventSystem = eventSystem;
    }

    public ICharacter CreateWarrior(string name)
    {
        var warrior = new Character(name, 100, 50, 20, _eventSystem);
        warrior.Abilities.AddAbility(new AttackAbility());
        return warrior;
    }

    public ICharacter CreateMage(string name)
    {
        var mage = new Character(name, 75, 100, 25, _eventSystem);
        mage.Abilities.AddAbility(new FireballAbility());
        mage.Abilities.AddAbility(new PoisonAbility());
        return mage;
    }

    public ICharacter CreateHealer(string name)
    {
        var healer = new Character(name, 80, 100, 15, _eventSystem);
        healer.Abilities.AddAbility(new HealAbility());
        return healer;
    }
}