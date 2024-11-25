namespace Exam_Kata_v2;

class Program
{
    private static void Main()
    {
        var eventSystem = new EventSystem();
        var characterFactory = new CharacterFactory(eventSystem);
        var game = new Game(characterFactory);
        
        game.SetupGame();
        game.StartBattle();
    }
}