using UnityEngine;

public class Character : MonoBehaviour {
    public static Character Instance { get; private set; }
    public int health = 100;
    public int magicStrength = 50;
    public int experience = 0;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Mempertahankan saat perubahan scene
        } else {
            Destroy(gameObject);
        }
    }

    public void LevelUp() {
        health += 10;
        magicStrength += 5;
        experience += 100;
    }
}
