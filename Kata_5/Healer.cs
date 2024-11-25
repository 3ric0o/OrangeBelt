namespace Kata_5;

    public class Healer : Character, IHeal
    {
        private readonly int _healAmount;
        public Healer(string name, int health, ILogger logger) : base(name, health, logger)
        {
            _healAmount = 50;
        }
    
        public void Heal(Character target)
        {
            Logger.Log($"{Name} heals {target.Name} for {_healAmount}!");
            target.Health += _healAmount;
        
            EventSystem.NotifyHealthChanged(target.Name, target.Health);
        }
        public void PerformSpecialAction()
        {
            string action = "Healing Aura";
            Logger.Log($"{Name} performs {action}!");
        
            EventSystem.NotifySpecialActionPerformed(Name, action);
        }
    }
