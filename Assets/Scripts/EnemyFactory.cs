using UnityEngine;

public abstract class Enemy : MonoBehaviour {
    public int health;
    public string element;

    public abstract void TakeDamage(int damage);
}

public class FireEnemy : Enemy {
    public FireEnemy() {
        health = 50;
        element = "Fire";
    }

    public override void TakeDamage(int damage) {
        health -= damage;
    }
}

public class EnemyFactory {
    public static Enemy CreateEnemy(string type) {
        switch (type) {
            case "Fire": return new FireEnemy();
            // Tambahkan musuh lain
            default: return null;
        }
    }
}
