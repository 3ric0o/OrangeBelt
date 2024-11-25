namespace Exam_Kata_v2;

public class CharacterHealthChangedEvent : EventArgs
{
    public ICharacter Character;
    public int OldHealth;
    public int NewHealth;

    public CharacterHealthChangedEvent(ICharacter character, int oldHealth, int newHealth)
    {
        Character = character;
        OldHealth = oldHealth;
        NewHealth = newHealth;
    }
}