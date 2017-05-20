using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Xml;
using Engine.Characters;
using Engine.Items;
using Engine.Messages;

namespace Engine
{
    
    public class World
    {
        private static List<Location> place;

        private static List<Item> _items = new List<Item>();
        private static List<Monster> _monsters = new List<Monster>();
        private static List<Quest> _quests = new List<Quest>();
        private static List<Location> _locations = new List<Location>();
        private static List<Vendor> _vendors = new List<Vendor>();

        public const int UNSELLABLE_ITEM_PRICE = -1;
        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int LOCATION_ID_HOME = 1;

        public static int minX;
        public static int maxX;
        public static int minY;
        public static int maxY;

        public static event EventHandler<MessageEventArgs> OnMessage;

        public static Item ItemByID(int id)
        {
            return _items.SingleOrDefault(x => x.ID == id);
        }

        public static List<Item> ListItems()
        {
            return _items;
        }

        public static void AddItem(string Name, string NamePlural, int Price)
        {
            _items.Add(new Item(_items.Count, Name,NamePlural, Price));
        }

        public static Monster MonsterByID(int id)
        {
            return _monsters.SingleOrDefault(x => x.ID == id);
        }

        public static List<Monster> ListMonsters()
        {
            return _monsters;
        }

        public static Quest QuestByID(int id)
        {
            return _quests.SingleOrDefault(x => x.ID == id);
        }

        public static List<Quest> ListQuests()
        {
            return _quests;
        }

        public static Location LocationByID(int id)
        {
            return _locations.SingleOrDefault(x => x.ID == id);
        }

        public static List<Location> ListLocations()
        {
            return _locations;
        }

        public static Vendor VendorByID(int id)
        {
            return _vendors.SingleOrDefault(x => x.ID == id);
        }

        public static List<Vendor> ListVendors()
        {
            return _vendors;
        }

        public static bool LoadWorld(string xmlWorld)
        {
            string pasos = string.Empty;
            try
            {
                pasos = "Inicializando";
                XmlDocument worldData = new XmlDocument();

                pasos = "Cargando el XML";
                worldData.LoadXml(xmlWorld);

                pasos = "Cargando los Elementos";
                RaiseMessage(MessageTypes.LoadingItems);
                #region Populate Items
                _items = new List<Item>();
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

                    _items.Add(new HealingPotion(Id, Name, NamePlural, AmountToHeal, Price));
                }
                #endregion

                pasos = "Cargando los Monstruos";
                RaiseMessage(MessageTypes.LoadingMonsters);
                #region Populate Monsters
                _monsters = new List<Monster>();
                foreach (XmlNode node in worldData.SelectNodes("/World/Monsters/Monster"))
                {
                    int Id = Convert.ToInt32(node.SelectSingleNode("Id").InnerText);
                    string Name = node.SelectSingleNode("Name").InnerText;
                    int MaximumDamage = Convert.ToInt32(node.SelectSingleNode("MaximumDamage").InnerText);
                    int RewardExperiencePoints = Convert.ToInt32(node.SelectSingleNode("RewardExperiencePoints").InnerText);
                    int RewardGold = Convert.ToInt32(node.SelectSingleNode("RewardGold").InnerText);
                    int CurrentHitPoints = Convert.ToInt32(node.SelectSingleNode("CurrentHitPoints").InnerText);
                    int MaximumHitPoints = Convert.ToInt32(node.SelectSingleNode("MaximumHitPoints").InnerText);

                    Monster monster = new Monster(Id, Name, MaximumDamage, RewardExperiencePoints, RewardGold, CurrentHitPoints, MaximumHitPoints);

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
                RaiseMessage(MessageTypes.LoadingQuests);
                #region Populate Quests
                _quests = new List<Quest>();
                foreach (XmlNode node in worldData.SelectNodes("/World/Quests/Quest"))
                {
                    int Id = Convert.ToInt32(node.SelectSingleNode("Id").InnerText);
                    string Name = node.SelectSingleNode("Name").InnerText;
                    string Description = node.SelectSingleNode("Description").InnerText;
                    int RewardExperiencePoints = Convert.ToInt32(node.SelectSingleNode("RewardExperiencePoints").InnerText);
                    int RewardGold = Convert.ToInt32(node.SelectSingleNode("RewardGold").InnerText);

                    Quest quest = new Quest(Id, Name, Description, RewardExperiencePoints, RewardGold);

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
                RaiseMessage(MessageTypes.LoadingVendors);
                #region Populate Vendors
                _vendors = new List<Vendor>();
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
                RaiseMessage(MessageTypes.LoadingLocations);
                #region Populate Locations
                _locations = new List<Location>();
                foreach (XmlNode node in worldData.SelectNodes("/World/Locations/Location"))
                {
                    int Id = Convert.ToInt32(node.SelectSingleNode("Id").InnerText);
                    string Name = node.SelectSingleNode("Name").InnerText;
                    string Description = node.SelectSingleNode("Description").InnerText;

                    Location location = new Location(Id, Name, Description);

                    if (node.SelectSingleNode("Picture") != null)
                    {
                        string Picture = node.SelectSingleNode("Picture").InnerText;
                        location.Picture = Picture;
                    }

                    

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
                        location.LocationToSouth = LocationByID(Convert.ToInt32(node.SelectSingleNode("South").InnerText));
                    }

                    if (node.SelectSingleNode("East") != null)
                    {
                        location.LocationToEast = LocationByID(Convert.ToInt32(node.SelectSingleNode("East").InnerText));
                    }

                    if (node.SelectSingleNode("West") != null)
                    {
                        location.LocationToWest = LocationByID(Convert.ToInt32(node.SelectSingleNode("West").InnerText));
                    }
                }

                #endregion

                return true;

            }
            catch (Exception ex)
            {
                //throw new Exception("Error mientras se estaba " + pasos, ex);
                return false;
            }
        }
        
