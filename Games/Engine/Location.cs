using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        private string placeName;
        public string PlaceName
        {
            get
            {
                return placeName;
            }
            private set
            {
                placeName = value;
            }
        }

        public Item itemRequiredToEnter;
        public Item ItemRequiredToEnter
        {
            get
            {
                return itemRequiredToEnter;
            }
            private set
            {
                itemRequiredToEnter = value;
            }
        }

        private Item reward;
        public Item ItemReward
        {
            get
            {
                return reward;
            }
            private set
            {
                reward = value;
            }
        }

        public Location(string name, Item itemRequired, Item reward)
        {
            PlaceName = name;
            ItemRequiredToEnter = itemRequired;
            ItemReward = reward;

        }
    }
}
