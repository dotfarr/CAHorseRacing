namespace HorseRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Event racingEvent = CreateEvent();

          
            Console.WriteLine($"Event: {racingEvent.Name} at {racingEvent.Location}");
        }

        static Event CreateEvent()
        {
            Console.WriteLine("Create a new horse racing event:");
            Console.Write("Enter event name: ");
            string eventName = Console.ReadLine();

            Console.Write("Enter event location: ");
            string eventLocation = Console.ReadLine();

            return new Event(eventName, eventLocation);
        }
    }
}