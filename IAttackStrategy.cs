namespace RPGGame.Models
{
    // Antarmuka untuk berbagai strategi serangan
    public interface IAttackStrategy
    {
        void Execute(Character character, Enemy enemy);
    }
}
