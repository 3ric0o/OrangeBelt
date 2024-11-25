namespace Exam_Kata_v2;

public interface IEventSystem
{
    void RaiseCharacterHealthChanged(ICharacter character, int oldHealth, int newHealth);
}