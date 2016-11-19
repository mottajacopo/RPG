using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Attributes
    {
        private int strength;       // A measure of how physically strong a character is
        private int intelligence;   // A measure of a character's problem-solving ability
        private int willPower;      // A measure of the character's mental resistance (against pain, fear etc.)
        private int charisma;       // A measure of a character's social skills, and sometimes their physical appearance.
        private int luck;           // A measure of a character's luck.  Luck might influence anything, but mostly random items, encounters and outstanding successes/failures 

        public int Strength
        {
            get
            {
                return strength;
            }
            private set
            {
                strength = value;
            }
        }
        public int Intelligence
        {
            get
            {
                return intelligence;
            }
            private set
            {
                intelligence = value;
            }
        }

        public int WillPower
        {
            get
            {
                return willPower;
            }
            set
            {
                willPower = value;
            }
        }
        public int Charisma
        {
            get
            {
                return charisma;
            }
            private set
            {
                charisma = value;
            }
        }
        public int Luck
        {
            get
            {
                return luck;
            }
            set
            {
                luck = value;
            }
        }

        public Attributes(int strength, int intelligence, int willPower, int charisma, int luck)
        {
            Strength = strength;            
            Intelligence = intelligence;
            WillPower = willPower;
            Charisma = charisma;
            Luck = luck;
        }


    }
}
