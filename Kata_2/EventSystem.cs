namespace Kata_2;

public class EventSystem
{
    public static event Action<string, int>? HealthChanged;
    public static event Action<string, string>? SpecialActionPerformed;
    
    
    public static void NotifyHealthChanged(string characterName, int newHealth)
    {
        HealthChanged?.Invoke(characterName, newHealth);
    }
    public static void NotifySpecialActionPerformed(string characterName, string action)
    {
        SpecialActionPerformed?.Invoke(characterName, action);
    }
    
    
    public static void SubscribeToHealthChanged(Action<string, int>? handler)
    {
        HealthChanged += handler;
    }
    public static void SubscribeToSpecialAction(Action<string, string>? handler)
    {
        SpecialActionPerformed += handler;
    }
    
    
    
    public void UnsubscribeFromHealthChanged(Action<string, int>? handler)
    {
        HealthChanged -= handler;
    }
    public void UnsubscribeFromSpecialAction(Action<string, string>? handler)
    {
        SpecialActionPerformed -= handler;
    }
}