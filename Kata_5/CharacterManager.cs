namespace Kata_5;

public class CharacterManager
{
    private readonly ILogger _logger;
    private readonly List<Character> _characters = [];

    public CharacterManager(ILogger logger)
    {
        _logger = logger;
    }
    
    
    public Enemy CreateEnemy(string name, int health)
    {
        var enemy = new Enemy(name, health, _logger);
        _characters.Add(enemy);
        return enemy;
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
    
    public Mage CreateMage(string name, int health)
    {
        var mage = new Mage(name, health, _logger);
        _characters.Add(mage);
        return mage;
    }

    public void CharactersInfo()
    {
        _characters.ForEach(character => _logger.Log($"{character.Name}'s health: {character.Health}"));
        _logger.Log("");
    }
    public List<Character> GetAllCharacters()
    {
        return _characters;
    }
}