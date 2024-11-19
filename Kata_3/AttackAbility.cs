namespace Kata_3;

public class AttackAbility : IAbility
{
    public string AbilityName { get; set; } = "Slash Attack";
    public string AbilityDescription { get; set; } = "Effect: Deals 15 damage";

    public void AbilityAction()
    {
        Console.WriteLine($"Using {AbilityName} on Enemy. Enemy health is not 85");
    }
}