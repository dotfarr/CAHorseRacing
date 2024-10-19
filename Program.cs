namespace HorseRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {

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

                        Console.WriteLine("Option 2");

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