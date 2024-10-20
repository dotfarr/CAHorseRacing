namespace HorseRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Event[] testEvents = new Event[2];

            Event Naas = new Event("Naas Meet", "Naas", 3);
            int amountRaces = Naas.numberOfRaces;
            for (int i = 0; i < amountRaces; i++)

            {
                string raceName = $"Race {i + 1}";
                string startTime = $"{i + 1} PM";
                Race addedRace = new Race(raceName, startTime);
                Naas.AddRace(addedRace);
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

            Menu menu = new Menu();

            int mainMenuOption = 0;

            while(mainMenuOption != 4)
            {
                mainMenuOption = menu.DisplayMainMenu();

                switch (mainMenuOption)

                {
                    case 1:

                        Event racingEvent = CreateEvent();
                        racingEvent.EventDetails();

                        Console.WriteLine("Do you want to add the race names for this event? - Y?N");
                        string addRaceNames = Console.ReadLine();

                        if (addRaceNames == "Y" || addRaceNames == "y")

                        {
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
                           
                            racingEvent.ListRaces();
                        }

                        else 
                        {
                            Console.WriteLine("Default Values have been set for the Race");
                            Console.WriteLine();
                            
                            int numberRaces = racingEvent.numberOfRaces;

                            for (int i = 0; i < numberRaces; i++)
                            {
                                string raceName = $"Race {i + 1}";

                                string startTime = $"{i + 1}PM";

                                Race addedRace = new Race(raceName, startTime);

                                racingEvent.AddRace(addedRace);
                            }

                            Console.WriteLine("The Races entered");
                            racingEvent.ListRaces();

                        }

                        break;

                    case 2:

                        Console.WriteLine("These are the list of events available, please type the race number, otherwise type 99");

                        Console.WriteLine();
                        int RaceID = 1;
                       
                        foreach (var eventitem in testEvents)
                        {
                            Console.Write($"Event {RaceID}: ");
                            eventitem.EventDetails();
                            Console.WriteLine();
                            RaceID++;
                        }

                        int eventSelected = int.Parse(Console.ReadLine()) - 1;

                        if (eventSelected == 99)
                        {
                            Console.WriteLine("Bye");
                        }

                        else
                        {
                            testEvents[eventSelected].ListRaces();

                        }

                        Console.WriteLine();
                        Console.WriteLine("Enter the Race number that you want to add a horse to:");
                        int raceSelected = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the name of your horse: ");
                        string name = Console.ReadLine();
                        
                        Console.Write("Enter the horse date of birth: ");
                        DateOnly dateOfBirth = DateOnly.Parse(Console.ReadLine());

                        Console.Write("Enter the horse ID: ");
                        int horseID = int.Parse(Console.ReadLine());

                        Horse addedHorse = new Horse(name, dateOfBirth, horseID);

                        addedHorse.HorseDetails();
                        int raceIndex = raceSelected - 1;

                        testEvents[eventSelected].AddHorseToRace(raceIndex, name, dateOfBirth, horseID);

                        testEvents[eventSelected].races[raceIndex].ListHorses();


                        break;

                    case 3:

                        Console.WriteLine("Option 3");

                        break;

                    case 4:
                        Console.WriteLine("Bye");

                        break;

                    default:
                        Console.WriteLine("Not a valid option, please select another");

                        break;
                }

            }

        }

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