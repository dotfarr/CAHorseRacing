using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HorseRacing
{
    public class Race
    {
        public string raceName;
        public string startTime;
        private List<Horse> horses;

        public string RaceName
        {
            get { return raceName; }
            set { raceName = value; }

        }
        
        public string StartTime
        {
            get { return startTime; }
            set { startTime = value; }

        }

        public List<Horse> Horses
        {
            get { return horses; }
            set { horses = value; }

        }

        public Race()
        {
            raceName = "Race 1";
            startTime = "12 Noon";
            Horses = new List<Horse>();
        }

        public Race(string racename, string starttime)
        {
            this.raceName = racename;
            this.startTime = starttime;
            Horses = new List<Horse>();
        
        }

        // method add horse to race

        public void AddHorse(Horse horse)
        {
            Horses.Add(horse);

        }

        public void ListHorses() 
        
        {
            Console.WriteLine($"The horses competing on the race {RaceName} are:");
            
            foreach (Horse horse in horses)
            {
                Console.WriteLine($"Horse Name: {horse.Name}, Date of Birth: {horse.DateOfBirth}, Horse ID: {horse.HorseID}");
            }
        }
    }
}
