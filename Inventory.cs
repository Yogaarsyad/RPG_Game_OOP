using System.Collections.Generic;

namespace RPGGame.Models
{
    // Mengelola inventaris karakter untuk menyimpan item
    public class Inventory
    {
        private List<IItem> _items = new List<IItem>();

        // Menambahkan item ke dalam inventaris
        public void AddItem(IItem item)
        {
            _items.Add(item);
        }

        // Menggunakan item, memberikan efeknya kepada karakter
        public void UseItem(IItem item)
        {
            item.Use(Character.Instance());
        }
    }
}
