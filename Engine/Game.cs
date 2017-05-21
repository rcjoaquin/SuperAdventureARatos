using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Game
    {
        public static Game Instance = new Game();


        public const int UNSELLABLE_ITEM_PRICE = -1;
        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int LOCATION_ID_HOME = 1;

        public static bool NewWorld = true;

        public World world {get;set;}

        public List<Player> players { get; set; }
    }
}
