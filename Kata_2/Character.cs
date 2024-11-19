namespace Kata_2;

    public class Character
    {
        public string Name { get; private set; }
        public int Health;
        
        protected Character(string name, int health)
        {
            Name = name;
            Health = health;
            
            EventSystem.SubscribeToHealthChanged(OnHealthChanged);
            EventSystem.SubscribeToSpecialAction(OnSpecialActionPerformed);
        }

        private void OnHealthChanged(string characterName, int newHealth)
        {
            if (characterName == Name)
            {
                Console.WriteLine($"[Event] {Name}'s health changed to {newHealth}.\n");
            }
        }
        private void OnSpecialActionPerformed(string characterName, string action)
        {
            if (characterName == Name)
            {
                Console.WriteLine($"[Event] {Name} performed special action: {action}.\n");
            }
        }
    }