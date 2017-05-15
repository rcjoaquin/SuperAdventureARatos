﻿namespace Engine.Items
{
    public class Item
    {
        protected enum ItemType
        {
            None,
            Weapon,
            HealingPotion
        }

        protected ItemType _type;

        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public int Price { get; set; }
        
        public Item(int id, string name, string namePlural, int price)
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
            Price = price;

            this._type = Item.ItemType.None;

        }

        public bool IsWeapon()
        {
            return _type.Equals(ItemType.Weapon);
        }

        public bool IsHealingPotion()
        {
            return _type.Equals(ItemType.HealingPotion);
        }
    }
}