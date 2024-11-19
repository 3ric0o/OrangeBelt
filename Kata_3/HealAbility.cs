namespace Kata_3;

public class HealAbility : IAbility
{
    public string AbilityName { get; set; } = "Healing Light";
    public string AbilityDescription { get; set; } = "Effect: Restores 20 health";
    public void AbilityAction()
    {
        Console.WriteLine($"Using {AbilityName} on Ally. Healed Ally for 20");
    }
}