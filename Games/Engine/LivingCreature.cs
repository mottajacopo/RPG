using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LivingCreature
    {
        private int maxLifePoints;
        public int MaximumLifePoints
        {
            get
            {
                return maxLifePoints;
            }
            private set
            {
                maxLifePoints = value;
            }
        }

        private int currentLifePoints;
        public int CurrentLifePoints
        {
            get
            {
                return currentLifePoints;
            }
            private set
            {
                currentLifePoints = value;
            }
        }

        private int hitPoints;
        public int HitPoints
        {
            get
            {
                return hitPoints;
            }
            private set
            {
                hitPoints = value;
            }
        }

        public LivingCreature(int lpMax, int lpRemaining, int hitPoints)
        {
            MaximumLifePoints = lpMax;
            CurrentLifePoints = lpRemaining;
            HitPoints = hitPoints;

        }
    }
}
