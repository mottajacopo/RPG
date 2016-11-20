using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        private string placeName;
        public string PlaceName
        {
            get
            {
                return placeName;
            }
            private set
            {
                placeName = value;
            }
        }
        public Location(string name)
        {
            PlaceName = name;

        }
    }
}
