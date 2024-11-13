namespace OrangeBelt;

internal abstract class Program
{
    private static void Main()
    {
        var characters = new List<Character>
        {
            new ("Bran", 30, "Warrior"),
            new ("Arin", 90, "Warrior", Actions.Attack),
            new ("Cara", 70, "Warrior", Actions.Attack),
            new ("Dalia", 40, "Healer", Actions.Heal),
        };
        Console.WriteLine("Starting actions based on character health...\n");

        foreach (var character in characters)
        {
            if (character.PrimaryAction == null)
            {
                continue;
            }
            
            if (character.Health < 50)
            {
                Console.WriteLine($"{character.Name} is attacking first due to low health! Health: {character.Health}");
            }
            else
            {
                Console.WriteLine(character.Role == "Healer"
                        ? $"{character.Name} is prioritizing healing for the character with the lowest health."
                        : $"{character.Name} charges with a fierce attack!");
            }

            character.PrimaryAction?.Invoke(character.Name);
        }
    }
}