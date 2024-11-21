namespace Kata_5;

public class Game
{
    private readonly ILogger _logger;
    private readonly CharacterManager _characterManager;

    public Game(ILogger logger, CharacterManager characterManager)
    {
        _logger = logger;
        _characterManager = characterManager;
    }

    public void StartGame()
    {
        var arin = _characterManager.CreateWarrior("Arin", 100);
        var cara = _characterManager.CreateWarrior("Cara", 100);
        var bran = _characterManager.CreateHealer("Bran", 100);

        
    }
}