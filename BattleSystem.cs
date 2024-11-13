namespace RPGGame.Models
{
    public class BattleSystem
    {
        private IAttackStrategy? _attackStrategy;

        public void SetAttackStrategy(IAttackStrategy strategy)
        {
            _attackStrategy = strategy;
        }

        public void StartBattle(Character character, Enemy enemy)
        {
            if (_attackStrategy == null)
            {
                Console.WriteLine("Strategi serangan tidak diatur.");
                return;
            }

            while (character.Health > 0 && enemy.Health > 0)
            {
                _attackStrategy.Execute(character, enemy);
                
                // Simulasi serangan balik musuh
                character.TakeDamage(10); // Misalnya, musuh menyerang karakter dengan 10 damage
            }

            if (character.Health <= 0)
                Console.WriteLine("Karakter kalah dalam pertempuran.");
            else
                Console.WriteLine("Musuh berhasil dikalahkan!");
        }
    }
}
