namespace Kata_5;

    public class Healer : Character, IHeal
    {
        public Healer(string name, int health, ILogger logger) : base(name, health, logger)
        {
        }
    
        public void Heal(Character target, int healAmount)
        {
            Logger.Log($"{Name} heals {target.Name} for {healAmount}!");
            target.Health += healAmount;
        
            EventSystem.NotifyHealthChanged(target.Name, target.Health);
        }
        public void PerformSpecialAction()
        {
            string action = "Healing Aura";
            Logger.Log($"{Name} performs {action}!");
        
            EventSystem.NotifySpecialActionPerformed(Name, action);
        }
    }
