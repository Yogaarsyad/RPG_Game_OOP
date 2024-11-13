using System;

namespace RPGGame.Models
{
    // Item ramuan sihir yang meningkatkan kekuatan sihir karakter
    public class MagicPotion : IItem
    {
        public void Use(Character character)
        {
            character.LevelUp();
            Console.WriteLine($"{character.GetType().Name} menggunakan Ramuan Sihir. Kekuatan Sihir meningkat!");
        }
    }
}
