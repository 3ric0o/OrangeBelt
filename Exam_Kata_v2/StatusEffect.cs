namespace Exam_Kata_v2;

public class StatusEffect
{
    public string Name { get; }
    
    public int Duration { get; set; }
    
    public Action<ICharacter> Effect { get; }

    public StatusEffect(string name, int duration, Action<ICharacter> effect)
    {
        Name = name;
        Duration = duration;
        Effect = effect;
    }
}