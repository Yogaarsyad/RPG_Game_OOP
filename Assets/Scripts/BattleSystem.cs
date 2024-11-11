using UnityEngine;

public class BattleSystem : MonoBehaviour {
    public Character character; // Akan dihubungkan dari Inspector
    private Enemy enemy;

    private void Start() {
        // Ambil instance dari karakter utama dan buat musuh menggunakan EnemyFactory
        character = Character.Instance;
        enemy = EnemyFactory.CreateEnemy("Fire");

        // Memulai pertempuran
        StartBattle(character, enemy);
    }

    public void StartBattle(Character character, Enemy enemy) {
        Debug.Log("Pertarungan dimulai!");

        // Menggunakan strategi serangan MagicAttack
        IAttackStrategy strategy = new MagicAttack(); 
        while (character.health > 0 && enemy.health > 0) {
            // Karakter menyerang musuh
            strategy.Execute(character, enemy);
            Debug.Log($"Karakter menyerang! HP Musuh: {enemy.health}");

            if (enemy.health <= 0) {
                Debug.Log("Musuh dikalahkan!");
                character.LevelUp();
                break;
            }

            // Musuh menyerang karakter
            character.health -= 10; // Contoh serangan musuh
            Debug.Log($"Musuh menyerang! HP Karakter: {character.health}");

            if (character.health <= 0) {
                Debug.Log("Karakter kalah!");
                break;
            }
        }
    }
}
