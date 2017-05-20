using System;

namespace Engine.Messages
{
    public enum MessageTypes
    {
        LoadingItems,
        LoadingWeapons,
        LoadingHealingPotions,
        LoadingMonsters,
        LoadingQuests,
        LoadingVendors,
        LoadingLocations,
        
        NeedAKey,
        MonsterDidDamageYou,
        MosterKilledYou
    }

    public class MessageEventArgs : EventArgs
    {
        



        public string Message { get; private set; }
        public bool AddExtraNewLine { get; private set; }
        public int Percentage { get; private set; }

        public MessageEventArgs(string message, bool addExtraNewLine)
        {
            Message = message;
            AddExtraNewLine = addExtraNewLine;
        }

        public MessageEventArgs(MessageTypes typeMessage, string name)
        {
            
            if (typeMessage.Equals(MessageTypes.NeedAKey))
            {
                Message = "You must have a " + name + " to enter this location.";
                AddExtraNewLine = true;
            }

            if (typeMessage.Equals(MessageTypes.MosterKilledYou))
            {
                Message = "The " + name + " killed you.";
                AddExtraNewLine = true;
            }
            
        }

        public MessageEventArgs(MessageTypes typeMessage, string name, string value)
        {

            if (typeMessage.Equals(MessageTypes.MonsterDidDamageYou))
            {
                Message = "The " + name + " did " + value + " points of damage.";
                AddExtraNewLine = true;
            }

        }

        public MessageEventArgs(MessageTypes typeMessage)
        {
            if (typeMessage.Equals(MessageTypes.LoadingItems))
            {
                Message = "Loading Items...";
                AddExtraNewLine = false;
                Percentage = 20;
            }

            if (typeMessage.Equals(MessageTypes.LoadingMonsters))
            {
                Message = "Loading Monsters...";
                AddExtraNewLine = false;
                Percentage = 40;
            }

            if (typeMessage.Equals(MessageTypes.LoadingQuests))
            {
                Message = "Loading Quests...";
                AddExtraNewLine = false;
                Percentage = 50;
            }

            if (typeMessage.Equals(MessageTypes.LoadingVendors))
            {
                Message = "Loading Vendors...";
                AddExtraNewLine = false;
                Percentage = 60;
            }

            if (typeMessage.Equals(MessageTypes.LoadingLocations))
            {
                Message = "Loading Locations...";
                AddExtraNewLine = false;
                Percentage = 70;
            }
        }


    }
}
