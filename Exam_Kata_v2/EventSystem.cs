namespace Exam_Kata_v2;

public class EventSystem : IEventSystem
{
    public event EventHandler<CharacterHealthChangedEvent>? CharacterHealthChanged;

    public void RaiseCharacterHealthChanged(ICharacter character, int oldHealth, int newHealth)
    {
        CharacterHealthChanged?.Invoke(this, new CharacterHealthChangedEvent(character, oldHealth, newHealth));
    }
}