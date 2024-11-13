using System;

namespace RPGGame.Models
{
    // Item ramuan kesehatan yang meningkatkan kesehatan karakter
    public class HealthPotion : IItem
    {
        public void Use(Character character)
        {
            character.LevelUp();
            Console.WriteLine($"{character.GetType().Name} menggunakan Ramuan Kesehatan. Kesehatan meningkat!");
        }
    }
}
