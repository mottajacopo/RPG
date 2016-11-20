using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Character
    {
        private string nickname;
        public string Nickname
        {
            get
            {
                return nickname;
            }
            private set
            {
                nickname = value;
            }
        }

        private int lifePoints;
        public int LifePoints
        {
            get
            {
                return lifePoints;
            }
            private set
            {
                lifePoints = value;
            }
        }

        private int thirst;
        public int Thirst
        {
            get
            {
                return thirst;
            }
            private set
            {
                thirst = value;
            }
        }

        private int hunger;
        public int Hunger
        {
            get
            {
                return hunger;
            }
            private set
            {
                hunger = value;
            }
        }

        private int mentalSanity;
        public int MentalSanity
        {
            get
            {
                return mentalSanity;
            }
            private set
            {
                mentalSanity = value;
            }
        }

        private int sickness;
        public int Sickness   
        {
            get
            {
                return sickness;
            }
            private set
            {
                sickness = value;
            }
        }

        public Character(string nickname, int lp , int thirst , int hunger , int mentalSanity , int sickness)
        {
            Nickname = nickname;
            LifePoints = lp;
            Thirst = thirst;
            Hunger = hunger;
            MentalSanity = mentalSanity;
            Sickness = sickness;
        }
    }
}
