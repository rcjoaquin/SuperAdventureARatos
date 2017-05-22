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
        private List<Location> place;

        private List<Item> _items = new List<Item>();
        private List<Monster> _monsters = new List<Monster>();
        private List<Quest> _quests = new List<Quest>();
        private List<Location> _locations = new List<Location>();
        private List<Vendor> _vendors = new List<Vendor>();

        private string _xmlWorld;

        public int minX;
        public int maxX;
        public int minY;
        public int maxY;

        

        public event EventHandler<MessageEventArgs> OnMessage;

        public Item ItemByID(int id)
        {
            return _items.SingleOrDefault(x => x.ID == id);
        }

        public List<Item> ListItems()
        {
            return _items;
        }

        public void AddItem(string Name, string NamePlural, int Price)
        {
            _items.Add(new Item(_items.Count, Name,NamePlural, Price));
        }

        public Monster MonsterByID(int id)
        {
            return _monsters.SingleOrDefault(x => x.ID == id);
        }

        public List<Monster> ListMonsters()
        {
            return _monsters;
        }

        public Quest QuestByID(int id)
        {
            return _quests.SingleOrDefault(x => x.ID == id);
        }

        public List<Quest> ListQuests()
        {
            return _quests;
        }

        public Location LocationByID(int id)
        {
            return _locations.SingleOrDefault(x => x.ID == id);
        }

        public List<Location> ListLocations()
        {
            return _locations;
        }

        public Vendor VendorByID(int id)
        {
            return _vendors.SingleOrDefault(x => x.ID == id);
        }

        public List<Vendor> ListVendors()
        {
            return _vendors;
        }

        public World(string xmlWorld)
        {
            this._xmlWorld = xmlWorld;
        }

        public bool LoadWorld()
        {
            try
            {
                XmlDocument worldData = new XmlDocument();

                worldData.LoadXml(this._xmlWorld);

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

        public string ToXmlString()
        {
            XmlDocument worldData = new XmlDocument();

            // Create the top-level XML node
            XmlNode nodeWorld = worldData.CreateElement("World");
            worldData.AppendChild(nodeWorld);

            #region Create Node Items

            // Create the "items" child node
            XmlNode nodeItems = worldData.CreateElement("items");
            
            foreach (Item item in _items)
            {
                XmlNode nodeItem;
                if (item is Weapon)
                {
                    Weapon weapon = item as Weapon;
                    nodeItem = worldData.CreateElement("weapon");
                    CreateNewChildXmlNode(worldData, nodeItem, "MinimumDamage", weapon.MinimumDamage);
                    CreateNewChildXmlNode(worldData, nodeItem, "MaximumDamage", weapon.MaximumDamage);
                }
                else if( item is HealingPotion)
                {
                    HealingPotion healingPotion = item as HealingPotion;
                    nodeItem = worldData.CreateElement("healingPotion");
                    CreateNewChildXmlNode(worldData, nodeItem, "AmountToHeal", healingPotion.AmountToHeal);
                }
                else
                {
                    nodeItem = worldData.CreateElement("item");
                }

                CreateNewChildXmlNode(worldData, nodeItem, "Id", item.ID);
                CreateNewChildXmlNode(worldData, nodeItem, "Name", item.Name);
                CreateNewChildXmlNode(worldData, nodeItem, "NamePlural", item.NamePlural);
                CreateNewChildXmlNode(worldData, nodeItem, "Price", item.Price);

                nodeItems.AppendChild(nodeItem);
            }

            nodeWorld.AppendChild(nodeItems);

            #endregion

            #region Create Node Monsters

            // Create the "Monsters" child node
            XmlNode nodeMonsters = worldData.CreateElement("Monsters");
            
            foreach(Monster monster in _monsters)
            {
                XmlNode nodeMonster = worldData.CreateElement("Monster");

                CreateNewChildXmlNode(worldData, nodeMonster, "Id", monster.ID);
                CreateNewChildXmlNode(worldData, nodeMonster, "Name", monster.Name);
                CreateNewChildXmlNode(worldData, nodeMonster, "MaximumDamage", monster.MaximumDamage);
                CreateNewChildXmlNode(worldData, nodeMonster, "RewardExperiencePoints", monster.RewardExperiencePoints);
                CreateNewChildXmlNode(worldData, nodeMonster, "RewardGold", monster.RewardGold);
                CreateNewChildXmlNode(worldData, nodeMonster, "CurrentHitPoints", monster.CurrentHitPoints);
                CreateNewChildXmlNode(worldData, nodeMonster, "MaximumHitPoints", monster.MaximumHitPoints);

                if(monster.LootTable.Count >0 )
                {
                    XmlNode nodeLootTable = worldData.CreateElement("LootTable");

                    foreach(LootItem lootItem in monster.LootTable)
                    {
                        CreateNewChildXmlNode(worldData, nodeLootTable, "IdItem", lootItem.Details.ID);
                        CreateNewChildXmlNode(worldData, nodeLootTable, "DropPercentage", lootItem.DropPercentage);
                        CreateNewChildXmlNode(worldData, nodeLootTable, "IsDefaultItem", lootItem.IsDefaultItem);
                    }

                    nodeMonster.AppendChild(nodeLootTable);
                }

                nodeMonsters.AppendChild(nodeMonster);
            }

            nodeWorld.AppendChild(nodeMonsters);

            #endregion

            #region Create Node Quests

            XmlNode nodeQuests = worldData.CreateElement("Quests");
            
            foreach (Quest quest in _quests)
            {
                XmlNode nodeQuest = worldData.CreateElement("Quest");

                CreateNewChildXmlNode(worldData, nodeQuest, "Id", quest.ID);
                CreateNewChildXmlNode(worldData, nodeQuest, "Name", quest.Name);
                CreateNewChildXmlNode(worldData, nodeQuest, "Description", quest.Description);
                CreateNewChildXmlNode(worldData, nodeQuest, "RewardExperiencePoints", quest.RewardExperiencePoints);
                CreateNewChildXmlNode(worldData, nodeQuest, "RewardGold", quest.RewardGold);
                
                if(quest.QuestCompletionItems.Count>0)
                {
                    XmlNode nodeQuestCompletionItems = worldData.CreateElement("QuestCompletionItems");

                    foreach (QuestCompletionItem questCompletionItem in quest.QuestCompletionItems)
                    {
                        XmlNode nodeQuestCompletionItem = worldData.CreateElement("QuestCompletionItem");

                        CreateNewChildXmlNode(worldData, nodeQuestCompletionItem, "IdItem", questCompletionItem.Details.ID);
                        CreateNewChildXmlNode(worldData, nodeQuestCompletionItem, "Quantity", questCompletionItem.Quantity);

                        nodeQuestCompletionItems.AppendChild(nodeQuestCompletionItem);
                    }

                    nodeQuest.AppendChild(nodeQuestCompletionItems);
                }

                if(quest.RewardItem!= null)
                {
                    XmlNode modeRewardItem = worldData.CreateElement("RewardItem");

                    CreateNewChildXmlNode(worldData, modeRewardItem, "IdItem", quest.RewardItem.ID);

                    nodeQuest.AppendChild(modeRewardItem);
                }

                nodeQuests.AppendChild(nodeQuest);
            }

            nodeWorld.AppendChild(nodeQuests);

            #endregion

            #region Create Node Vendors

            XmlNode nodeVendors = worldData.CreateElement("Vendors");
            
            foreach(Vendor vendor in _vendors)
            {
                XmlNode nodeVendor = worldData.CreateElement("Vendor");

                CreateNewChildXmlNode(worldData, nodeVendor, "Id", vendor.ID);
                CreateNewChildXmlNode(worldData, nodeVendor, "Name", vendor.Name);

                if(vendor.Inventory.Count > 0)
                {
                    foreach(InventoryItem inventoryItem in vendor.Inventory)
                    {
                        XmlNode nodeInventoryItem = worldData.CreateElement("Vendor");
                        
                        CreateNewChildXmlNode(worldData, nodeVendor, "IdItem", inventoryItem.Details.ID);
                        CreateNewChildXmlNode(worldData, nodeVendor, "Quantity", inventoryItem.Quantity);

                        nodeVendor.AppendChild(nodeInventoryItem);
                    }
                }

                nodeVendors.AppendChild(nodeVendor);
            }

            nodeWorld.AppendChild(nodeVendors);


            #endregion

            #region Create Node Locations

            XmlNode nodeLocations = worldData.CreateElement("Locations");
            
            foreach(Location location in _locations)
            {
                XmlNode nodeLocation = worldData.CreateElement("Location");

                CreateNewChildXmlNode(worldData, nodeLocation, "Id", location.ID);
                CreateNewChildXmlNode(worldData, nodeLocation, "Name", location.Name);
                CreateNewChildXmlNode(worldData, nodeLocation, "Description", location.Description);

                if (!string.IsNullOrEmpty(location.Picture))
                {
                    CreateNewChildXmlNode(worldData, nodeLocation, "Picture", location.Picture);                    
                }

                if (location.ItemRequiredToEnter!=null)
                {
                    CreateNewChildXmlNode(worldData, nodeLocation, "ItemRequiredToEnter", location.ItemRequiredToEnter.ID);
                }

                if (location.QuestAvailableHere!= null)
                {
                    CreateNewChildXmlNode(worldData, nodeLocation, "QuestAvailableHere", location.QuestAvailableHere.ID);                    
                }

                if (location.VendorWorkingHere!= null)
                {
                    CreateNewChildXmlNode(worldData, nodeLocation, "VendorWorkingHere", location.VendorWorkingHere.ID);
                }

                if (location.Monsters.Count > 0)
                {
                    XmlNode nodeMonstersAtLocation = worldData.CreateElement("Monsters");

                    foreach(KeyValuePair<int,int> mosterAtLocation in location.Monsters)
                    {
                        XmlNode nodeMonsterAtLocation = worldData.CreateElement("Monster");

                        CreateNewChildXmlNode(worldData, nodeMonsterAtLocation, "IdMonster", mosterAtLocation.Key);
                        CreateNewChildXmlNode(worldData, nodeMonsterAtLocation, "PercentageOfAppearance", mosterAtLocation.Value);

                        nodeLocation.AppendChild(nodeMonsterAtLocation);
                    }
                    
                    nodeLocation.AppendChild(nodeMonstersAtLocation);
                }

                nodeLocations.AppendChild(nodeLocation);
            }

            nodeWorld.AppendChild(nodeLocations);

            #endregion

            #region Create Node Neighborhood

            XmlNode nodeNeighborhood = worldData.CreateElement("Neighborhood");

            foreach(Location location in _locations)
            {
                XmlNode nodeNeighbor = worldData.CreateElement("Neighbor");

                CreateNewChildXmlNode(worldData, nodeNeighbor, "IdLocation", location.ID);

                if (location.LocationToNorth != null)
                {
                    CreateNewChildXmlNode(worldData, nodeNeighbor, "North", location.LocationToNorth.ID);
                }

                if (location.LocationToSouth != null)
                {
                    CreateNewChildXmlNode(worldData, nodeNeighbor, "South", location.LocationToSouth.ID);
                }

                if (location.LocationToEast != null)
                {
                    CreateNewChildXmlNode(worldData, nodeNeighbor, "East", location.LocationToEast.ID);
                }

                if (location.LocationToWest != null)
                {
                    CreateNewChildXmlNode(worldData, nodeNeighbor, "West", location.LocationToWest.ID);
                }

                nodeNeighborhood.AppendChild(nodeNeighbor);
            }

            nodeWorld.AppendChild(nodeNeighborhood);
            
            #endregion

            return worldData.InnerXml; // The XML document, as a string, so we can save the data to disk
        }

        private void CreateNewChildXmlNode(XmlDocument document, XmlNode parentNode, string elementName, object value)
        {
            XmlNode node = document.CreateElement(elementName);
            node.AppendChild(document.CreateTextNode(value.ToString()));
            parentNode.AppendChild(node);
        }

        private void AddXmlAttributeToNode(XmlDocument document, XmlNode node, string attributeName, object value)
        {
            XmlAttribute attribute = document.CreateAttribute(attributeName);
            attribute.Value = value.ToString();
            node.Attributes.Append(attribute);
        }

        public void CalculateXYLocations()
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

        public void CalculateMinMaxXY()
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

        public List<Location> GetPlace()
        {
            Location home = LocationByID(Game.LOCATION_ID_HOME);

            place = new List<Location>();

            home.x = _locations.Count;
            home.y = _locations.Count;

            place.Add(home);

            CalculateXYLocations();

            CalculateMinMaxXY();

            return place;
        }

        public DataTable GetDataTablePlace()
        {
            Location home = LocationByID(Game.LOCATION_ID_HOME);

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
                    if (place.Find(l => l.x == col && l.y == row) != null)
                    {

                        Location loc = place.Find(l => l.x == col && l.y == row);

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

        private void RaiseMessage(MessageTypes MessageType)
        {
            if (OnMessage != null)
            {
                OnMessage(null, new MessageEventArgs(MessageType));
                //OnMessage(this, new MessageEventArgs(MessageType, name));
            }
        }
    }
}
