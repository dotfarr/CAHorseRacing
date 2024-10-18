using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing
{
    public class Event
    {
        public string name;
        public string location;
        public int numberOfRaces;
        private List<Race> races;


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
            races = new List<Race>();
            
        }

        public Event(string name, string location)
        {
            this.name = name;
            this.location = location;
            races = new List<Race>();
                    
        }

         public void AddRace(Race race)
        {
            if (race != null)

            {
                if (string.IsNullOrEmpty(race.RaceName))

                {
                    race.RaceName = $"Race {races.Count + 1}";
                }

                races.Add(race);
                numberOfRaces = races.Count;
            }
        }

        public List<Race> GetRaces()

        {
            return races;
        }

        public void ListRaces()
        {
            Console.WriteLine($"Races for the event {Name} at {Location}:");
                foreach (var race in races)
            { 
                Console.WriteLine($"Race Name: {race.RaceName}, Starting at: {race.StartTime}");
            }
        }
    }
}
