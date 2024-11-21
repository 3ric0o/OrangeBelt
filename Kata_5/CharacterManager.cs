namespace Kata_5;

public class CharacterManager
{
    private readonly ILogger _logger;
    private readonly List<Character> _characters = [];

    public CharacterManager(ILogger logger)
    {
        _logger = logger;
    }

    public Warrior CreateWarrior(string name, int health)
    {
        var warrior = new Warrior(name, health, _logger);
        _characters.Add(warrior);
        return warrior;
    }
    
    public Healer CreateHealer(string name, int health)
    {
        var healer = new Healer(name, health, _logger);
        _characters.Add(healer);
        return healer;
    }
    
    public List<Character> GetAllCharacters()
    {
        return _characters;
    }
}