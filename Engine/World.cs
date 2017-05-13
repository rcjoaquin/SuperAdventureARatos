using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace Engine
{
    
    public static class World
    {
        

        private static readonly List<Item> _items = new List<Item>();
        private static readonly List<Monster> _monsters = new List<Monster>();
        private static readonly List<Quest> _quests = new List<Quest>();
        private static readonly List<Location> _locations = new List<Location>();
        private static readonly List<Vendor> _vendors = new List<Vendor>();

        public const int UNSELLABLE_ITEM_PRICE = -1;

        public const int ITEM_ID_RUSTY_SWORD = 1;
        //public const int ITEM_ID_RAT_TAIL = 2;
        //public const int ITEM_ID_PIECE_OF_FUR = 3;
        //public const int ITEM_ID_SNAKE_FANG = 4;
        //public const int ITEM_ID_SNAKESKIN = 5;
        //public const int ITEM_ID_CLUB = 6;
        //public const int ITEM_ID_HEALING_POTION = 7;
        //public const int ITEM_ID_SPIDER_FANG = 8;
        //public const int ITEM_ID_SPIDER_SILK = 9;
        //public const int ITEM_ID_ADVENTURER_PASS = 10;

        //public const int MONSTER_ID_RAT = 1;
        //public const int MONSTER_ID_SNAKE = 2;
        //public const int MONSTER_ID_GIANT_SPIDER = 3;

        //public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        //public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;

        public const int LOCATION_ID_HOME = 1;
        //public const int LOCATION_ID_TOWN_SQUARE = 2;
        //public const int LOCATION_ID_GUARD_POST = 3;
        //public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        //public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
        //public const int LOCATION_ID_FARMHOUSE = 6;
        //public const int LOCATION_ID_FARM_FIELD = 7;
        //public const int LOCATION_ID_BRIDGE = 8;
        //public const int LOCATION_ID_SPIDER_FIELD = 9;

        //public const int VENDOR_ID_BOB_THE_RAT_CATCHER = 1;

        //static World()
        //{
        //    string xmlWorld = string.Empty;
        //    CreateWorldFromXmlString(xmlWorld);
        //}


        public static void CreateWorldFromXmlString(string xmlWorld)
        {
            string pasos= string.Empty;
            try
            {
                pasos = "Inicializando";
                XmlDocument worldData = new XmlDocument();

                pasos = "Cargando el XML";
                worldData.LoadXml(xmlWorld);

                pasos = "Cargando los Elementos";
                #region Populate Items
                foreach (XmlNode node in worldData.SelectNodes("/World/items/item"))
                {
                    int Id = Convert.ToInt32(node.SelectSingleNode("Id").InnerText);
                    string Name = node.SelectSingleNode("Name").InnerText;
                    string NamePlural = node.SelectSingleNode("NamePlural").InnerText;
                    int Price = Convert.ToInt32(node.SelectSingleNode("Price").InnerText);

                    _items.Add(new Item(Id, Name, NamePlural, Price));
                }
                #endregion

                pasos = "Cargando las Armas";
                #region Populate Weapons
                foreach (XmlNode node in worldData.SelectNodes("/World/items/weapon"))
                {
                    int Id = Convert.ToInt32(node.SelectSingleNode("Id").InnerText);
                    string Name = node.SelectSingleNode("Name").InnerText;
                    string NamePlural = node.SelectSingleNode("NamePlural").InnerText;
                    int Price = Convert.ToInt32(node.SelectSingleNode("Price").InnerText);
                    int MinimumDamage = Convert.ToInt32(node.SelectSingleNode("MinimumDamage").InnerText);
                    int MaximumDamage = Convert.ToInt32(node.SelectSingleNode("MaximumDamage").InnerText);

                    _items.Add(new Weapon(Id, Name, NamePlural, MinimumDamage, MaximumDamage, Price));
                }
                #endregion

                pasos = "Cargando las Pociones";
                #region Populate Healing Potions
                foreach (XmlNode node in worldData.SelectNodes("/World/items/healingPotion"))
                {
                    int Id = Convert.ToInt32(node.SelectSingleNode("Id").InnerText);
                    string Name = node.SelectSingleNode("Name").InnerText;
                    string NamePlural = node.SelectSingleNode("NamePlural").InnerText;
                    int Price = Convert.ToInt32(node.SelectSingleNode("Price").InnerText);
                    int AmountToHeal = Convert.ToInt32(node.SelectSingleNode("AmountToHeal").InnerText);
                   
                    _items.Add(new HealingPotion(Id, Name, NamePlural, AmountToHeal,Price));
                }
                #endregion

                pasos = "Cargando los Monstruos";
                #region Populate Monsters
                foreach (XmlNode node in worldData.SelectNodes("/World/Monsters/Monster"))
                {
                    int Id = Convert.ToInt32(node.SelectSingleNode("Id").InnerText);
                    string Name = node.SelectSingleNode("Name").InnerText;
                    int MaximumDamage = Convert.ToInt32(node.SelectSingleNode("MaximumDamage").InnerText);
                    int RewardExperiencePoints = Convert.ToInt32(node.SelectSingleNode("RewardExperiencePoints").InnerText);
                    int RewardGold = Convert.ToInt32(node.SelectSingleNode("RewardGold").InnerText);
                    int CurrentHitPoints = Convert.ToInt32(node.SelectSingleNode("CurrentHitPoints").InnerText);
                    int MaximumHitPoints = Convert.ToInt32(node.SelectSingleNode("MaximumHitPoints").InnerText);

                    Monster monster = new Monster(Id, Name, MaximumDamage,RewardExperiencePoints,RewardGold,CurrentHitPoints,MaximumHitPoints);

                    foreach (XmlNode nodechild in node.SelectNodes("LootTable/LootItem"))
                    {
                        int IdItem = Convert.ToInt32(nodechild.SelectSingleNode("IdItem").InnerText);
                        int DropPercentage = Convert.ToInt32(nodechild.SelectSingleNode("DropPercentage").InnerText);
                        bool IsDefaultItem = Convert.ToBoolean(nodechild.SelectSingleNode("IsDefaultItem").InnerText);

                        monster.LootTable.Add(new LootItem(ItemByID(IdItem), DropPercentage, IsDefaultItem));
                    }

                    _monsters.Add(monster);

                }
                #endregion

                pasos = "Cargando las Quests";
                #region Populate Quests
                foreach (XmlNode node in worldData.SelectNodes("/World/Quests/Quest"))
                {
                    int Id = Convert.ToInt32(node.SelectSingleNode("Id").InnerText);
                    string Name = node.SelectSingleNode("Name").InnerText;
                    string Description = node.SelectSingleNode("Description").InnerText;
                    int RewardExperiencePoints = Convert.ToInt32(node.SelectSingleNode("RewardExperiencePoints").InnerText);
                    int RewardGold = Convert.ToInt32(node.SelectSingleNode("RewardGold").InnerText);

                    Quest quest = new Quest(Id, Name,Description, RewardExperiencePoints, RewardGold);

                    foreach (XmlNode nodechild in node.SelectNodes("QuestCompletionItems/QuestCompletionItem"))
                    {
                        int IdItem = Convert.ToInt32(nodechild.SelectSingleNode("IdItem").InnerText);
                        int Quantity = Convert.ToInt32(nodechild.SelectSingleNode("Quantity").InnerText);

                        quest.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(IdItem), Quantity));
                    }

                    

                    int RewardItemId = Convert.ToInt32(node.SelectSingleNode("RewardItem/IdItem").InnerText);

                    quest.RewardItem = ItemByID(RewardItemId);

                    _quests.Add(quest);

                }
                #endregion

                pasos = "Cargando los Vendedores";
                #region Populate Vendors
                foreach (XmlNode node in worldData.SelectNodes("/World/Vendors/Vendor"))
                {
                    int Id = Convert.ToInt32(node.SelectSingleNode("Id").InnerText);
                    string Name = node.SelectSingleNode("Name").InnerText;

                    Vendor vendor = new Vendor(Id, Name);

                    foreach (XmlNode nodechild in node.SelectNodes("Inventory/Item"))
                    {
                        int IdItem = Convert.ToInt32(nodechild.SelectSingleNode("IdItem").InnerText);
                        int Quantity = Convert.ToInt32(nodechild.SelectSingleNode("Quantity").InnerText);

                        vendor.AddItemToInventory(ItemByID(IdItem), Quantity);
                    }

                    _vendors.Add(vendor);

                }
                #endregion

                pasos = "Cargando las localizaciones";
                #region Populate Locations
                foreach (XmlNode node in worldData.SelectNodes("/World/Locations/Location"))
                {
                    int Id = Convert.ToInt32(node.SelectSingleNode("Id").InnerText);
                    string Name = node.SelectSingleNode("Name").InnerText;
                    string Description = node.SelectSingleNode("Description").InnerText;

                    Location location = new Location(Id, Name, Description);

                    if (node.SelectSingleNode("ItemRequiredToEnter") != null)
                    {
                        location.ItemRequiredToEnter = ItemByID(Convert.ToInt32(node.SelectSingleNode("ItemRequiredToEnter").InnerText));
                    }

                    if (node.SelectSingleNode("QuestAvailableHere") != null)
                    {
                        location.QuestAvailableHere = QuestByID(Convert.ToInt32(node.SelectSingleNode("QuestAvailableHere").InnerText));
                    }

                    if (node.SelectSingleNode("VendorWorkingHere") != null)
                    {
                        location.VendorWorkingHere = VendorByID(Convert.ToInt32(node.SelectSingleNode("VendorWorkingHere").InnerText));
                    }

                    if (node.SelectSingleNode("Monsters") != null)
                    {
                        foreach (XmlNode nodechild in node.SelectNodes("Monsters/Monster"))
                        {
                            int IdMonster = Convert.ToInt32(nodechild.SelectSingleNode("IdMonster").InnerText);
                            int PercentageOfAppearance = Convert.ToInt32(nodechild.SelectSingleNode("PercentageOfAppearance").InnerText);

                            location.AddMonster(IdMonster, PercentageOfAppearance);
                        }
                    }

                    _locations.Add(location);
                }
                #endregion

                pasos = "Cargando la vecindad";
                #region Populate Neighborhood
                foreach (XmlNode node in worldData.SelectNodes("/World/Neighborhood/Neighbor"))
                {
                    int IdLocation = Convert.ToInt32(node.SelectSingleNode("IdLocation").InnerText);
                    Location location = LocationByID(IdLocation);

                    if (node.SelectSingleNode("North") != null)
                    {
                        location.LocationToNorth = LocationByID(Convert.ToInt32(node.SelectSingleNode("North").InnerText));
                    }

                    if (node.SelectSingleNode("South") != null)
                    {
                        location.LocationToNorth = LocationByID(Convert.ToInt32(node.SelectSingleNode("South").InnerText));
                    }

                    if (node.SelectSingleNode("East") != null)
                    {
                        location.LocationToNorth = LocationByID(Convert.ToInt32(node.SelectSingleNode("East").InnerText));
                    }

                    if (node.SelectSingleNode("West") != null)
                    {
                        location.LocationToNorth = LocationByID(Convert.ToInt32(node.SelectSingleNode("West").InnerText));
                    }
                }

                #endregion

            }
            catch(Exception ex)
            {
                throw new Exception("Error mientras se estaba " + pasos, ex);
            }
        }
        
        public static Item ItemByID(int id)
        {
            return _items.SingleOrDefault(x => x.ID == id);
        }

        public static Monster MonsterByID(int id)
        {
            return _monsters.SingleOrDefault(x => x.ID == id);
        }

        public static Quest QuestByID(int id)
        {
            return _quests.SingleOrDefault(x => x.ID == id);
        }

        public static Location LocationByID(int id)
        {
            return _locations.SingleOrDefault(x => x.ID == id);
        }

        public static Vendor VendorByID(int id)
        {
            return _vendors.SingleOrDefault(x => x.ID == id);
        }
    }
}
