namespace RPGGame.Models
{
    // Antarmuka untuk item yang dapat digunakan oleh karakter
    public interface IItem
    {
        void Use(Character character);
    }
}
