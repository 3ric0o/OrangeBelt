
namespace OrangeBelt;

    public class Program
    {
        public static void Main()
        {
            var warriorRole = new WarriorRole();
            var healerRole = new HealerRole();
            
            var warrior = new Character("Bran", 30, warriorRole); 
            var healer = new Character("Dalia", 60, healerRole);  
            var healer2 = new Character("Arin", 90, healerRole); 
            var warrior2 = new Character("Cara", 70, warriorRole);

            var characters = new List<Character> { warrior, healer, healer2, warrior2 };
            
            foreach (var character in characters.OrderBy(c => c.Health))
            {
                if (character.Health < 50 && character.Role == warriorRole)
                {
                    Console.WriteLine($"\n{character.Name} is attacking first due to low health! Health: {character.Health}");
                    character.PerformAction();
                }
            }
            
            foreach (var healerCharacter in characters.Where(healerCharacter => healerCharacter.Role == healerRole))
            {
                var healerRoleInstance = healerCharacter.Role as HealerRole;
                healerRoleInstance?.HealLowestHealthCharacter(characters, healerCharacter);
            }
            
            Console.WriteLine("\nAdditional character actions based on role:");
            foreach (var character in characters)
            {
                character.PerformAction();
            }
        }
    }
