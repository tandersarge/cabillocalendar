using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountManagementAppService;
using AccountDataService;

namespace CabilloCalendar
{
    internal class Program
    {
        static string[] events = new string[5];
        static string[] dates = new string[5];
        static int eventCount = 0;

        static void Main(string[] args)
        {
            bool manageOption = true;

            Console.WriteLine("--- CABILLO CALENDAR MANAGEMENT SYSTEM ---");

            while (manageOption)
            {
                Console.WriteLine("\nOptions:\n1 = (Add Event), 2 = (View events), 3 = (Update Event), 4 = (Delete Event)");
                Console.Write("Select an option (1, 2, 3, 4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddEvent();
                        break;
                    case "2":
                        ViewEvents();
                        break;
                    case "3":
                        UpdateEvent();
                        break;
                    case "4":
                        DeleteEvent();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddEvent()
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

        static void ViewEvents()
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

        static void UpdateEvent()
        {
            Console.Write("Enter the number of date to update your event: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= eventCount)
            {
                Console.WriteLine("Invalid event number.\n");
            }
        }

        static void DeleteEvent()
        {
            Console.Write("Enter the number of the event to delete: ");
            {
                Console.WriteLine("Invalid event number.\n");
            }
        }
    }
}