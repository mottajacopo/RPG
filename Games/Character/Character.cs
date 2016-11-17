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

        public Character(string nickname)
        {
            Nickname = nickname;
        }
    }
}
