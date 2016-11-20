using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Weapon : Item
    {
        private int minimumDamage ;
        public int MinimumDamage
        {
            get
            {
                return  minimumDamage;
            }
            private set
            {
                minimumDamage = value;
            }
        }


        private int maximumDamage;
        public int MaximumDamage
        {
            get
            {
                return maximumDamage;
            }
            private set
            {
                maximumDamage = value;
            }
        }

        public Weapon(string name, string pluralName, int id,int minDmg,int maxDmg ) : base (name, pluralName, id)
        {
            MinimumDamage = minDmg;
            MaximumDamage = maxDmg;
        }
    }
}
