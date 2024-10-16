using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing
{
    internal class Event
    {
        public string name;
        public string location;
        public int numberOfRaces;

        public string Name
        { 
            get { return name; } 
            set { name = value; }

        }

        public string Location
        { 
            get { return location; } 
            set { location = value; }  
        }

        public int NumberOfRaces
        { 
            get { return numberOfRaces; } 
            set { numberOfRaces = value; } 
        
        }

        public Event() 

        {
            Name = "unknown";
            Location = "unknown";
            NumberOfRaces = 0;
        }

        public Event(string name, string location, int numberOfRaces)
        {
            this.name = name;
            this.location = location;
            this.numberOfRaces = numberOfRaces;
            
        }
    }
}
