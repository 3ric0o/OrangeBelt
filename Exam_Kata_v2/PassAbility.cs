namespace Exam_Kata_v2;

public class PassAbility : IAbility
{
    public string Name => "Pass";

    public void Execute(ICharacter source, ICharacter target)
    {
        // Do nothing
    }

    public void LogExecution(ICharacter source, ICharacter target, int effect)
    {
        Logger.Log($"{source.Name} passes the turn.");
    }
}