namespace OrangeBelt;

public interface ICharacterRole
{
    public Action<string> PrimaryAction { get; }
    public void PerformRoleSpecificAction(Character character);
}