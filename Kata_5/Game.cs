using Microsoft.CSharp.RuntimeBinder;

namespace Kata_5;

public class Game
{
    private readonly CharacterManager _characterManager;

    public Game(CharacterManager characterManager)
    {
        _characterManager = characterManager;
    }

    public void StartGame()
    {
        var arin = _characterManager.CreateWarrior("Arin", 100);
        var bran = _characterManager.CreateHealer("Bran", 75);
        var cara = _characterManager.CreateMage("Cara", 50);
        var goblin = _characterManager.CreateEnemy("Goblin", 150);
        
        _characterManager.CharactersInfo();
        arin.Attack(goblin);
        goblin.Attack(arin);
        bran.Heal(arin);
        cara.CastSpell(goblin);
    }
}