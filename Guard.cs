using System;

namespace RPGGame.Models
{
    // Strategi bertahan dimana karakter menjaga diri dan tidak terkena damage
    public class Guard : IAttackStrategy
    {
        public void Execute(Character character, Enemy enemy)
        {
            Console.WriteLine($"{character.GetType().Name} sedang menjaga diri dan tidak terkena damage kali ini.");
        }
    }
}
