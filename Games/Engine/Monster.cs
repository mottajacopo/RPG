using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
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

        public Monster(int lpMax, int lpRemaining, int hitPoints, string name, Item reward) : base(lpMax, lpRemaining, hitPoints)
        {
            Name = name;
            ItemReward = reward;
        }

    }
}
