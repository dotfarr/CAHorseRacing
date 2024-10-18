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
        public DateTime startTime;
        private List<Horse> horses;

        public string RaceName
        {
            get { return raceName; }
            set { raceName = value; }

        }
        
        public DateTime StartTime
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
            RaceName = "Race 1";
            StartTime = DateTime.Now;
            Horses = new List<Horse>();
        }

        public Race(string racename, DateTime starttime)
        {
            this.RaceName = racename;
            this.StartTime = starttime;
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