        public static void CalculateXYLocations()
        {
            Location loc = place[place.Count - 1];

            if (loc.LocationToNorth != null && !place.Exists(l => l.ID == loc.LocationToNorth.ID))
            {
                Location newLocation = loc.LocationToNorth;
                newLocation.x = loc.x;
                newLocation.y = loc.y - 1;
                
                place.Add(newLocation);
                CalculateXYLocations();
            }

            if (loc.LocationToSouth != null && !place.Exists(l => l.ID == loc.LocationToSouth.ID))
            {
                Location newLocation = loc.LocationToSouth;
                newLocation.x = loc.x;
                newLocation.y = loc.y + 1;
                
                place.Add(newLocation);
                CalculateXYLocations();
            }

            if (loc.LocationToEast != null && !place.Exists(l => l.ID == loc.LocationToEast.ID))
            {
                Location newLocation = loc.LocationToEast;
                newLocation.x = loc.x +1;
                newLocation.y = loc.y;
                
                place.Add(newLocation);
                CalculateXYLocations();
            }

            if (loc.LocationToWest != null && !place.Exists(l => l.ID == loc.LocationToWest.ID))
            {
                Location newLocation = loc.LocationToWest;
                newLocation.x = loc.x -1;
                newLocation.y = loc.y;
                
                place.Add(newLocation);
                CalculateXYLocations();
            }
        }

        public static void CalculateMinMaxXY()
        {
            minX = _locations.Count;
            maxX = _locations.Count;
            minY = _locations.Count;
            maxY = _locations.Count;

            place.ForEach(l => {

                if (l.x < minX)
                    minX = l.x;

                if (l.x > maxX)
                    maxX = l.x;

                if (l.y < minY)
                    minY = l.y;

                if (l.y > maxY)
                    maxY = l.y;
            });
        }

        public static List<Location> GetPlace()
        {
            Location home = LocationByID(LOCATION_ID_HOME);

            place = new List<Location>();

            home.x = _locations.Count;
            home.y = _locations.Count;

            place.Add(home);

            CalculateXYLocations();

            CalculateMinMaxXY();

            return place;
        }

        public static DataTable GetDataTablePlace()
        {
            Location home = LocationByID(LOCATION_ID_HOME);

            place = new List<Location>();

            home.x = _locations.Count;
            home.y = _locations.Count;

            place.Add(home);

            CalculateXYLocations();

            CalculateMinMaxXY();

            DataTable dataTablePlace = new DataTable();

            for (int col = minX; col <= maxX; col++)
            {
                dataTablePlace.Columns.Add("loc" + (col - minX).ToString(), typeof(string));
            }

            for (int row = minY; row <= maxY; row++)
            {

                DataRow dataRow = dataTablePlace.NewRow();

                for (int col = minX; col <= maxX; col++)
                {
                    if (World.place.Find(l => l.x == col && l.y == row) != null)
                    {

                        Location loc = World.place.Find(l => l.x == col && l.y == row);

                        dataRow["loc" + (col - minX).ToString()] = Environment.NewLine + loc.Name + Environment.NewLine;
                    }
                    else
                    {

                        dataRow["loc" + (col - minX).ToString()] = string.Empty;
                    }

                }

                dataTablePlace.Rows.Add(dataRow);
            }

            return dataTablePlace;
        }

        private static void RaiseMessage(MessageTypes MessageType)
        {
            if (OnMessage != null)
            {
                OnMessage(null, new MessageEventArgs(MessageType));
                //OnMessage(this, new MessageEventArgs(MessageType, name));
            }
        }
    }
}
