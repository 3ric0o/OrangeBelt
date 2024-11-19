namespace OrangeBelt;

public class Character
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public readonly ICharacterRole Role;

    public Character(string name, int health, ICharacterRole role)
    {
        Name = name;
        Health = health;
        Role = role;
    }

    public void PerformAction()
    {
        Role.PerformRoleSpecificAction(this);
    }
}