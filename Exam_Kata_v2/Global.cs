namespace Exam_Kata_v2;

public static class Global
{
    public static IAbility SelectAbility(ICharacter character)
    {
        Logger.Log("Available abilities:");
    
        var abilities = new List<IAbility>(character.Abilities.GetAbilities()) { new PassAbility() };

        for (int i = 0; i < abilities.Count; i++)
        {
            Logger.Log($"{i + 1}. {abilities[i].Name}");
        }
        var choice = GetValidInput(abilities.Count);
        return abilities[choice - 1];
    }

    public static int GetValidInput(int maxOption)
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out var choice) && choice >= 1 && choice <= maxOption)
            {
                return choice;
            }
            else
            {
                Logger.Log($"Invalid input. Please enter a number between 1 and {maxOption}.");
            }
        }
    }
}