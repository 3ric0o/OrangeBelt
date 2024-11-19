using System;

namespace Kata_2;

    class Program
    {
        static void Main()
        {
            var arin = new Warrior("Arin", 100);
            var dalia = new Healer("Dalia", 100);
            
            arin.Attack(dalia, 10);
            dalia.Heal(dalia, 15);
            
            arin.PerformSpecialAction();
            dalia.PerformSpecialAction();
        }
    }
