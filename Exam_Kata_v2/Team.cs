namespace Exam_Kata_v2;

public class Team
{
    public string Name { get; }
    public List<ICharacter> Characters { get; } = [];

    public Team(string name)
    {
        Name = name;
    }

    public void AddCharacter(ICharacter character)
    {
        Characters.Add(character);
    }

    public bool IsDefeated => Characters.All(c => c.Health <= 0);
}