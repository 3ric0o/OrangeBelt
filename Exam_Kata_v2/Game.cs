namespace Exam_Kata_v2;

public class Game
{
    private readonly List<Team> _teams;
    private readonly ICharacterFactory _characterFactory;
    private bool IsBattleOver() => _teams.Count(t => !t.IsDefeated) <= 1;
    
    public Game(ICharacterFactory characterFactory)
    {
        _characterFactory = characterFactory;
        _teams = [];
    }
    
    public void SetupGame()
    {
        var teamAlpha = new Team("Alpha");
        teamAlpha.AddCharacter(_characterFactory.CreateWarrior("Arin"));
        teamAlpha.AddCharacter(_characterFactory.CreateHealer("Dalia"));

        var teamBeta = new Team("Beta");
        teamBeta.AddCharacter(_characterFactory.CreateMage("Bran"));
        teamBeta.AddCharacter(_characterFactory.CreateWarrior("Cara"));

        _teams.Add(teamAlpha);
        _teams.Add(teamBeta);
    }
    public void StartBattle()
    {
        Logger.LogHeader("Welcome to the Battle Arena!");
        DisplayTeams();
        Logger.Pause();
        Logger.Clear();

        var round = 1;
        while (true)
        {
            Logger.LogHeader($"--- Round {round} ---");
            ExecuteRound();
            if (IsBattleOver())
            {
                break;
            }
            round++;
        }
        Logger.LogHeader("Battle Over!");
        DisplayWinner();
    }
    private void ExecuteRound()
    {
        var maxCharacters = _teams.Max(t => t.Characters.Count);
        for (var i = 0; i < maxCharacters; i++)
        {
            foreach (var team in _teams.Where(team => i < team.Characters.Count && team.Characters[i].Health > 0))
            {
                ExecuteTurn(team.Characters[i]);
                if (IsBattleOver())
                {
                    return;
                }
            }
        }
    }
    private void ExecuteTurn(ICharacter character)
    {
        Logger.LogHeader($"{character.Name}'s Turn");

        character.ApplyStatusEffects();

        var ability = Global.SelectAbility(character);

        if (ability.Name == "Pass")
        {
            ability.LogExecution(character, null!, 0);
            Logger.Pause();
            Logger.Clear();
            return;
        }

        var target = SelectTarget(character, ability);

        Logger.Clear();
        character.ExecuteAbility(ability, target);
        DisplayCharacterStatus();

        Logger.Pause();
        Logger.Clear();
    }
    private ICharacter SelectTarget(ICharacter source, IAbility ability)
    {
        var potentialTargets = GetPotentialTargets(source, ability);

        if (!potentialTargets.Any())
        {
            Logger.Log("No valid targets available.");
            return null!;
        }

        Logger.Log("Choose a target:");
    
        for (int i = 0; i < potentialTargets.Count; i++)
        {
            var target = potentialTargets[i];
            Logger.Log($"{i + 1}. {target.Name} (Health: {target.Health}/{target.MaxHealth}, Mana: {target.Mana}/{target.MaxMana})");
        }

        int choice = Global.GetValidInput(potentialTargets.Count);
    
        return potentialTargets[choice - 1];
    }
    private List<ICharacter> GetPotentialTargets(ICharacter source, IAbility ability)
    {
        var sourceTeam = _teams.First(t => t.Characters.Contains(source));
        var enemyTeam = _teams.First(t => t != sourceTeam);

        if (ability is HealAbility)
        {
            return sourceTeam.Characters.Where(c => c.Health > 0).ToList();
        }
        else if (ability is AttackAbility or FireballAbility or PoisonAbility)
        {
            return enemyTeam.Characters.Where(c => c.Health > 0).ToList();
        }
        return new List<ICharacter>();
    }
    private void DisplayTeams()
    {
        foreach (var team in _teams)
        {
            Logger.Log($"Team {team.Name}: {string.Join(", ", team.Characters.Select(c => $"{c.GetType().Name} {c.Name}"))}");
        }
    }
    private void DisplayCharacterStatus()
    {
        foreach (var team in _teams)
        {
            Logger.Log($"Team {team.Name}:");
            foreach (var character in team.Characters)
            {
                Logger.Log($"- {character.Name}: Health = {character.Health}/{character.MaxHealth}, Mana = {character.Mana}/{character.MaxMana}");
                if (character.StatusEffects.Any())
                {
                    Logger.Log($"  Status Effects: {string.Join(", ", character.StatusEffects.Select(se => $"{se.Name} ({se.Duration})"))}");
                }
            }
            Logger.Log("");  // Add an empty line between teams
        }
    }
    private void DisplayWinner()
    {
        var winner = _teams.FirstOrDefault(t => !t.IsDefeated);
        Logger.Log(winner != null ? $"Team {winner.Name} wins!" : "It's a draw!");
    }
}