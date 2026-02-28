namespace CabilloCalendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] events = new string[5];
            string[] dates = new string[5];
            int eventCount = 0;
            bool manageOption = true;

            Console.WriteLine("--- CABILLO CALENDAR MANAGEMENT SYSTEM ---");

            while (manageOption)
            {
                Console.WriteLine("Options:\n1 = (Add Event), 2 = (View events), 3 = (Update Event), 4 = (Delete Event), 5 = (Exit)");
                Console.Write("Select an option (1, 2, 3, 4, 5): ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    if (eventCount < events.Length)
                    {
                        Console.Write("Enter a date (MM/DD/YYYY) \n(for example: 12/1/2005): ");
                        string inputDate = Console.ReadLine();
                        Console.Write("Enter your event for this day: ");
                        string inputEvent = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(inputDate) && !string.IsNullOrWhiteSpace(inputEvent))
                        {
                            dates[eventCount] = inputDate;
                            events[eventCount] = inputEvent;
                            eventCount++;
                            Console.WriteLine("Your event has been successfully added!\n");
                        }
                        else
                        {
                            Console.WriteLine("Error: Date and Event cannot be empty. Please input your event for it to be added.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Calendar is full! (Limit is 5 events)\n");
                    }
                }

                else if (choice == "2")

                {

                    Console.WriteLine("\n--- YOUR SCHEDULES/EVENTS ---");

                    if (eventCount == 0)

                    {

                        Console.WriteLine("Your calendar is currently empty. Please select '1' to add an event to your calendar.\n");

                    }
                    else
                    {
                        for (int i = 0; i < eventCount; i++)
                        {
                            Console.WriteLine($"{i + 1}. ({dates[i]}) : {events[i]}");
                        }
                    }
                }
                else if (choice == "3")
                {
                    if (eventCount == 0)
                    {
                        Console.WriteLine("Nothing to update. Your calendar is empty.\n");
                    }
                    else
                    {
                        Console.Write("Enter the number of date to update your event.): ");
                        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= eventCount)
                        {
                            Console.Write("Enter new date: (MM/DD/YYYY) \n(for example: 12/1/2005): ");
                            dates[index - 1] = Console.ReadLine();
                            Console.Write("Enter new event description: ");
                            events[index - 1] = Console.ReadLine();
                            Console.WriteLine("Event updated successfully!\n");
                        }
                        else { Console.WriteLine("Invalid event number.\n"); }
                    }
                }
                else if (choice == "4")
                {
                    if (eventCount == 0)
                    {
                        Console.WriteLine("Empty\n");
                    }
                    else
                    {
                        Console.Write("Enter the number of the event to delete: ");
                        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= eventCount)
                        {
                            for (int i = index - 1; i < eventCount - 1; i++)
                            {
                                dates[i] = dates[i + 1];
                                events[i] = events[i + 1];
                            }
                            eventCount--;
                            Console.WriteLine("Event deleted successfully!\n");
                        }
                        else { Console.WriteLine("Invalid event number.\n"); }
                    }
                }
                else if (choice == "5")
                {
                    manageOption = false;
                    Console.WriteLine("Thank you for using Cabillo's Calendar Event Management!");
                }
    
            }
        }
    }
}