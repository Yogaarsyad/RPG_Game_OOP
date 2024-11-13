using RPGGame.Models;
using System;

namespace RPGGame
{
    // Program utama untuk menjalankan game RPG.
    class Program
    {
        static void Main(string[] args)
        {
            // Inisialisasi karakter dan inventaris.
            Character player = Character.Instance(100, 50);
            Inventory playerInventory = new Inventory();
            playerInventory.AddItem(new HealthPotion());

            // Menggunakan item dari inventaris.
            playerInventory.UseItem(new HealthPotion());

            // Membuat musuh
            Enemy enemy = Enemy.CreateEnemy("Fire");

            // Menyiapkan sistem pertempuran dengan strategi serangan sihir.
            BattleSystem battleSystem = new BattleSystem();
            battleSystem.SetAttackStrategy(new MagicAttack());

            // Memulai pertempuran
            battleSystem.StartBattle(player, enemy);
        }
    }
}
