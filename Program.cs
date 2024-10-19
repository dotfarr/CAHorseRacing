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