namespace RPGGame.Models
{
    // Mewakili musuh dalam game
    public class Enemy
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int MagicStrength { get; private set; }

        // Konstruktor untuk menginisialisasi properti musuh
        public Enemy(string name, int health, int magicStrength)
        {
            Name = name;
            Health = health;
            MagicStrength = magicStrength;
        }

        // Mengurangi kesehatan musuh sesuai dengan jumlah damage
        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
        }

        // Metode factory untuk membuat jenis musuh tertentu
        public static Enemy CreateEnemy(string type)
        {
            return type switch
            {
                "Fire" => new Enemy("Fire Elemental", 150, 30),
                "Water" => new Enemy("Water Elemental", 120, 25),
                _ => new Enemy("Generic Enemy", 100, 20),
            };
        }
    }
}
