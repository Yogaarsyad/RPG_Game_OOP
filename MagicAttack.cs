using System;

namespace RPGGame.Models
{
    // Strategi serangan yang menggunakan sihir
    public class MagicAttack : IAttackStrategy
    {
        public void Execute(Character character, Enemy enemy)
        {
            enemy.TakeDamage(character.MagicStrength);
            Console.WriteLine($"{character.GetType().Name} menyerang {enemy.Name} dengan sihir sebesar {character.MagicStrength} damage.");
        }
    }
}
