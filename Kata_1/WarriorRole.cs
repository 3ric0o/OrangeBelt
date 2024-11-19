namespace OrangeBelt;

public class WarriorRole : ICharacterRole
{
    public Action<string> PrimaryAction => Actions.Attack;

    public void PerformRoleSpecificAction(Character character)
    {
        Console.WriteLine($"{character.Name} charges with a fierce attack!");
        PrimaryAction.Invoke(character.Name);
    }
}