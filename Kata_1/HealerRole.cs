namespace OrangeBelt;

    public class HealerRole : ICharacterRole
    {
        public Action<string> PrimaryAction => Actions.Heal;

        public void PerformRoleSpecificAction(Character character)
        {
            PrimaryAction?.Invoke(character.Name);
        }
        
        public void HealLowestHealthCharacter(List<Character> characters, Character healer)
        {
            var lowestHealthCharacter = characters
                .Where(c => c.Role is not HealerRole && c != healer)
                .OrderBy(c => c.Health)
                .FirstOrDefault();

            if (lowestHealthCharacter != null)
            {
                Console.WriteLine($"{healer.Name} is prioritizing healing for {lowestHealthCharacter.Name} who has the lowest health.");
                PrimaryAction?.Invoke(healer.Name);
            }
        }
    }
