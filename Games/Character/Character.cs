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
        public Character(string nickname, int lp)
        {
            Nickname = nickname;
            LifePoints = lp;
        }
    }
}
