using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{

    public class Item
    {
        private string name;
        public string ItemName
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

        private string pluralName;
        public string ItemPluralName
        {
            get
            {
                return pluralName;
            }
            private set
            {
                pluralName = value;
            }
        }


        private int id;
        public int ID
        {
            get
            {
                return id;
            }
            private set
            {
                id = value;
            }
        }

        public Item(string name, string pluralName, int id)
        {
            ItemName = name;
            ItemPluralName = pluralName;
            ID = id;
        }

    }
}
