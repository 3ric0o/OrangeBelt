using System.Threading.Channels;

namespace Kata_3;

class Program
{
    static void Main()
    {
        var abilityContainer = new AbilityContainer<IAbility>();
        
        var attackAbility = new AttackAbility();
        var healAbility = new HealAbility();
        
        abilityContainer.AddAbility(attackAbility);
        abilityContainer.AddAbility(healAbility);
        
        Console.Clear();
        
        Console.WriteLine("Abilities in the container:");
        abilityContainer.DisplayAbilities();
        
        Console.WriteLine();
        
        Console.WriteLine("Checking if 'Slash Attack' is in the container: ");
        Console.WriteLine(abilityContainer.RetrieveAbility(attackAbility) ? "Found!" : "Not Found!");
        
        Console.WriteLine();
        
        Console.WriteLine("Removing Healing Light");
        abilityContainer.RemoveAbility(healAbility);
        
        Console.WriteLine();
        
        Console.WriteLine("Abilities after removing 'Healing Light':");
        abilityContainer.DisplayAbilities();
        
        Console.WriteLine();
        
        Console.WriteLine("Executing Abilities");
        abilityContainer.Execute(attackAbility);
        abilityContainer.Execute(healAbility);
    }
}

