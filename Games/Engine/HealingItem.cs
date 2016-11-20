using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class HealingItem : Item
    {
        private int amountToHeal;
        public int AmountToHeal
        {
            get
            {
                return amountToHeal;
            }
            private set
            {
                amountToHeal = value;
            }
        }

        public HealingItem(string name, string pluralName, int id, int heal) : base(name, pluralName, id)
        {
            AmountToHeal = heal;
        }
    }
}
