﻿using System.Collections.Generic;
using System.Linq;
using Engine.Characters;
using Engine.Items;

namespace Engine
{
    public class Location
    {
        public enum Direction
        {
            North,
            South,
            East,
            West,
            Top,
            Bottom
        }

        private readonly SortedList<int, int> _monstersAtLocation = new SortedList<int, int>();

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public Item ItemRequiredToEnter { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Vendor VendorWorkingHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }

        public bool HasAMonster { get { return _monstersAtLocation.Count > 0; } }
        public bool HasAQuest { get { return QuestAvailableHere != null; } }
        public bool HasAItemRequiredToEnter { get { return ItemRequiredToEnter != null; } }
        public bool DoesNotHaveAnItemRequiredToEnter { get { return ItemRequiredToEnter == null; } }

        public Location(int id, string name, string description, 
            Item itemRequiredToEnter = null, Quest questAvailableHere = null)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemRequiredToEnter;
            QuestAvailableHere = questAvailableHere;
        }

        public SortedList<int, int> Monsters
        {
            get
            {
                return _monstersAtLocation;
            }
        }

        public void AddMonster(int monsterID, int percentageOfAppearance)
        {
            if(_monstersAtLocation.ContainsKey(monsterID))
            {
                _monstersAtLocation[monsterID] = percentageOfAppearance;
            }
            else
            {
                _monstersAtLocation.Add(monsterID, percentageOfAppearance);
            }
        }

        public Monster NewInstanceOfMonsterLivingHere()
        {
            if(!HasAMonster)
            {
                return null;
            }

            // Total the percentages of all monsters at this location.
            int totalPercentages = _monstersAtLocation.Values.Sum();

            // Select a random number between 1 and the total (in case the total of percentages is not 100).
            int randomNumber = RandomNumberGenerator.NumberBetween(1, totalPercentages);

            // Loop through the monster list, 
            // adding the monster's percentage chance of appearing to the runningTotal variable.
            // When the random number is lower than the runningTotal,
            // that is the monster to return.
            int runningTotal = 0;
            
            foreach(KeyValuePair<int, int> monsterKeyValuePair in _monstersAtLocation)
            {
                runningTotal += monsterKeyValuePair.Value;

                if(randomNumber <= runningTotal)
                {
                    return Game.Instance.world.MonsterByID(monsterKeyValuePair.Key).NewInstanceOfMonster();
                }
            }

            // In case there was a problem, return the last monster in the list.
            return Game.Instance.world.MonsterByID(_monstersAtLocation.Keys.Last()).NewInstanceOfMonster();
        }
    }
}
