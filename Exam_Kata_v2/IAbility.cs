namespace Exam_Kata_v2;

public interface IAbility
{
    string Name { get; }
    void Execute(ICharacter source, ICharacter target);
    void LogExecution(ICharacter source, ICharacter target, int effect);
}