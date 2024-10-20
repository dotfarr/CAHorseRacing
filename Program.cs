namespace HorseRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create test array for event
            Event[] testEvents = new Event[2];

            // create horse test data
            Horse horse1 = new Horse { name = "Fast Girl", dateOfBirth = new DateOnly(2022, 05, 05), horseID = 27 };

            Horse horse2 = new Horse { name = "Speedy One", dateOfBirth = new DateOnly(2022, 09, 01), horseID = 34 };

            Horse horse3 = new Horse { name = "Dead Last", dateOfBirth = new DateOnly(2022, 02, 12), horseID = 679 };

            // create test data for event array adding racing detail and horse detail
            Event Naas = new Event("Naas Meet", "Naas", 3);
            int amountRaces = Naas.numberOfRaces;
            for (int i = 0; i < amountRaces; i++)

            {
                string raceName = $"Race {i + 1}";
                string startTime = $"{i + 1} PM";
                Race addedRace = new Race(raceName, startTime);
                Naas.AddRace(addedRace);
                addedRace.Horses.Add(horse1);
                addedRace.Horses.Add(horse2);
                addedRace.Horses.Add(horse3);

            }

            testEvents[0] = Naas;

            Event Newbridge = new Event("Newbridge Meet", "Newbridge", 4);
            int amountRaces2 = Newbridge.numberOfRaces;
            for (int j = 0; j < amountRaces2; j++)

            {
                string raceName = $"Race {j + 1}";
                string startTime = $"{j + 1} PM";
                Race addedRace = new Race(raceName, startTime);
                Newbridge.AddRace(addedRace);

            }

            testEvents[1] = Newbridge;

            // create the menu on console
            Menu menu = new Menu();

            int mainMenuOption = 0;

            while(mainMenuOption != 4)
            {
                mainMenuOption = menu.DisplayMainMenu();

                // logic for menu options
                switch (mainMenuOption)

                {
                    case 1:
                        
                        // create new event

                        Event racingEvent = CreateEvent();
                        
                        // display event 
                        racingEvent.EventDetails();

                        Console.WriteLine("Do you want to add the race names for this event? - Y?N");
                        string addRaceNames = Console.ReadLine();

                        if (addRaceNames == "Y" || addRaceNames == "y")

                        {

                            // for loop to allow manager to add race names and add to event
                            int numberRaces = racingEvent.numberOfRaces;
                            for (int i = 0; i < numberRaces; i++)

                            {
                                Console.WriteLine($"Enter the name fr the Race {i + 1}");
                                string raceName = Console.ReadLine();

                                Console.WriteLine($"Enter the start time for the Race {i + 1}");
                                string startTime = Console.ReadLine() ;

                                Race addedRace = new Race(raceName, startTime);

                                racingEvent.AddRace(addedRace);
                            }

                            Console.WriteLine("The Races entered");
                           
                            // display race names
                            racingEvent.ListRaces();
                        }

                        else 
                        {
                            Console.WriteLine("Default Values have been set for the Race");
                            Console.WriteLine();
                            
                            // for loop to create default race name and times to event
                            int numberRaces = racingEvent.numberOfRaces;

                            for (int i = 0; i < numberRaces; i++)
                            {
                                string raceName = $"Race {i + 1}";

                                string startTime = $"{i + 1}PM";

                                Race addedRace = new Race(raceName, startTime);

                                racingEvent.AddRace(addedRace);
                            }

                            Console.WriteLine("The Races entered");
                            // display race names
                            racingEvent.ListRaces();

                        }

                        break;

                        //adding horse to a race
                    case 2:

                        Console.WriteLine("These are the list of events available, please type the race number, otherwise type 99");

                        Console.WriteLine();
                        
                        // for loop to display races in test data event
                        int RaceID = 1;
                       
                        foreach (var eventitem in testEvents)
                        {
                            Console.Write($"Event {RaceID}: ");
                            eventitem.EventDetails();
                            Console.WriteLine();
                            RaceID++;
                        }

                        // read user choice
                        int eventSelected = int.Parse(Console.ReadLine()) - 1;

                        if (eventSelected == 99)
                        {
                            Console.WriteLine("Bye");
                        }

                        // list the races for the selected event
                        else
                        {
                            testEvents[eventSelected].ListRaces();

                        }

                        // allow user to enter horse details

                        Console.WriteLine();
                        Console.WriteLine("Enter the Race number that you want to add a horse to:");
                        int raceSelected = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the name of your horse: ");
                        string name = Console.ReadLine();
                        
                        Console.Write("Enter the horse date of birth: ");
                        DateOnly dateOfBirth = DateOnly.Parse(Console.ReadLine());

                        Console.Write("Enter the horse ID: ");
                        int horseID = int.Parse(Console.ReadLine());

                        // create horse class with user details
                        Horse addedHorse = new Horse(name, dateOfBirth, horseID);

                        // display horse details for added horse class
                        addedHorse.HorseDetails();

                        // add horse class to the selected race
                        int raceIndex = raceSelected - 1;

                        testEvents[eventSelected].AddHorseToRace(raceIndex, name, dateOfBirth, horseID);

                        testEvents[eventSelected].races[raceIndex].ListHorses();


                        break;

                        // racegoer seeing a list of horses and races in the event
                    case 3:

                        Console.WriteLine("Option 3");

                        Console.WriteLine("Here are the list of upcoming racing events, please type the race event number you wish to attend, otherwise type 99");

                        Console.WriteLine();
                        
                        // display list of events (test events)
                        int RaceAttendID = 1;
                        foreach (var eventitem in testEvents)
                        {
                            Console.Write($"Event {RaceAttendID}: ");
                            eventitem.EventDetails();
                            Console.WriteLine();
                            RaceAttendID++;
                        }

                        // reading user selection
                        int attendEventSelected = int.Parse(Console.ReadLine()) - 1;

                        if (attendEventSelected == 99)
                        {
                            Console.WriteLine("Bye");
                        }

                        // display the list of horses and races for the selected event
                        else
                        {
                            Event displayEvent = testEvents[attendEventSelected];
                            testEvents[attendEventSelected].ListRaces();

                            foreach(Race race in displayEvent.races)
                            {
                                race.ListHorses();
                            }
                              
                                                       
                        }
                        Console.WriteLine();

                        break;

                        // option to exit menu
                    case 4:
                        Console.WriteLine("Bye");

                        break;

                    default:
                        Console.WriteLine("Not a valid option, please select another");

                        break;
                }

            }

        }

        // method to create a new event
        static Event CreateEvent()
        {
            Console.WriteLine("Create a new horse racing event");
            Console.Write("Enter event name: ");
            string eventName = Console.ReadLine();

            Console.Write("Enter event location: ");
            string eventLocation = Console.ReadLine();

            Console.Write("Enter the number of races: ");
                    int numberOfRaces = int.Parse(Console.ReadLine());

                    return new Event(eventName, eventLocation, numberOfRaces);
        }
    }
}