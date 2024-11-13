namespace RPGGame.Models
{
    public class Character
    {
        public int Health { get; private set; }
        public int MagicStrength { get; private set; }
        public int ExperiencePoints { get; private set; }
        private static Character? _instance;

        private Character(int health, int magicStrength)
        {
            Health = health;
            MagicStrength = magicStrength;
            ExperiencePoints = 0;
        }

        public static Character Instance(int health = 100, int magicStrength = 50)
        {
            if (_instance == null)
            {
                _instance = new Character(health, magicStrength);
            }
            return _instance;
        }

        public void LevelUp()
        {
            ExperiencePoints += 100; // Naik XP
            Health += 10;  // Naik health saat level up
            MagicStrength += 5; // Naik magic strength saat level up
        }

        public void AttackEnemy(Enemy enemy)
        {
            enemy.TakeDamage(MagicStrength);
        }

        // Metode untuk menerima damage dari musuh
        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
                Health = 0;
        }
    }
}
