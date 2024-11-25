namespace Kata_5;

class Program
{
    static void Main()
    {
        ILogger logger = new Logger();
        CharacterManager characterManager = new CharacterManager(logger);
        Game game = new Game(characterManager);

        game.StartGame();
    }
}