namespace Kata_3;

public interface IAbility
{
    public string AbilityName { get; set; }
    public string AbilityDescription { get; set; }
    public void AbilityAction();

}