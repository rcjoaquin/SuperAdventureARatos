namespace Engine.Items
{
    public class HealingPotion : Item
    {
        public int AmountToHeal { get; set; }

        public HealingPotion(int id, string name, string namePlural, int amountToHeal, int price)
            : base(id, name, namePlural, price)
        {
            AmountToHeal = amountToHeal;
            this._type = Item.ItemType.HealingPotion;

        }
    }
}