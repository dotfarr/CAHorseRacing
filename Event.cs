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
        public List<Race> races;


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

        // default constructor 
        public Event() 

        {
            Name = "unknown";
            Location = "unknown";
            NumberOfRaces = 0;
            races = new List<Race>();
            
        }

        // constructor 
        public Event(string name, string location, int numberOfRaces)
        {
            this.name = name;
            this.location = location;
            this.numberOfRaces = numberOfRaces;
            races = new List<Race>();
                    
        }

        //method to add race to event
         public void AddRace(Race race)
        {
            races.Add(race);
          
        }

        // method to give a list of races in a event
        public List<Race> GetRaces()

        {
            return races;
        }

        // method to display a list of races in an event
        public void ListRaces()
        {
            Console.WriteLine($"Races for the event {Name} at {Location}:");
            int raceID = 1;    
            
            foreach (var race in races)
            { 
                Console.WriteLine($"Race {raceID} Name: {race.RaceName}, Starting at: {race.StartTime}");
                raceID++;
            }
        }

        // method to display the details of a event
        public void EventDetails()
        {
            Console.WriteLine($"Race Event {Name} at {Location} with {NumberOfRaces} races.");
        }

        // method to add horse to a race in an event
        public void AddHorseToRace (int raceIndex, string name, DateOnly dateOfBirth, int horseID)
        {
            races[raceIndex].AddHorse(new Horse(name, dateOfBirth, horseID));
        }
    }
}
