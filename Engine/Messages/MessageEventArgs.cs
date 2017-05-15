using System;

namespace Engine.Messages
{
    public enum MessageTypes
    {
        NeedAKey,
        MonsterDidDamageYou,
        MosterKilledYou
    }

    public class MessageEventArgs : EventArgs
    {
        



        public string Message { get; private set; }
        public bool AddExtraNewLine { get; private set; }

        public MessageEventArgs(string message, bool addExtraNewLine)
        {
            Message = message;
            AddExtraNewLine = addExtraNewLine;
        }

        public MessageEventArgs(MessageTypes typeMessage, string name)
        {

            if(typeMessage.Equals(MessageTypes.NeedAKey))
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
            
        }


    }
}
