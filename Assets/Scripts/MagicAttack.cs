public interface IAttackStrategy {
    void Execute(Character character, Enemy enemy);
}

public class MagicAttack : IAttackStrategy {
    public void Execute(Character character, Enemy enemy) {
        enemy.TakeDamage(character.magicStrength);
    }
}
