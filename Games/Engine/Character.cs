using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Character : LivingCreature
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



        public Character(int lpMax, int lpRemaining, int hitPoints, string nickname) : base(lpMax, lpRemaining, hitPoints)
        {
            Nickname = nickname;
        }
    }
}
