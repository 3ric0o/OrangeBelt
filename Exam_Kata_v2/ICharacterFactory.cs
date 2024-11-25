namespace Exam_Kata_v2;

public interface ICharacterFactory
{
    ICharacter CreateWarrior(string name);
    ICharacter CreateMage(string name);
    ICharacter CreateHealer(string name);
}